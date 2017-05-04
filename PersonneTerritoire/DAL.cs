using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneTerritoire
{
    public static class DAL
    {
        public static BindingList<Personne> ListePersonne { get; set; }
        public static BindingList<Personne> GetPersonne()
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = "select EmployeeID, Lastname from Employees order by 1";

            using (var connect = new SqlConnection(connectString))
            {
                var commande = new SqlCommand(queryString, connect);
                connect.Open();
                using (var reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetListePersonne(reader);
                    }
                }
                return ListePersonne;
            } 
        }

        public static void GetListePersonne(SqlDataReader reader)
        {
            var pers = new Personne();
            pers.EmployeeID = (int)reader["EmployeeID"];
            pers.LastName = (string)reader["LastName"];
            ListePersonne.Add(pers);
        }
    }
}
