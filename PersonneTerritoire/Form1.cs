using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonneTerritoire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAL.ListePersonne = new BindingList<Personne>();
            var list = DAL.GetPersonne();
            cmbPersonne.DataSource = list;
            foreach (var a in list)
            {
                cmbPersonne.ValueMember = "EmployeeID";
                cmbPersonne.DisplayMember = "LastName";
            }
        }
    }
}
