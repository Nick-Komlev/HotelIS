using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using Wrapper;
using System.Runtime.Serialization;

namespace TestKernelApp
{
    public abstract class Controller
    {
        protected delegate string RequestExecution(USerializableList paramls);
        protected Dictionary<string, RequestExecution> Functionaluty = new Dictionary<string, RequestExecution>();

        public Controller() { }

        public abstract string ExecuteRequest(Request rqst);

        public string CreateRequest(string app, string func)
        {
            string path = @".\requestFile.xml";
            string rqstText;

            Request rqst = new Request(app, func, path);
            rqstText = rqst.GetRequest(path);
            

            return rqstText;
        }

        public string CreateRequest(string app, string func, USerializableList paramls)
        {
            string path = @".\requestFile.xml";
            string rqstText;

            Request rqst = new Request(app, func, path, paramls);
            rqstText = rqst.GetRequest(path);

            return rqstText;
        }

        public UString Serializtion(USerializableList list)
        {
            string path = @".\requestFile.xml";
            string text = "";

            try
            {
                File.Delete(path);
            }
            catch { }

            XmlSerializer formatter = new XmlSerializer(typeof(USerializableList));
            using (FileStream fs = new FileStream(path, FileMode.Create))
                formatter.Serialize(fs, list);

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    text += line;
                }
            }
            File.Delete(path);

            return new UString(text);
        }

        public string SerializtionO(List<object> list)
        {
            return "Later";
        }
    }
}
