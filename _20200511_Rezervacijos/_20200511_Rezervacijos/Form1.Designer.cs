namespace _20200511_Rezervacijos
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
            this.RezervuojantisVartotojas = new System.Windows.Forms.ComboBox();
            this.GalimiRezervuotiKambariai = new System.Windows.Forms.DataGridView();
            this.Pradzia = new System.Windows.Forms.DateTimePicker();
            this.Pabaiga = new System.Windows.Forms.DateTimePicker();
            this.Rezervuoti = new System.Windows.Forms.Button();
            this.RezRodymas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GalimiRezervuotiKambariai)).BeginInit();
            this.SuspendLayout();
            // 
            // RezervuojantisVartotojas
            // 
            this.RezervuojantisVartotojas.FormattingEnabled = true;
            this.RezervuojantisVartotojas.Location = new System.Drawing.Point(52, 34);
            this.RezervuojantisVartotojas.Name = "RezervuojantisVartotojas";
            this.RezervuojantisVartotojas.Size = new System.Drawing.Size(228, 32);
            this.RezervuojantisVartotojas.TabIndex = 0;
            // 
            // GalimiRezervuotiKambariai
            // 
            this.GalimiRezervuotiKambariai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GalimiRezervuotiKambariai.Location = new System.Drawing.Point(322, 34);
            this.GalimiRezervuotiKambariai.Name = "GalimiRezervuotiKambariai";
            this.GalimiRezervuotiKambariai.RowHeadersWidth = 72;
            this.GalimiRezervuotiKambariai.RowTemplate.Height = 31;
            this.GalimiRezervuotiKambariai.Size = new System.Drawing.Size(1111, 708);
            this.GalimiRezervuotiKambariai.TabIndex = 1;
            this.GalimiRezervuotiKambariai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GalimiRezervuotiKambariai_CellContentClick);
            this.GalimiRezervuotiKambariai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GalimiRezervuotiKambariai_CellContentClick);
            // 
            // Pradzia
            // 
            this.Pradzia.Location = new System.Drawing.Point(52, 152);
            this.Pradzia.Name = "Pradzia";
            this.Pradzia.Size = new System.Drawing.Size(200, 29);
            this.Pradzia.TabIndex = 2;
            this.Pradzia.ValueChanged += new System.EventHandler(this.Pradzia_ValueChanged);
            // 
            // Pabaiga
            // 
            this.Pabaiga.Location = new System.Drawing.Point(52, 218);
            this.Pabaiga.Name = "Pabaiga";
            this.Pabaiga.Size = new System.Drawing.Size(200, 29);
            this.Pabaiga.TabIndex = 3;
            this.Pabaiga.ValueChanged += new System.EventHandler(this.Pradzia_ValueChanged);
            // 
            // Rezervuoti
            // 
            this.Rezervuoti.Location = new System.Drawing.Point(52, 311);
            this.Rezervuoti.Name = "Rezervuoti";
            this.Rezervuoti.Size = new System.Drawing.Size(132, 48);
            this.Rezervuoti.TabIndex = 4;
            this.Rezervuoti.Text = "Rezervuoti";
            this.Rezervuoti.UseVisualStyleBackColor = true;
            this.Rezervuoti.Click += new System.EventHandler(this.Rezervuoti_Click);
            // 
            // RezRodymas
            // 
            this.RezRodymas.Location = new System.Drawing.Point(52, 402);
            this.RezRodymas.Name = "RezRodymas";
            this.RezRodymas.Size = new System.Drawing.Size(132, 81);
            this.RezRodymas.TabIndex = 5;
            this.RezRodymas.Text = "Rodyti visas rezervacijas";
            this.RezRodymas.UseVisualStyleBackColor = true;
            this.RezRodymas.Click += new System.EventHandler(this.RezRodymas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 792);
            this.Controls.Add(this.RezRodymas);
            this.Controls.Add(this.Rezervuoti);
            this.Controls.Add(this.Pabaiga);
            this.Controls.Add(this.Pradzia);
            this.Controls.Add(this.GalimiRezervuotiKambariai);
            this.Controls.Add(this.RezervuojantisVartotojas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GalimiRezervuotiKambariai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox RezervuojantisVartotojas;
        private System.Windows.Forms.DataGridView GalimiRezervuotiKambariai;
        private System.Windows.Forms.DateTimePicker Pradzia;
        private System.Windows.Forms.DateTimePicker Pabaiga;
        private System.Windows.Forms.Button Rezervuoti;
        private System.Windows.Forms.Button RezRodymas;
    }
}

