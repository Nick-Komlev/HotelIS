using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
namespace Wrapper
{
    [XmlType("UObject")]
    public class UObject : USerializable
    {
        [XmlElement("Id")]
        public int Id;

        [XmlElement("Name")]
        public string Name;

        [XmlElement("Prefix")]
        public string Prefix;

        public UObject() { }

        public UObject(int id, string name, string prefix)
        {
            Id = id;
            Name = name;
            Prefix = prefix;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
