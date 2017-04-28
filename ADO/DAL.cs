using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{

    public static class DAL
    {
        public static BindingList<Produit> ListeProduit { get; private set; }
        public static void GetListeRegion()
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = "SELECT RegionID, RegionDescription FROM Region";

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}, {1}", reader[0], reader[1]);
                    }
                }
            }
        }

        public static void GetListCommande(List<Commande> Listcmd, SqlDataReader reader)
        {
            var commande = new Commande();
            commande.OrderId = (int)reader[0];
            commande.OrderDate = (DateTime)reader[1];
            commande.RequiredDate = (DateTime)reader[2];
            commande.NbProduit = (int)reader[3];
            commande.MontantTotal = (int)reader[4];
            commande.Freight = (int)reader[5];

            Listcmd.Add(commande);
        }
        private static void GetListSupplier(List<Fournisseur> lstFournisseur, SqlDataReader reader)
        {
            var fournisseur = new Fournisseur();
            fournisseur.SupplierId = (int)reader["SupplierID"];
            fournisseur.CompanyName = (string)reader["CompanyName"];
            if (reader["ContactName"] != DBNull.Value)
                fournisseur.ContactName = (string)reader["ContactName"];
            if (reader["ContactTitle"] != DBNull.Value)
                fournisseur.ContactTitle = (string)reader["ContactTitle"];
            if (reader["Address"] != DBNull.Value)
                fournisseur.Adress = (string)reader["Address"];
            if (reader["City"] != DBNull.Value)
                fournisseur.City = (string)reader["City"];
            if (reader["Region"] != DBNull.Value)
                fournisseur.Region = (string)reader["Region"];
            if (reader["PostalCode"] != DBNull.Value)
                fournisseur.PostalCode = (string)reader["PostalCode"];
            if (reader["Country"] != DBNull.Value)
                fournisseur.Country = (string)reader["Country"];

            lstFournisseur.Add(fournisseur);
        }

        public static List<Commande> GetCommande(string IdClient)
        {
            var listeCommande = new List<Commande>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"select * FROM ufn_ListeCommandeClient(@Idclient)";
            var param = new SqlParameter("@IdClient", DbType.String);
            param.Value = IdClient;
            using (var connect = new SqlConnection(connectString))
            {
                var commande = new SqlCommand(queryString, connect);
                commande.Parameters.Add(param);
                connect.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetListCommande(listeCommande, reader);
                    }
                }
            }
            return listeCommande;
        }

        public static List<Fournisseur> GetFournisseur(string pays)
        {
            var listeFournisseur = new List<Fournisseur>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country FROM Suppliers WHERE Country = @Pays ";
            var param = new SqlParameter("@Pays", DbType.String);
            param.Value = pays;
            using (var connect = new SqlConnection(connectString))
            {
                var commande = new SqlCommand(queryString, connect);
                commande.Parameters.Add(param);
                connect.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetListSupplier(listeFournisseur, reader);
                    }
                }
            }
            return listeFournisseur;
        }

        public static List<string> GetCountry()
        {
            var listCountry = new List<string>();
            string pays;
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"SELECT distinct Country FROM Suppliers ORDER BY 1";

            using (var connect = new SqlConnection(connectString))
            {
                var commande = new SqlCommand(queryString, connect);
                connect.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pays = (string)reader["Country"];
                        Console.WriteLine(reader["Country"]);
                        listCountry.Add(pays);
                    }
                }
            }
            return listCountry;
        }

        public static List<string> GetCustomer()
        {
            var listCountry = new List<string>();
            string client;
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"SELECT distinct CustomerID, ContactName FROM CUSTOMERS ORDER BY 1";

            using (var connect = new SqlConnection(connectString))
            {
                var commande = new SqlCommand(queryString, connect);
                connect.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        client = string.Format("{0}, {1}", reader[0], reader[1]);
                        listCountry.Add(client);
                    }
                }
            }
            return listCountry;
        }

        public static int GetNbProduit(string pays)
        {
            int NbProduit;
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"Select  Count(ProductID) From Suppliers S
                                    inner join Products P on S.SupplierID = P.SupplierID
                                    where Country = @pays ";
            var param = new SqlParameter("@Pays", DbType.String);
            param.Value = pays;
            using (var connect = new SqlConnection(connectString))
            {
                SqlCommand commande = new SqlCommand(queryString, connect);
                commande.Parameters.Add(param);
                connect.Open();
                NbProduit = (int)commande.ExecuteScalar();
            }
            return NbProduit;
        }

        public static BindingList<Produit> GetProduit()
        {
            ListeProduit = new BindingList<Produit>();
            var connecting = Properties.Settings.Default.NorthwindConnectionString;
            string query = @"SELECT ProductID, ProductName, SupplierId, CategoryID, QuantityPerUnit, ROUND(UnitPrice,2)UnitPrice, UnitsInStock FROM Products ORDER BY 1";
            using (var connect = new SqlConnection(connecting))
            {
                var command = new SqlCommand(query, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetListeProduit(ListeProduit, reader);
                    }
                }
                return ListeProduit;
            }
        }

        public static void GetListeProduit(BindingList<Produit> ListeProduit, SqlDataReader reader)
        {
            var prod = new Produit();
            prod.ProductID = (int)reader["ProductID"];
            prod.ProductName = (string)reader["ProductName"];
            if (reader["CategoryId"] != DBNull.Value)
                prod.CategoryId = (int)reader["CategoryId"];
            if (reader["QuantityPerUnit"] != DBNull.Value)
                prod.QuantityPerUnit = (string)reader["QuantityPerUnit"];
            if (reader["UnitPrice"] != DBNull.Value)
                prod.UnitPrice = Math.Round((decimal)reader["UnitPrice"], 2);
            if (reader["UnitsInStock"] != DBNull.Value)
                prod.UnitInStock = (Int16)reader["UnitsInStock"];
            if (reader["SupplierID"] != DBNull.Value)
                prod.SupplierID = (int)reader["SupplierID"];
            ListeProduit.Add(prod);
        }

        public static Produit NouveauProduit(FormAjouter form)
        {
            var produitSaisie = new Produit();
            produitSaisie.ProductName = form.TxbNom.Text;
            if (!string.IsNullOrEmpty(form.TxbCategorie.Text))
                produitSaisie.CategoryId = int.Parse(form.TxbCategorie.Text);
            if (!string.IsNullOrEmpty(form.TxbQuantUnit.Text))
                produitSaisie.QuantityPerUnit = form.TxbQuantUnit.Text;
            if (form.TxbPrixUnit.Text == "   ,  ")
                produitSaisie.UnitPrice = decimal.Parse(form.TxbPrixUnit.Text);
            if (!string.IsNullOrEmpty(form.TxbUnitStock.Text))
                produitSaisie.UnitInStock = int.Parse(form.TxbUnitStock.Text);
            if (!string.IsNullOrEmpty(form.TxbFournisseur.Text))
                produitSaisie.SupplierID = int.Parse(form.TxbFournisseur.Text);
            return produitSaisie;

        }

        public static void DeleteProduit(int produit)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"DELETE FROM PRODUCTS WHERE PRODUCTID = @produit";
            var param = new SqlParameter("@produit", DbType.Int32);
            param.Value = produit;
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);
                connect.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void AjouterProduit(Produit produit)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"INSER Products(ProductName, SupplierId, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock) 
