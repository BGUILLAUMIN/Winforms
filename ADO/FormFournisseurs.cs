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
    public partial class FormFournisseurs : Form
    {
        public FormFournisseurs()
        {
            InitializeComponent();
            cbbPays.SelectedValueChanged += CbbPays_SelectedValueChanged;
        }

        private void CbbPays_SelectedValueChanged(object sender, EventArgs e)
        {
            dvgFournisseur.DataSource = DAL.GetFournisseur(cbbPays.SelectedValue.ToString());
            lblValeur.Text = DAL.GetNbProduit(cbbPays.SelectedValue.ToString()).ToString();
        }

        protected override void OnLoad(EventArgs e)
        {
            cbbPays.DataSource = DAL.GetCountry();
            base.OnLoad(e);
        }
    }

}
