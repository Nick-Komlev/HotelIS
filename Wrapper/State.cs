using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;


namespace Wrapper
{
    [XmlType("State")]
    public class State : USerializable
    {
        [XmlElement("Id")]
        public int Id;

        [XmlElement("Name")]
        public string Name;

        public State() { }

        public State(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
