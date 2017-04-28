using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Fournisseur
    {
        [DisplayName("ID")]
        public int SupplierId { get; set; }
        [DisplayName("Nom Entreprise")]
        public string CompanyName { get; set; }
        [DisplayName("Nom du contact")]
        public string ContactName { get; set; }
        [DisplayName("Titre du contact")]
        public string ContactTitle { get; set; }
        [DisplayName("Adresse")]
        public string Adress { get; set; }
        [DisplayName("Ville")]
        public string City { get; set; }
        public string Region { get; set; }
        [DisplayName("Code Postal")]
        public string PostalCode { get; set; }
        [DisplayName("Pays")]
        public string Country { get; set; }
        public List<string> ListePays { get; set; }
    }
}
