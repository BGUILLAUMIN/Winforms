namespace ADO
{
    partial class FormFournisseurs
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
            this.dvgFournisseur = new System.Windows.Forms.DataGridView();
            this.cbbPays = new System.Windows.Forms.ComboBox();
            this.lblNbProduit = new System.Windows.Forms.Label();
            this.lblValeur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgFournisseur
            // 
            this.dvgFournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFournisseur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgFournisseur.Location = new System.Drawing.Point(0, 48);
            this.dvgFournisseur.Name = "dvgFournisseur";
            this.dvgFournisseur.Size = new System.Drawing.Size(936, 484);
            this.dvgFournisseur.TabIndex = 0;
            // 
            // cbbPays
            // 
            this.cbbPays.FormattingEnabled = true;
            this.cbbPays.Location = new System.Drawing.Point(12, 12);
            this.cbbPays.Name = "cbbPays";
            this.cbbPays.Size = new System.Drawing.Size(121, 21);
            this.cbbPays.TabIndex = 1;
            // 
            // lblNbProduit
            // 
            this.lblNbProduit.AutoSize = true;
            this.lblNbProduit.Location = new System.Drawing.Point(162, 16);
            this.lblNbProduit.Name = "lblNbProduit";
            this.lblNbProduit.Size = new System.Drawing.Size(105, 13);
            this.lblNbProduit.TabIndex = 2;
            this.lblNbProduit.Text = "Nombre de produits :";
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(273, 15);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(37, 13);
            this.lblValeur.TabIndex = 3;
            this.lblValeur.Text = "Valeur";
            // 
            // FormFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 532);
            this.Controls.Add(this.lblValeur);
            this.Controls.Add(this.lblNbProduit);
            this.Controls.Add(this.cbbPays);
            this.Controls.Add(this.dvgFournisseur);
            this.Name = "FormFournisseurs";
            this.Text = "FormFournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dvgFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgFournisseur;
        private System.Windows.Forms.ComboBox cbbPays;
        private System.Windows.Forms.Label lblNbProduit;
        private System.Windows.Forms.Label lblValeur;
    }
}