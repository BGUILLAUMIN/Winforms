using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExplorateurFichier;
using System.IO;

namespace ExplorateurFichier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialisation de la listebox        
            listBox1.Items.Clear();

            // Application d'une icone
            this.Icon = Properties.Resources.IconeLancementPV;

            // Abonnement aux événements
            // Exemple d'utilisation d'expression lambda à la place d'une méthode courte
            cbxNbFichier.CheckedChanged += (object sender, EventArgs e) =>
            {
                lblFichierCs.Visible = cbxNbFichierCs.Checked;
            };
            btnChemin.Click += BtnChemin_Click;
            cbxNbFichierCs.CheckedChanged += CbxNbFichierCs_CheckedChanged;
            cbxNomFichierLong.CheckedChanged += CbxNomFichierLong_CheckedChanged;
            cbxListeFichier.CheckedChanged += CbxListeFichier_CheckedChanged;
            analyser.Click += Analyser_Click;
        }

        private void Analyser_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    var analyse = new Analyseur();
                    analyse.AnalyserDossier(textBox1.Text);

                    lblFichier.Text = analyse.NbFichier.ToString() + " fichiers";
                    lblFichierCs.Text = analyse.NbFichierCS.ToString() + " fichiers .cs";
                    lblFichierNomLong.Text = analyse.NomFichierLong.ToString();

                    foreach (var c in analyse.ListeFichier)
                    {
                        listBox1.Items.Add(c);
                    }
                }
                else
                    throw new DirectoryNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(Properties.Resources.chemin);
                textBox1.Text = "";
            }
        }

        private void CbxNomFichierLong_CheckedChanged(object sender, EventArgs e)
        {
            lblFichierNom.Visible = cbxNomFichierLong.Checked ? true : false; // Opérateur ternaire
            lblFichierNomLong.Visible = cbxNomFichierLong.Checked;
        }

        private void CbxNbFichierCs_CheckedChanged(object sender, EventArgs e)
        {
            lblFichierCs.Visible = cbxNbFichierCs.Checked;
        }

        private void CbxListeFichier_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = cbxListeFichier.Checked;
            label6.Visible = cbxListeFichier.Checked;
            panel1.Visible = cbxListeFichier.Checked;
        }

        private void BtnChemin_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox1.Text = fbd.SelectedPath;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Pas indispensable si on met save, cela sauvegarde automatiquement 
            // si les settings ont été créés depuis la propriété du composant

            //Properties.Settings.Default.FichierLong = cbxNomFichierLong.Checked;
            //Properties.Settings.Default.NbFichierCs = cbxNbFichierCs.Checked;
            //Properties.Settings.Default.NbFichier = cbxNbFichier.Checked;
            //Properties.Settings.Default.ListeFichier = cbxListeFichier.Checked;

            // Si les settings sont créés indépendament des composants, on peut les assigner:
            // Exemple: Properties.Settings.Default.CheminDossier = textBox1.Text
            // Par contre il faut recharger les paramètres dans l'événement OnLoad

            DialogResult dr = MessageBox.Show(Properties.Resources.confirmation, "Oui", MessageBoxButtons.YesNoCancel);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        Properties.Settings.Default.Chemin = textBox1.Text;
                        Properties.Settings.Default.Save();
                        break;
                    }
                case DialogResult.No:
                    break;
                default:
                    e.Cancel = true;
                    break;
            }

        }
    }
}
