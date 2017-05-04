using System.Xml.Linq;

namespace ADO
{
    internal class Xdocument
    {
        private XElement xElement;

        public Xdocument(XElement xElement)
        {
            this.xElement = xElement;
        }
    }
}