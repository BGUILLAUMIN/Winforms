namespace PersonneTerritoire
{
    partial class Form1
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
            this.dgvTerritoire = new System.Windows.Forms.DataGridView();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.lblPersonne = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerritoire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTerritoire
            // 
            this.dgvTerritoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerritoire.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTerritoire.Location = new System.Drawing.Point(0, 41);
            this.dgvTerritoire.Name = "dgvTerritoire";
            this.dgvTerritoire.Size = new System.Drawing.Size(749, 413);
            this.dgvTerritoire.TabIndex = 0;
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(119, 12);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(160, 21);
            this.cmbPersonne.TabIndex = 1;
            // 
            // lblPersonne
            // 
            this.lblPersonne.AutoSize = true;
            this.lblPersonne.Location = new System.Drawing.Point(12, 15);
            this.lblPersonne.Name = "lblPersonne";
            this.lblPersonne.Size = new System.Drawing.Size(101, 13);
            this.lblPersonne.TabIndex = 2;
            this.lblPersonne.Text = "Nom des personnes";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(614, 12);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(123, 23);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 454);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblPersonne);
            this.Controls.Add(this.cmbPersonne);
            this.Controls.Add(this.dgvTerritoire);
            this.Name = "Form1";
            this.Text = "Personne par territoire";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerritoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTerritoire;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.Label lblPersonne;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}

