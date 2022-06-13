using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.Threading.Tasks;
using Wrapper;

namespace TestKernelApp
{
    public class RequestController
    {
        Controller controller;

        public RequestController()
        {

        }

        public string ReadRequest(string rqstText)
        {
            string path = @".\RequestFile.xml";
            rqstText = rqstText.Remove(rqstText.IndexOf("<EOF>"));

            try
            {
                File.Delete(path);
            }
            catch { }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(rqstText);
            }

            Request rqst;
            XmlSerializer formatter = new XmlSerializer(typeof(Request));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                rqst = (Request)formatter.Deserialize(fs);
            File.Delete(path);

            return ExecuteRequest(rqst);
        }

        private string ExecuteRequest(Request rqst)
        {
            if (rqst.PlatformApp == "Admin")
                controller = new AdminController();
            else if (rqst.PlatformApp == "Booking")
                controller = new BookingController();

            return controller.ExecuteRequest(rqst);

        }
    }
}
