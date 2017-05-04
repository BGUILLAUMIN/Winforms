namespace ADO
{
    partial class FormLigneCommandes
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
            this.dgvCmd = new System.Windows.Forms.DataGridView();
            this.dgvLigneCmd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txbRechercher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCmd
            // 
            this.dgvCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmd.Location = new System.Drawing.Point(12, 40);
            this.dgvCmd.Name = "dgvCmd";
            this.dgvCmd.Size = new System.Drawing.Size(382, 510);
            this.dgvCmd.TabIndex = 0;
            // 
            // dgvLigneCmd
            // 
            this.dgvLigneCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneCmd.Location = new System.Drawing.Point(404, 40);
            this.dgvLigneCmd.Name = "dgvLigneCmd";
            this.dgvLigneCmd.Size = new System.Drawing.Size(369, 510);
            this.dgvLigneCmd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Commandes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lignes de commandes";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(319, 10);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // txbRechercher
            // 
            this.txbRechercher.Location = new System.Drawing.Point(213, 12);
            this.txbRechercher.Name = "txbRechercher";
            this.txbRechercher.Size = new System.Drawing.Size(100, 20);
            this.txbRechercher.TabIndex = 4;
            // 
            // FormLigneCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 561);
            this.Controls.Add(this.txbRechercher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLigneCmd);
            this.Controls.Add(this.dgvCmd);
            this.Name = "FormLigneCommandes";
            this.Text = "FormLigneCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCmd;
        private System.Windows.Forms.DataGridView dgvLigneCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txbRechercher;
    }
}