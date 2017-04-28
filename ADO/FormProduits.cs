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
        private List<Produit> _produitAjoutés;
        private List<Produit> _produitSupprimés;
        public FormProduits()
        {
            InitializeComponent();
            _produitAjoutés = new List<Produit>();
            _produitSupprimés = new List<Produit>();
            btnAjouter.Click += BtnAjouter_Click;
            btnSuppr.Click += BtnSuppr_Click;
            btnEnregistrer.Click += BtnEnregistrer_Click;
            _listProduct = DAL.GetProduit();
            dgvProduits.DataSource = _listProduct;
            dgvProduits.Columns[0].Visible = false;
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var a in _produitAjoutés)
            {
                foreach (var b in _produitSupprimés)
                {
                    if (a == b)
                    {
                        _produitAjoutés.Remove(a);
                        _produitSupprimés.Remove(b);
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
            DAL.InsertEnMasse(_produitAjoutés);
            DAL.DeleteEnMasse(_produitSupprimés);
            _listProduct = DAL.GetProduit();
            dgvProduits.DataSource = _listProduct;
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                var prod = new Produit();
                prod = (Produit)dgvProduits.CurrentRow.DataBoundItem;
                _produitSupprimés.Add(prod);
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
                    _produitAjoutés.Add(produitSaisie);
                    _listProduct.Add(produitSaisie);
                }
            }
        }
    }
}
