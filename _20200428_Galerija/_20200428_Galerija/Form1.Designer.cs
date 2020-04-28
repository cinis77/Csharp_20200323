namespace _20200428_Galerija
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
            this.Galerija = new System.Windows.Forms.TabControl();
            this.PavadinimasTextBox = new System.Windows.Forms.TextBox();
            this.PletinysTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UzktautiFoto = new System.Windows.Forms.Button();
            this.IssaugotiMygtukas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Galerija
            // 
            this.Galerija.Location = new System.Drawing.Point(363, 24);
            this.Galerija.Name = "Galerija";
            this.Galerija.SelectedIndex = 0;
            this.Galerija.Size = new System.Drawing.Size(1308, 972);
            this.Galerija.TabIndex = 0;
            this.Galerija.SelectedIndexChanged += new System.EventHandler(this.Galerija_SelectedIndexChanged);
            // 
            // PavadinimasTextBox
            // 
            this.PavadinimasTextBox.Location = new System.Drawing.Point(27, 114);
            this.PavadinimasTextBox.Name = "PavadinimasTextBox";
            this.PavadinimasTextBox.Size = new System.Drawing.Size(276, 29);
            this.PavadinimasTextBox.TabIndex = 1;
            // 
            // PletinysTextBox
            // 
            this.PletinysTextBox.Location = new System.Drawing.Point(27, 200);
            this.PletinysTextBox.Name = "PletinysTextBox";
            this.PletinysTextBox.Size = new System.Drawing.Size(276, 29);
            this.PletinysTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pletinys";
            // 
            // UzktautiFoto
            // 
            this.UzktautiFoto.Location = new System.Drawing.Point(32, 269);
            this.UzktautiFoto.Name = "UzktautiFoto";
            this.UzktautiFoto.Size = new System.Drawing.Size(172, 63);
            this.UzktautiFoto.TabIndex = 5;
            this.UzktautiFoto.Text = "Uzkrauti";
            this.UzktautiFoto.UseVisualStyleBackColor = true;
            this.UzktautiFoto.Click += new System.EventHandler(this.UzktautiFoto_Click);
            // 
            // IssaugotiMygtukas
            // 
            this.IssaugotiMygtukas.Location = new System.Drawing.Point(32, 354);
            this.IssaugotiMygtukas.Name = "IssaugotiMygtukas";
            this.IssaugotiMygtukas.Size = new System.Drawing.Size(172, 71);
            this.IssaugotiMygtukas.TabIndex = 6;
            this.IssaugotiMygtukas.Text = "Issaugoti";
            this.IssaugotiMygtukas.UseVisualStyleBackColor = true;
            this.IssaugotiMygtukas.Click += new System.EventHandler(this.IssaugotiMygtukas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 1042);
            this.Controls.Add(this.IssaugotiMygtukas);
            this.Controls.Add(this.UzktautiFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PletinysTextBox);
            this.Controls.Add(this.PavadinimasTextBox);
            this.Controls.Add(this.Galerija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Galerija;
        private System.Windows.Forms.TextBox PavadinimasTextBox;
        private System.Windows.Forms.TextBox PletinysTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UzktautiFoto;
        private System.Windows.Forms.Button IssaugotiMygtukas;
    }
}

