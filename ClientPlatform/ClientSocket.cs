using System;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ClientPlatform
{
    class ClientSocket
    {
        struct StateObject
        {
            public const int BufferSize = 1024;
            public byte[] buffer;
            public StringBuilder sb;
            public Socket workSocket;
        }

        // адрес и порт сервера, к которому будем подключаться
        private readonly int port = 8005; // порт сервера
        private IPAddress address;
        private ManualResetEvent connectDone = new ManualResetEvent(false);
        private ManualResetEvent sendDone = new ManualResetEvent(false);
        private ManualResetEvent receiveDone = new ManualResetEvent(false);

        // The response from the remote device.  
        private String response = String.Empty;

        public void StartConnection(string message)
        {
            //if (Environment.OSVersion.Version.Major.ToString() + Environment.OSVersion.Version.Minor.ToString() != "61")
            //    address = Dns.GetHostEntry("kernelvm").AddressList[1];
            //else
            //    address = Dns.GetHostEntry("kernelvm").AddressList[0];

            if (Environment.OSVersion.Version.Major.ToString() + Environment.OSVersion.Version.Minor.ToString() != "61")
                address = IPAddress.Parse("192.168.179.88");
            else
                address = IPAddress.Parse("192.168.179.88");

            try
            {
                IPEndPoint ipPoint = new IPEndPoint(address, port);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // подключаемся к удаленному хосту
                socket.BeginConnect(ipPoint, new AsyncCallback(ConnectCallback), socket);
                connectDone.WaitOne();

                Send(socket, message);
                sendDone.WaitOne();

                Receive(socket);
                receiveDone.WaitOne();

                // закрываем сокет
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.  
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.  
                connectDone.Set();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Receive(Socket client)
        {
            try
            {
                // Create the state object.  
                StateObject state = new StateObject();
                state.buffer = new byte[StateObject.BufferSize];
                state.sb = new StringBuilder();
                state.workSocket = client;

                // Begin receiving the data from the remote device.  
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket
                // from the asynchronous state object.  
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.  
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.UTF8.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data.  
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.  
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                        PlatformWatcher.Home.GetResponse(response);
                    }
                    // Signal that all bytes have been received.  
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.UTF8.GetBytes(data + "<EOF>");

            // Begin sending the data to the remote device.  
            client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), client);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.  
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}