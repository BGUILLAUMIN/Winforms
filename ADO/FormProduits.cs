using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormProduits : Form
    {
        private BindingList<Produit> _listProduct;
        public FormProduits()
        {
            InitializeComponent();
            btnAjouter.Click += BtnAjouter_Click;
            btnSuppr.Click += BtnSuppr_Click;
            _listProduct = DAL.GetProduit();
            dgvProduits.DataSource = _listProduct;
            dgvProduits.Columns[0].Visible = false;
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                var prod = new Produit();
                prod = (Produit)dgvProduits.CurrentRow.DataBoundItem;
                DAL.DeleteProduit(prod.ProductID);
                _listProduct.Remove(prod);
            }
            catch (SqlException d)
            {
                if (d.Number == 547)
                    MessageBox.Show("Impossible de supprimer le produit car il est relié a une clé étrangère.");
                else
                    throw;
            }
        }


        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            using (var form = new FormAjouter())
            {
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var produitSaisie = new Produit();
                    produitSaisie = DAL.NouveauProduit(form);
                    DAL.ListeProduit.Add(produitSaisie);
                    DAL.AjouterProduit(produitSaisie);
                }
            }
        }
    }
}
