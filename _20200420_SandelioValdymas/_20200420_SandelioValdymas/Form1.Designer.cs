namespace _20200420_SandelioValdymas
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
            this.Id = new System.Windows.Forms.TextBox();
            this.Pavadinimas = new System.Windows.Forms.TextBox();
            this.Kiekis = new System.Windows.Forms.TextBox();
            this.Lokacija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SandelioVaizdas = new System.Windows.Forms.DataGridView();
            this.Pakeisti = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.manoControlas1 = new _20200420_SandelioValdymas.ManoControlas();
            ((System.ComponentModel.ISupportInitialize)(this.SandelioVaizdas)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(182, 36);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(167, 29);
            this.Id.TabIndex = 0;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.Location = new System.Drawing.Point(182, 81);
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.Size = new System.Drawing.Size(167, 29);
            this.Pavadinimas.TabIndex = 1;
            // 
            // Kiekis
            // 
            this.Kiekis.Location = new System.Drawing.Point(182, 131);
            this.Kiekis.Name = "Kiekis";
            this.Kiekis.Size = new System.Drawing.Size(167, 29);
            this.Kiekis.TabIndex = 2;
            // 
            // Lokacija
            // 
            this.Lokacija.Location = new System.Drawing.Point(182, 182);
            this.Lokacija.Name = "Lokacija";
            this.Lokacija.Size = new System.Drawing.Size(167, 29);
            this.Lokacija.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pavadinimas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiekis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lokacija:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(40, 251);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(161, 79);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Išsaugoti";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SandelioVaizdas
            // 
            this.SandelioVaizdas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SandelioVaizdas.Location = new System.Drawing.Point(502, 36);
            this.SandelioVaizdas.Name = "SandelioVaizdas";
            this.SandelioVaizdas.RowTemplate.Height = 31;
            this.SandelioVaizdas.Size = new System.Drawing.Size(993, 763);
            this.SandelioVaizdas.TabIndex = 9;
            this.SandelioVaizdas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SandelioVaizdas_RowHeaderMouseClick);
            // 
            // Pakeisti
            // 
            this.Pakeisti.Enabled = false;
            this.Pakeisti.Location = new System.Drawing.Point(238, 251);
            this.Pakeisti.Name = "Pakeisti";
            this.Pakeisti.Size = new System.Drawing.Size(176, 79);
            this.Pakeisti.TabIndex = 5;
            this.Pakeisti.Text = "Pakeisti";
            this.Pakeisti.UseVisualStyleBackColor = true;
            this.Pakeisti.Click += new System.EventHandler(this.Pakeisti_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(40, 358);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(161, 80);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Trinti";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // manoControlas1
            // 
            this.manoControlas1.Location = new System.Drawing.Point(40, 466);
            this.manoControlas1.Name = "manoControlas1";
            this.manoControlas1.Size = new System.Drawing.Size(204, 29);
            this.manoControlas1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 903);
            this.Controls.Add(this.manoControlas1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Pakeisti);
            this.Controls.Add(this.SandelioVaizdas);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lokacija);
            this.Controls.Add(this.Kiekis);
            this.Controls.Add(this.Pavadinimas);
            this.Controls.Add(this.Id);
            this.Name = "Form1";
            this.Text = "Sandelio valdymas";
            ((System.ComponentModel.ISupportInitialize)(this.SandelioVaizdas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Pavadinimas;
        private System.Windows.Forms.TextBox Kiekis;
        private System.Windows.Forms.TextBox Lokacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView SandelioVaizdas;
        private System.Windows.Forms.Button Pakeisti;
        private System.Windows.Forms.Button DeleteButton;
        private ManoControlas manoControlas1;
    }
}

