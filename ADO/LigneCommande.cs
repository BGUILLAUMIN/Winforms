using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADO
{
    public class LigneCommande
    {
        [XmlIgnore]
        public int OrderID { get; set; }
        [XmlAttribute]
        public int ProductID { get; set; }
        [XmlAttribute]
        public decimal UnitPrice { get; set; }
        [XmlAttribute]
        public int Quantity { get; set; }
        [XmlAttribute]
        public float Discount { get; set; }
    }
}
