using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Wrapper
{
    [Serializable]
    public class Request : ISerializable
    {
        public string PlatformApp;
        public string Function;
        public USerializableList Parameters;

        public Request() { }

        public Request(string app, string func, string path)
        {
            PlatformApp = app;
            Function = func;
            MakeFile(path);
        }

        public Request(string app, string func, string path, USerializableList paramls)
        {
            PlatformApp = app;
            Function = func;
            Parameters = paramls;
            MakeFile(path);
        }

        private void MakeFile(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Request));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                formatter.Serialize(fs, this);
        }

        public string GetRequest(string path)
        {
            string text = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    text += line;
                }
            }
            File.Delete(path);
            return text;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("props", PlatformApp, typeof(string));
            info.AddValue("props", Function, typeof(string));
            info.AddValue("props", Parameters, typeof(USerializableList));
        }
    }
}
