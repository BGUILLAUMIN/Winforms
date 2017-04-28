using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Commande
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public decimal Freight { get; set; }
        public int NbProduit { get; set; }
        public int MontantTotal { get; set; }
    }
}
