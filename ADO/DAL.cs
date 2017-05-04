using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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
            string query = @"SELECT ProductID, ProductName, SupplierId, CategoryID, QuantityPerUnit, ROUND(UnitPrice,2)UnitPrice, UnitsInStock FROM Products Where Discontinued = 0 ORDER BY 1";
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

        public static void InsertEnMasse(List<Produit> ListeProduit)
        {
            //Création d'une chaine de connection
            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            //Création d'un string correspondant à la requête SQL
            string queryString = @"INSERT Products (ProductName, SupplierId, CategoryId, QuantityPerUnit, UnitPrice, UnitsInStock)
SELECT ProductName, SupplierId, CategoryId, QuantityPerUnit, UnitPrice, UnitsInStock FROM @MaTable";

            //Création du paramètre de la requete SQL
            var param = new SqlParameter("@MaTable", SqlDbType.Structured);

            //Appelle de la méthode gérant la création de la table intermédiaire
            DataTable tableProd = GetDataTableProduit(ListeProduit);
            param.TypeName = "TypeTableProduit";
            param.Value = tableProd;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();
                SqlTransaction tran = connect.BeginTransaction();

                try
                {
                    var command = new SqlCommand(queryString, connect, tran);
                    command.Parameters.Add(param);
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

        public static DataTable GetDataTableProduit(List<Produit> ListeProduit)
        {
            //Création d'une table mémoire
            DataTable table = new DataTable();

            //Création des différentes colonnes
            //Colonne Nom Produit 
            var colNom = new DataColumn("Nom Produit", typeof(string));
            colNom.AllowDBNull = false;
            table.Columns.Add(colNom);
            //Colonne ID Fournisseur
            table.Columns.Add(new DataColumn("ID Fournisseur", typeof(int)));
            //Colonne ID Categorie
            table.Columns.Add(new DataColumn("ID Categorie", typeof(int)));
            //Colonne Quantité par unité
            table.Columns.Add(new DataColumn("Quantité par unité", typeof(string)));
            //Colonne Prix unitaire
            table.Columns.Add(new DataColumn("Prix unitaire", typeof(decimal)));
            //Colonne Unité en stock
            table.Columns.Add(new DataColumn("Unité en stock", typeof(int)));

            foreach (var p in ListeProduit)
            {
                //Création de chaque ligne de la table, si la valeur est null
                //alors on écrit une valeur null dans la table de type SQL
                DataRow ligne = table.NewRow();
                if (p.ProductName != null) ligne["Nom Produit"] = p.ProductName;
                else ligne["Nom Produit"] = DBNull.Value;
                if (p.SupplierID != 0) ligne["ID Fournisseur"] = p.SupplierID;
                else ligne["ID Fournisseur"] = DBNull.Value;
                if (p.CategoryId != 0) ligne["ID Categorie"] = p.CategoryId;
                else ligne["ID Categorie"] = DBNull.Value;
                if (p.QuantityPerUnit != null) ligne["Quantité par unité"] = p.QuantityPerUnit;
                else ligne["Quantité par unité"] = DBNull.Value;
                if (p.UnitPrice != 0) ligne["Prix unitaire"] = p.UnitPrice;
                else ligne["Prix unitaire"] = DBNull.Value;
                if (p.UnitInStock != 0) ligne["Unité en stock"] = p.UnitInStock;
                else ligne["Unité en stock"] = DBNull.Value;

                //Ajout de ligne dans la table
                table.Rows.Add(ligne);
            }
            return table;
        }

        public static void DeleteEnMasse(List<Produit> ListeProduit)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = "Update Products set Discontinued = 1 where ProductID in (Select Id From @ID)";
            DataTable table = GetDataIDProduit(ListeProduit);
            var param = new SqlParameter("@ID", SqlDbType.Structured);
            param.TypeName = "TypeTableIDProduit";
            param.Value = table;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();
                SqlTransaction tran = connect.BeginTransaction();

                try
                {
                    var command = new SqlCommand(queryString, connect, tran);
                    command.Parameters.Add(param);
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

        public static DataTable GetDataIDProduit(List<Produit> ListeProduit)
        {
            DataTable table = new DataTable();
            var colID = new DataColumn();
            colID.AllowDBNull = false;
            table.Columns.Add(colID);
            table.PrimaryKey = new DataColumn[] { colID };
            foreach (var p in ListeProduit)
            {
                DataRow ligne = table.NewRow();
                ligne[0] = p.ProductID;
                table.Rows.Add(ligne);
            }
            return table;
        }

        public static List<Commande> GetLigneCommande()
        {
            var ListeCmd = new List<Commande>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"Select O.OrderID, O.CustomerID, O.OrderDate, OD.* from Orders O inner join Order_Details OD on O.OrderID = OD.OrderID Order by 1";

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetLigneCommandeFromDataReader(ListeCmd, reader);
                    }
                }
                return ListeCmd;
            }
        }

        public static List<Commande> GetLigneCommandeFromDataReader(List<Commande> ListeCmd, SqlDataReader reader)
        {

            int cmdID = (int)reader["OrderID"];

            Commande cmd = null;

            if (ListeCmd.Count == 0 || ListeCmd[ListeCmd.Count - 1].OrderId != cmdID)
            {
                cmd = new Commande();
                cmd.OrderId = (int)reader["OrderID"];
                cmd.CustomerID = (string)reader["CustomerID"];
                cmd.OrderDate = (DateTime)reader["OrderDate"];
                cmd.ListeCommande = new List<LigneCommande>();
                ListeCmd.Add(cmd);
            }
            else cmd = ListeCmd[ListeCmd.Count - 1];

            LigneCommande ligneCmd = new LigneCommande();
            ligneCmd.OrderID = (int)reader["OrderID"];
            ligneCmd.ProductID = (int)reader["ProductID"];
            ligneCmd.UnitPrice = (decimal)reader["UnitPrice"];
            ligneCmd.Quantity = (Int16)reader["Quantity"];
            ligneCmd.Discount = (float)reader["Discount"];

            cmd.ListeCommande.Add(ligneCmd);

            return ListeCmd;
        }

        #region Traitement XML
        /// <summary>
        /// Serialisation d'une liste de commande en XML
        /// </summary>
        /// <param name="listcmd"></param>
        public static void ExporterXml(List<Commande> listcmd)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Commande>), new XmlRootAttribute("Commandes"));

            using (var sw = new StreamWriter(@"..\..\Commandes.xml"))
            {
                serializer.Serialize(sw, listcmd);
            }
        }
        /// <summary>
        /// Désérialisation d'une liste de commande en XML
        /// </summary>
        /// <returns></returns>
        public static List<Commande> ImporterXml()
        {
            List<Commande> listCmd = null;
            XmlSerializer deserialiser = new XmlSerializer(typeof(List<Commande>), new XmlRootAttribute("Commandes"));

            using (var sr = new StreamReader(@"..\..\Commandes.xml"))
            {
                listCmd = (List<Commande>)deserialiser.Deserialize(sr);
            }
            return listCmd;
        }
        /// <summary>
        /// Génération d'un fichier XML
        /// </summary>
        /// <param name="ListCmd"></param>
        public static void GenererXML(List<Commande> ListCmd)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            //Paramètre d'indentation du type tabulation
            settings.Indent = true;
            settings.IndentChars = "\t";
            //Initialisation des variables pour filtrer les doublons
            int moisCourant = 0;
            int anneeCourant = 0;
            var listeTriée = ListCmd.OrderBy(c => c.OrderDate).ToList();

            using (XmlWriter writer = XmlWriter.Create(@"..\..\Commandes_writer.xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("DatesCommandes");

                foreach (Commande cmd in listeTriée)
                {
                    if (cmd.OrderDate.Month != moisCourant || cmd.OrderDate.Year != anneeCourant)
                    {
                        if (moisCourant != 0) writer.WriteEndElement();
                        writer.WriteStartElement("DateCommande");
                        writer.WriteAttributeString("Annee", cmd.OrderDate.Year.ToString());
                        writer.WriteAttributeString("Mois", cmd.OrderDate.Month.ToString());
                        moisCourant = cmd.OrderDate.Month;
                        anneeCourant = cmd.OrderDate.Year;
                    }
                    else
                    {
                        writer.WriteStartElement("Commande");
                        writer.WriteAttributeString("Id", cmd.OrderId.ToString());
                        var montant = cmd.ListeCommande.Sum(l => l.Quantity * l.UnitPrice * (1 - (decimal)l.Discount));
                        writer.WriteAttributeString("Montant", montant.ToString("000.00"));
                        writer.WriteEndElement();
                    }
                }
                //writer.WriteEndElement();
                //writer.WriteEndElement(); 
                //Ferme les éléments ouverts
                writer.WriteEndDocument();
            }
        } 

        public static List<Commande> Deserialiser()
        {
            var ListCmd = new List<Commande>();
            XDocument doc = XDocument.Load(@"..\..\Commandes_writer.xml");

            foreach (var Cmd in doc.Descendants("Commande").ToList())
            {
                
            }

            return ListCmd;
        }
        #endregion
    }
}


