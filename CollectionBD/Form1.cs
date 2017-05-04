using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            btnNewAutor.Click += (object sender, EventArgs e) => DAL.AjouterAuteur();
            btnAdd.Click += (object sender, EventArgs e) => DAL.AjouterAlbum();
            btnMaj.Click += (object sender, EventArgs e) => DAL.MettreEnMajuscule();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "19" + comboBox1.SelectedItem.ToString().Substring(0, 1);
            lbx.DataSource =  DAL.RecupTitreAlbumAnnee60(a);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
