using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace TestKernelApp
{
    struct StateObject
    {
        public const int BufferSize = 1024;
        public byte[] buffer;
        public StringBuilder sb;
        public Socket workSocket;
    }

    class AsynchronousSocket
    {
        private readonly int port = 8005; // порт для приема входящих запросов
        private IPAddress address;
        public ManualResetEvent allDone = new ManualResetEvent(false);


        public AsynchronousSocket()
        {
            if (Environment.OSVersion.Version.Major.ToString() + Environment.OSVersion.Version.Minor.ToString() != "61")
                address = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1];
            else
                address = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];

        }

        public void StartListening()
        {
            IPEndPoint ipPoint = new IPEndPoint(address, port);
            Socket listenSocket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listenSocket.Bind(ipPoint);
                listenSocket.Listen(100);

                while (true)
                {
                    allDone.Reset();

                    Console.WriteLine(address.ToString() + " Server runs. Waiting for connection...");
                    listenSocket.BeginAccept(new AsyncCallback(AcceptCallback), listenSocket);

                    allDone.WaitOne();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + address);
            }

            finally
            {
                listenSocket.Dispose();
            }

        }

        public void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            StateObject state = new StateObject();
            state.buffer = new byte[StateObject.BufferSize];
            state.sb = new StringBuilder();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket.
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There might be more data, so store the data received so far.  
                state.sb.Append(Encoding.UTF8.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read more data.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    // Echo the data back to the client.

                    RequestController reqControl = new RequestController();
                    string answer = reqControl.ReadRequest(content);

                    Send(handler, answer);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using UTF8 encoding.  
            byte[] byteData = Encoding.UTF8.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
