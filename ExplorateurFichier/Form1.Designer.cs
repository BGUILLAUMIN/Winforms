namespace ExplorateurFichier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitre = new System.Windows.Forms.Label();
            this.lblFichier = new System.Windows.Forms.Label();
            this.lblFichierCs = new System.Windows.Forms.Label();
            this.lblFichierNom = new System.Windows.Forms.Label();
            this.lblFichierNomLong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxListeFichier = new System.Windows.Forms.CheckBox();
            this.cbxNomFichierLong = new System.Windows.Forms.CheckBox();
            this.cbxNbFichierCs = new System.Windows.Forms.CheckBox();
            this.cbxNbFichier = new System.Windows.Forms.CheckBox();
            this.analyser = new System.Windows.Forms.Button();
            this.btnChemin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitre
            // 
            resources.ApplyResources(this.lbltitre, "lbltitre");
            this.lbltitre.Name = "lbltitre";
            // 
            // lblFichier
            // 
            resources.ApplyResources(this.lblFichier, "lblFichier");
            this.lblFichier.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFichier.Name = "lblFichier";
            // 
            // lblFichierCs
            // 
            resources.ApplyResources(this.lblFichierCs, "lblFichierCs");
            this.lblFichierCs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFichierCs.Name = "lblFichierCs";
            // 
            // lblFichierNom
            // 
            resources.ApplyResources(this.lblFichierNom, "lblFichierNom");
            this.lblFichierNom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFichierNom.Name = "lblFichierNom";
            // 
            // lblFichierNomLong
            // 
            resources.ApplyResources(this.lblFichierNomLong, "lblFichierNomLong");
            this.lblFichierNomLong.Name = "lblFichierNomLong";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.cbxListeFichier);
            this.groupBox1.Controls.Add(this.cbxNomFichierLong);
            this.groupBox1.Controls.Add(this.cbxNbFichierCs);
            this.groupBox1.Controls.Add(this.cbxNbFichier);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbxListeFichier
            // 
            resources.ApplyResources(this.cbxListeFichier, "cbxListeFichier");
            this.cbxListeFichier.Checked = true;
            this.cbxListeFichier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxListeFichier.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ExplorateurFichier.Properties.Settings.Default, "ListeFichier", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxListeFichier.Name = "cbxListeFichier";
            this.cbxListeFichier.UseVisualStyleBackColor = true;
            // 
            // cbxNomFichierLong
            // 
            resources.ApplyResources(this.cbxNomFichierLong, "cbxNomFichierLong");
            this.cbxNomFichierLong.Checked = true;
            this.cbxNomFichierLong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNomFichierLong.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ExplorateurFichier.Properties.Settings.Default, "FichierLong", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxNomFichierLong.Name = "cbxNomFichierLong";
            this.cbxNomFichierLong.UseVisualStyleBackColor = true;
            // 
            // cbxNbFichierCs
            // 
            resources.ApplyResources(this.cbxNbFichierCs, "cbxNbFichierCs");
            this.cbxNbFichierCs.Checked = global::ExplorateurFichier.Properties.Settings.Default.NbFichierCs;
            this.cbxNbFichierCs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNbFichierCs.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ExplorateurFichier.Properties.Settings.Default, "NbFichierCs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxNbFichierCs.Name = "cbxNbFichierCs";
            this.cbxNbFichierCs.UseVisualStyleBackColor = true;
            // 
            // cbxNbFichier
            // 
            resources.ApplyResources(this.cbxNbFichier, "cbxNbFichier");
            this.cbxNbFichier.Checked = global::ExplorateurFichier.Properties.Settings.Default.NbFichier;
            this.cbxNbFichier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNbFichier.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ExplorateurFichier.Properties.Settings.Default, "NbFichier", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxNbFichier.Name = "cbxNbFichier";
            this.cbxNbFichier.UseVisualStyleBackColor = true;
            // 
            // analyser
            // 
            resources.ApplyResources(this.analyser, "analyser");
            this.analyser.Name = "analyser";
            this.analyser.UseVisualStyleBackColor = true;
            // 
            // btnChemin
            // 
            resources.ApplyResources(this.btnChemin, "btnChemin");
            this.btnChemin.Name = "btnChemin";
            this.btnChemin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ExplorateurFichier.Properties.Settings.Default, "Chemin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Name = "textBox1";
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1"),
            resources.GetString("listBox1.Items2")});
            this.listBox1.Name = "listBox1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Name = "panel1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnChemin);
            this.Controls.Add(this.analyser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFichierNomLong);
            this.Controls.Add(this.lblFichierNom);
            this.Controls.Add(this.lblFichierCs);
            this.Controls.Add(this.lblFichier);
            this.Controls.Add(this.lbltitre);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::ExplorateurFichier.Properties.Settings.Default, "PositionFenetre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::ExplorateurFichier.Properties.Settings.Default.PositionFenetre;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.Label lblFichier;
        private System.Windows.Forms.Label lblFichierCs;
        private System.Windows.Forms.Label lblFichierNom;
        private System.Windows.Forms.Label lblFichierNomLong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxListeFichier;
        private System.Windows.Forms.CheckBox cbxNomFichierLong;
        private System.Windows.Forms.CheckBox cbxNbFichierCs;
        private System.Windows.Forms.CheckBox cbxNbFichier;
        private System.Windows.Forms.Button analyser;
        private System.Windows.Forms.Button btnChemin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}

