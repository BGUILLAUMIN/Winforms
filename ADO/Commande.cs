using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADO
{
    public class Commande
    {
        [XmlAttribute]
        public int OrderId { get; set; }
        [XmlAttribute]
        public string CustomerID { get; set; }
        [XmlAttribute]
        public DateTime OrderDate { get; set; }
        [XmlIgnore]
        public DateTime RequiredDate { get; set; }
        [XmlIgnore]
        public decimal Freight { get; set; }
        [XmlIgnore]
        public int NbProduit { get; set; }
        [XmlIgnore]
        public int MontantTotal { get; set; }
        public List<LigneCommande> ListeCommande { get; set; }
    }
}
