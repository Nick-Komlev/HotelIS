using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Wrapper
{
    [XmlType("UAttribute")]
    public class UAttribute : USerializable
    {
        [XmlElement("Name")]
        public string Name;

        [XmlElement("Type")]
        public string Type;

        [XmlElement("Value")]
        public string Value;

        public UAttribute() { }

        public UAttribute(string name, string type, string value = "")
        {
            Name = name;
            Type = type;
            Value = value;
        }
    }
}
