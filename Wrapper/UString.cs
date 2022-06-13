using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wrapper
{
    [XmlType("UString")]
    public class UString : USerializable
    {
        [XmlElement("Text")]
        public string Text;

        public UString() { }

        public UString(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
