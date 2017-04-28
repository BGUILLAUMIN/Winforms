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
    public partial class FormCommandes : Form
    {
        public FormCommandes()
        {
            InitializeComponent();
            cbbClient.SelectedValueChanged += CbbClient_SelectedValueChanged;
            cbbClient.DataSource = DAL.GetCustomer();
        }

        private void CbbClient_SelectedValueChanged(object sender, EventArgs e)
        {
            string a = cbbClient.SelectedValue.ToString();
            a = a.Substring(0, 5);
            dgvCommande.DataSource = DAL.GetCommande(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvCommande.DataSource = DAL.GetCommande(textBox1.Text);
        }
    }
}
