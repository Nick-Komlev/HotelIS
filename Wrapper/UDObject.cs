using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
namespace Wrapper
{
    [XmlType("UDObject")]
    public class UDObject : USerializable
    {
        [XmlElement("Id")]
        public int Id;
        public USerializableList Attributes = new USerializableList();

        public UDObject() { }

        public UDObject(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            string name;
            try
            {
                name = (Attributes.Items.Find(i => (i as UAttribute).Name == "ФИО") as UAttribute).Value;
            }
            catch
            {
                name = Id.ToString();
            }
            return name;
        }
    }
}