namespace _20200512_ProjektasSuDuomenimis
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
            this.PaieskosTekstas = new System.Windows.Forms.TextBox();
            this.Ieskoti = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SumaVisuGaminiu = new System.Windows.Forms.Label();
            this.Pradzia = new System.Windows.Forms.DateTimePicker();
            this.Pabaiga = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaieskosTekstas
            // 
            this.PaieskosTekstas.Location = new System.Drawing.Point(31, 39);
            this.PaieskosTekstas.Name = "PaieskosTekstas";
            this.PaieskosTekstas.Size = new System.Drawing.Size(299, 29);
            this.PaieskosTekstas.TabIndex = 0;
            // 
            // Ieskoti
            // 
            this.Ieskoti.Location = new System.Drawing.Point(31, 100);
            this.Ieskoti.Name = "Ieskoti";
            this.Ieskoti.Size = new System.Drawing.Size(123, 49);
            this.Ieskoti.TabIndex = 1;
            this.Ieskoti.Text = "Ieskoti";
            this.Ieskoti.UseVisualStyleBackColor = true;
            this.Ieskoti.Click += new System.EventHandler(this.Ieskoti_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1359, 927);
            this.dataGridView1.TabIndex = 2;
            // 
            // SumaVisuGaminiu
            // 
            this.SumaVisuGaminiu.AutoSize = true;
            this.SumaVisuGaminiu.Location = new System.Drawing.Point(31, 197);
            this.SumaVisuGaminiu.Name = "SumaVisuGaminiu";
            this.SumaVisuGaminiu.Size = new System.Drawing.Size(19, 25);
            this.SumaVisuGaminiu.TabIndex = 3;
            this.SumaVisuGaminiu.Text = "-";
            // 
            // Pradzia
            // 
            this.Pradzia.Location = new System.Drawing.Point(31, 321);
            this.Pradzia.Name = "Pradzia";
            this.Pradzia.Size = new System.Drawing.Size(200, 29);
            this.Pradzia.TabIndex = 4;
            // 
            // Pabaiga
            // 
            this.Pabaiga.Location = new System.Drawing.Point(31, 398);
            this.Pabaiga.Name = "Pabaiga";
            this.Pabaiga.Size = new System.Drawing.Size(200, 29);
            this.Pabaiga.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 993);
            this.Controls.Add(this.Pabaiga);
            this.Controls.Add(this.Pradzia);
            this.Controls.Add(this.SumaVisuGaminiu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ieskoti);
            this.Controls.Add(this.PaieskosTekstas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaieskosTekstas;
        private System.Windows.Forms.Button Ieskoti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SumaVisuGaminiu;
        private System.Windows.Forms.DateTimePicker Pradzia;
        private System.Windows.Forms.DateTimePicker Pabaiga;
    }
}

