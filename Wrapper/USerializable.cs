using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wrapper
{
    [XmlType("USerializable")] // define Type
    [XmlInclude(typeof(UString)), XmlInclude(typeof(UObject)), XmlInclude(typeof(State)), XmlInclude(typeof(UAttribute)), XmlInclude(typeof(UDObject))]
    public class USerializable
    {
        public USerializable() { }
    }

    [XmlRoot("USerializableList")]
    [XmlInclude(typeof(USerializable))]
    public class USerializableList : ISerializable
    {
        [XmlArray("USerializableArray")]
        [XmlArrayItem("USerializable")]
        public List<USerializable> Items = new List<USerializable>();

        public USerializableList() { }

        public USerializableList(List<USerializable> items)
        {
            Items = items;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("props", Items, typeof(List<USerializable>));
        }

        public void Add(USerializable item)
        {
            Items.Add(item);
        }
    }
}
