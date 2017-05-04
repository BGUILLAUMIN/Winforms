using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormLigneCommandes : Form
    {
        private List<Commande> _listeCmd;
        public FormLigneCommandes()
        {
            InitializeComponent();
            _listeCmd = DAL.GetLigneCommande();
            dgvCmd.DataSource = DAL.ImporterXml();
            dgvCmd.Columns["RequiredDate"].Visible = false;
            dgvCmd.Columns["Freight"].Visible = false;
            dgvCmd.Columns["NbProduit"].Visible = false;
            dgvCmd.Columns["MontantTotal"].Visible = false;

            dgvCmd.Click += DgvCmd_Click;
            btnRechercher.Click += BtnRechercher_Click;
            DAL.ExporterXml(_listeCmd);
            DAL.GenererXML(_listeCmd);
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            if (txbRechercher.Text != "")
            {
                dgvCmd.DataSource = _listeCmd.Where(c => c.OrderId == int.Parse(txbRechercher.Text)).ToList();
                //First or default par qu'il renvoie une seul liste
                dgvLigneCmd.DataSource = _listeCmd.Where(c => c.OrderId == int.Parse(txbRechercher.Text)).Select(d => d.ListeCommande).FirstOrDefault();
            }
            else
            {
                dgvCmd.DataSource = _listeCmd;
                dgvLigneCmd.DataSource = ((Commande)dgvCmd.CurrentRow.DataBoundItem).ListeCommande;
                dgvLigneCmd.DataSource = null;
            }
        }

        private void DgvCmd_Click(object sender, EventArgs e)
        {
            dgvLigneCmd.DataSource = ((Commande)dgvCmd.CurrentRow.DataBoundItem).ListeCommande;
        }
    }
}
