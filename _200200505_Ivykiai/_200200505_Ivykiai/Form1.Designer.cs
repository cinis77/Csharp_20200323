namespace _200200505_Ivykiai
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
            this.button1 = new System.Windows.Forms.Button();
            this.Xpozicija = new System.Windows.Forms.Label();
            this.Ypozicija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 120);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Xpozicija
            // 
            this.Xpozicija.AutoSize = true;
            this.Xpozicija.Location = new System.Drawing.Point(539, 24);
            this.Xpozicija.Name = "Xpozicija";
            this.Xpozicija.Size = new System.Drawing.Size(0, 25);
            this.Xpozicija.TabIndex = 1;
            // 
            // Ypozicija
            // 
            this.Ypozicija.AutoSize = true;
            this.Ypozicija.Location = new System.Drawing.Point(973, 24);
            this.Ypozicija.Name = "Ypozicija";
            this.Ypozicija.Size = new System.Drawing.Size(0, 25);
            this.Ypozicija.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 841);
            this.Controls.Add(this.Ypozicija);
            this.Controls.Add(this.Xpozicija);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Xpozicija;
        private System.Windows.Forms.Label Ypozicija;
    }
}