Values (@ProductName, @SupplierId, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock)";
            var param1 = new SqlParameter("@ProductName", DbType.String);
            var param2 = new SqlParameter("@SupplierId", DbType.Int32);
            var param3 = new SqlParameter("@CategoryID", DbType.Int32);
            var param4 = new SqlParameter("@QuantityPerUnit", DbType.String);
            var param5 = new SqlParameter("@UnitPrice", DbType.Decimal);
            var param6 = new SqlParameter("@UnitsInStock", DbType.Int16);
            param1.Value = produit.ProductName;
            if (produit.SupplierID == 0) param2.Value = DBNull.Value;
            else param2.Value = produit.SupplierID;
            if (produit.CategoryId == 0) param3.Value = DBNull.Value;
            else param3.Value = produit.CategoryId;
            if (string.IsNullOrEmpty(produit.QuantityPerUnit)) param4.Value = DBNull.Value;
            else param4.Value = produit.QuantityPerUnit;
            if (produit.UnitPrice == 0) param5.Value = DBNull.Value;
            else param5.Value = produit.UnitPrice;
            if (produit.UnitInStock == 0) param6.Value = DBNull.Value;
            else param6.Value = produit.UnitInStock;

            // Transaction
            string req2 = @"if not exists(Select * from Categories where CategoryID = @IdCategory) begin insert Categories(CategoryName) values ('Autre') end";
            var param7 = new SqlParameter("@IdCategory", DbType.Int32);
            param7.Value = produit.CategoryId;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();
                SqlTransaction tran = connect.BeginTransaction();
                try
                {
                    var command2 = new SqlCommand(req2, connect, tran);
                    command2.Parameters.Add(param7);
                    command2.ExecuteNonQuery();

                    var command = new SqlCommand(queryString, connect, tran);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);
                    command.Parameters.Add(param3);
                    command.Parameters.Add(param4);
                    command.Parameters.Add(param5);
                    command.Parameters.Add(param6);
                    command.ExecuteNonQuery();

                    

                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}

