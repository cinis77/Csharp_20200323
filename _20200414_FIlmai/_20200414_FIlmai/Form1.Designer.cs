namespace _20200414_FIlmai
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
            this.VisiFilmai = new System.Windows.Forms.ListBox();
            this.PavadinimasText = new System.Windows.Forms.TextBox();
            this.Reitingas = new System.Windows.Forms.TextBox();
            this.AprasymasText = new System.Windows.Forms.TextBox();
            this.ReziusieriusText = new System.Windows.Forms.TextBox();
            this.TrukmeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NaujasFailas = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisiFilmai
            // 
            this.VisiFilmai.FormattingEnabled = true;
            this.VisiFilmai.ItemHeight = 24;
            this.VisiFilmai.Location = new System.Drawing.Point(21, 48);
            this.VisiFilmai.Name = "VisiFilmai";
            this.VisiFilmai.Size = new System.Drawing.Size(150, 532);
            this.VisiFilmai.TabIndex = 0;
            this.VisiFilmai.SelectedIndexChanged += new System.EventHandler(this.VisiFilmai_SelectedIndexChanged);
            // 
            // PavadinimasText
            // 
            this.PavadinimasText.Location = new System.Drawing.Point(471, 66);
            this.PavadinimasText.Name = "PavadinimasText";
            this.PavadinimasText.Size = new System.Drawing.Size(143, 29);
            this.PavadinimasText.TabIndex = 1;
            // 
            // Reitingas
            // 
            this.Reitingas.Location = new System.Drawing.Point(471, 139);
            this.Reitingas.Name = "Reitingas";
            this.Reitingas.Size = new System.Drawing.Size(143, 29);
            this.Reitingas.TabIndex = 2;
            // 
            // AprasymasText
            // 
            this.AprasymasText.Location = new System.Drawing.Point(471, 209);
            this.AprasymasText.Multiline = true;
            this.AprasymasText.Name = "AprasymasText";
            this.AprasymasText.Size = new System.Drawing.Size(284, 111);
            this.AprasymasText.TabIndex = 3;
            // 
            // ReziusieriusText
            // 
            this.ReziusieriusText.Location = new System.Drawing.Point(471, 348);
            this.ReziusieriusText.Name = "ReziusieriusText";
            this.ReziusieriusText.Size = new System.Drawing.Size(143, 29);
            this.ReziusieriusText.TabIndex = 4;
            // 
            // TrukmeText
            // 
            this.TrukmeText.Location = new System.Drawing.Point(471, 417);
            this.TrukmeText.Name = "TrukmeText";
            this.TrukmeText.Size = new System.Drawing.Size(143, 29);
            this.TrukmeText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reitingas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aprasymas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reziusierius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trukme";
            // 
            // NaujasFailas
            // 
            this.NaujasFailas.Location = new System.Drawing.Point(840, 631);
            this.NaujasFailas.Name = "NaujasFailas";
            this.NaujasFailas.Size = new System.Drawing.Size(170, 68);
            this.NaujasFailas.TabIndex = 11;
            this.NaujasFailas.Text = "Naujas";
            this.NaujasFailas.UseVisualStyleBackColor = true;
            this.NaujasFailas.Click += new System.EventHandler(this.NaujasFailas_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(21, 619);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(160, 68);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Istring";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 711);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NaujasFailas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrukmeText);
            this.Controls.Add(this.ReziusieriusText);
            this.Controls.Add(this.AprasymasText);
            this.Controls.Add(this.Reitingas);
            this.Controls.Add(this.PavadinimasText);
            this.Controls.Add(this.VisiFilmai);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Filmu informacijos valdymas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VisiFilmai;
        private System.Windows.Forms.TextBox PavadinimasText;
        private System.Windows.Forms.TextBox Reitingas;
        private System.Windows.Forms.TextBox AprasymasText;
        private System.Windows.Forms.TextBox ReziusieriusText;
        private System.Windows.Forms.TextBox TrukmeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NaujasFailas;
        private System.Windows.Forms.Button DeleteButton;
    }
}

