namespace CollectionBD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnNewAutor = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMaj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Albums par décennies";
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(13, 46);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(232, 212);
            this.lbx.TabIndex = 4;
            // 
            // btnNewAutor
            // 
            this.btnNewAutor.Location = new System.Drawing.Point(25, 289);
            this.btnNewAutor.Name = "btnNewAutor";
            this.btnNewAutor.Size = new System.Drawing.Size(232, 23);
            this.btnNewAutor.TabIndex = 6;
            this.btnNewAutor.Text = "Ajouter un auteur";
            this.btnNewAutor.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter album";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnMaj
            // 
            this.btnMaj.Location = new System.Drawing.Point(25, 347);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(232, 23);
            this.btnMaj.TabIndex = 8;
            this.btnMaj.Text = "Mettre en Majuscule";
            this.btnMaj.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30\'",
            "40\'",
            "50\'",
            "60\'",
            "70\'",
            "80\'",
            "90\'"});
            this.comboBox1.Location = new System.Drawing.Point(118, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 382);
            this.Controls.Add(this.btnMaj);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNewAutor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Collection BD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Button btnNewAutor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMaj;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

