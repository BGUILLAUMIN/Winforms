using System.Windows.Forms;

namespace ADO
{
    partial class FormAjouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txbCategorie = new System.Windows.Forms.MaskedTextBox();
            this.txbQuantUnit = new System.Windows.Forms.MaskedTextBox();
            this.txbPrixUnit = new System.Windows.Forms.MaskedTextBox();
            this.txbUnitStock = new System.Windows.Forms.MaskedTextBox();
            this.txbFournisseur = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité unitaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix unitaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unités en stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fournisseur";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(117, 18);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(151, 20);
            this.txbNom.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(118, 244);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 21);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(208, 244);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(72, 21);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // txbCategorie
            // 
            this.txbCategorie.Location = new System.Drawing.Point(117, 53);
            this.txbCategorie.Mask = "99";
            this.txbCategorie.Name = "txbCategorie";
            this.txbCategorie.Size = new System.Drawing.Size(72, 20);
            this.txbCategorie.TabIndex = 8;
            // 
            // txbQuantUnit
            // 
            this.txbQuantUnit.Location = new System.Drawing.Point(117, 88);
            this.txbQuantUnit.Mask = "999";
            this.txbQuantUnit.Name = "txbQuantUnit";
            this.txbQuantUnit.Size = new System.Drawing.Size(72, 20);
            this.txbQuantUnit.TabIndex = 8;
            // 
            // txbPrixUnit
            // 
            this.txbPrixUnit.Location = new System.Drawing.Point(117, 123);
            this.txbPrixUnit.Mask = "999.99";
            this.txbPrixUnit.Name = "txbPrixUnit";
            this.txbPrixUnit.Size = new System.Drawing.Size(72, 20);
            this.txbPrixUnit.TabIndex = 8;
            // 
            // txbUnitStock
            // 
            this.txbUnitStock.Location = new System.Drawing.Point(117, 158);
            this.txbUnitStock.Mask = "9999";
            this.txbUnitStock.Name = "txbUnitStock";
            this.txbUnitStock.Size = new System.Drawing.Size(72, 20);
            this.txbUnitStock.TabIndex = 8;
            // 
            // txbFournisseur
            // 
            this.txbFournisseur.Location = new System.Drawing.Point(117, 193);
            this.txbFournisseur.Mask = "999";
            this.txbFournisseur.Name = "txbFournisseur";
            this.txbFournisseur.Size = new System.Drawing.Size(72, 20);
            this.txbFournisseur.TabIndex = 8;
            // 
            // FormAjouter
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(297, 280);
            this.Controls.Add(this.txbFournisseur);
            this.Controls.Add(this.txbUnitStock);
            this.Controls.Add(this.txbPrixUnit);
            this.Controls.Add(this.txbQuantUnit);
            this.Controls.Add(this.txbCategorie);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouter";
            this.Text = "Saisie d\'un produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.MaskedTextBox txbCategorie;
        private System.Windows.Forms.MaskedTextBox txbQuantUnit;
        private System.Windows.Forms.MaskedTextBox txbPrixUnit;
        private System.Windows.Forms.MaskedTextBox txbUnitStock;
        private System.Windows.Forms.MaskedTextBox txbFournisseur;

        public TextBox TxbNom
        {
            get { return txbNom; }
            set { txbNom = value; }
        }
        public MaskedTextBox TxbCategorie
        {
            get { return txbCategorie; }
            set { txbCategorie = value; }
        }
        public MaskedTextBox TxbQuantUnit
        {
            get { return txbQuantUnit; }
            set { txbQuantUnit = value; }
        }
        public MaskedTextBox TxbPrixUnit
        {
            get { return txbPrixUnit; }
            set { txbPrixUnit = value; }
        }
        public MaskedTextBox TxbUnitStock
        {
            get { return txbUnitStock; }
            set { txbUnitStock = value; }
        }
        public MaskedTextBox TxbFournisseur
        {
            get { return txbFournisseur; }
            set { txbFournisseur = value; }
        }




    }
}