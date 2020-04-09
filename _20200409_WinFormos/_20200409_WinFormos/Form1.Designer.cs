namespace _20200409_WinFormos
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
            this.Mygtukas = new System.Windows.Forms.Button();
            this.uzrasasKazkoks = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VirsutinePanele = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IjungtiTekstaBox = new System.Windows.Forms.CheckBox();
            this.RodomasPB = new System.Windows.Forms.PictureBox();
            this.PavB = new System.Windows.Forms.Button();
            this.VisiTabai = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateNewTaab = new System.Windows.Forms.Button();
            this.VirsutinePanele.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RodomasPB)).BeginInit();
            this.VisiTabai.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mygtukas
            // 
            this.Mygtukas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Mygtukas.Location = new System.Drawing.Point(35, 94);
            this.Mygtukas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Mygtukas.Name = "Mygtukas";
            this.Mygtukas.Size = new System.Drawing.Size(393, 90);
            this.Mygtukas.TabIndex = 0;
            this.Mygtukas.Text = "Mygtukas1";
            this.Mygtukas.UseVisualStyleBackColor = false;
            this.Mygtukas.Click += new System.EventHandler(this.Mygtukas_Click);
            // 
            // uzrasasKazkoks
            // 
            this.uzrasasKazkoks.AutoSize = true;
            this.uzrasasKazkoks.ForeColor = System.Drawing.Color.Black;
            this.uzrasasKazkoks.Location = new System.Drawing.Point(23, 65);
            this.uzrasasKazkoks.Name = "uzrasasKazkoks";
            this.uzrasasKazkoks.Size = new System.Drawing.Size(149, 50);
            this.uzrasasKazkoks.TabIndex = 1;
            this.uzrasasKazkoks.Text = "Tekstas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(223, 58);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VirsutinePanele
            // 
            this.VirsutinePanele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.VirsutinePanele.Controls.Add(this.uzrasasKazkoks);
            this.VirsutinePanele.Controls.Add(this.textBox1);
            this.VirsutinePanele.Dock = System.Windows.Forms.DockStyle.Top;
            this.VirsutinePanele.Location = new System.Drawing.Point(0, 0);
            this.VirsutinePanele.Name = "VirsutinePanele";
            this.VirsutinePanele.Size = new System.Drawing.Size(2529, 186);
            this.VirsutinePanele.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateNewTaab);
            this.groupBox1.Controls.Add(this.PavB);
            this.groupBox1.Controls.Add(this.IjungtiTekstaBox);
            this.groupBox1.Controls.Add(this.Mygtukas);
            this.groupBox1.Location = new System.Drawing.Point(32, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 672);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mygtuko grupe";
            // 
            // IjungtiTekstaBox
            // 
            this.IjungtiTekstaBox.AutoSize = true;
            this.IjungtiTekstaBox.Location = new System.Drawing.Point(35, 207);
            this.IjungtiTekstaBox.Name = "IjungtiTekstaBox";
            this.IjungtiTekstaBox.Size = new System.Drawing.Size(267, 54);
            this.IjungtiTekstaBox.TabIndex = 1;
            this.IjungtiTekstaBox.Text = "Ijungti teksta";
            this.IjungtiTekstaBox.UseVisualStyleBackColor = true;
            this.IjungtiTekstaBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RodomasPB
            // 
            this.RodomasPB.Location = new System.Drawing.Point(30, 6);
            this.RodomasPB.Name = "RodomasPB";
            this.RodomasPB.Size = new System.Drawing.Size(1022, 707);
            this.RodomasPB.TabIndex = 5;
            this.RodomasPB.TabStop = false;
            // 
            // PavB
            // 
            this.PavB.Location = new System.Drawing.Point(61, 295);
            this.PavB.Name = "PavB";
            this.PavB.Size = new System.Drawing.Size(227, 108);
            this.PavB.TabIndex = 2;
            this.PavB.Text = "Uzkrauti";
            this.PavB.UseVisualStyleBackColor = true;
            this.PavB.Click += new System.EventHandler(this.PavB_Click);
            // 
            // VisiTabai
            // 
            this.VisiTabai.Controls.Add(this.tabPage1);
            this.VisiTabai.Controls.Add(this.tabPage2);
            this.VisiTabai.Location = new System.Drawing.Point(738, 241);
            this.VisiTabai.Name = "VisiTabai";
            this.VisiTabai.SelectedIndex = 0;
            this.VisiTabai.Size = new System.Drawing.Size(1206, 787);
            this.VisiTabai.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1198, 725);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RodomasPB);
            this.tabPage2.Location = new System.Drawing.Point(4, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1198, 725);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateNewTaab
            // 
            this.CreateNewTaab.Location = new System.Drawing.Point(61, 431);
            this.CreateNewTaab.Name = "CreateNewTaab";
            this.CreateNewTaab.Size = new System.Drawing.Size(367, 123);
            this.CreateNewTaab.TabIndex = 3;
            this.CreateNewTaab.Text = "Sukurti nauja tab";
            this.CreateNewTaab.UseVisualStyleBackColor = true;
            this.CreateNewTaab.Click += new System.EventHandler(this.CreateNewTaab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2529, 1160);
            this.Controls.Add(this.VisiTabai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VirsutinePanele);
            this.Font = new System.Drawing.Font("Avenir", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Aplikacija";
            this.VirsutinePanele.ResumeLayout(false);
            this.VirsutinePanele.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RodomasPB)).EndInit();
            this.VisiTabai.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mygtukas;
        private System.Windows.Forms.Label uzrasasKazkoks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel VirsutinePanele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox IjungtiTekstaBox;
        private System.Windows.Forms.Button PavB;
        private System.Windows.Forms.PictureBox RodomasPB;
        private System.Windows.Forms.TabControl VisiTabai;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CreateNewTaab;
    }
}

