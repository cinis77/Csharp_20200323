namespace _20200505_RegistracijosForma
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
            this.VartotojoVardas = new System.Windows.Forms.TextBox();
            this.SlaptazodisTekstas = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VartotojoVardas
            // 
            this.VartotojoVardas.Location = new System.Drawing.Point(425, 48);
            this.VartotojoVardas.Name = "VartotojoVardas";
            this.VartotojoVardas.Size = new System.Drawing.Size(209, 29);
            this.VartotojoVardas.TabIndex = 0;
            // 
            // SlaptazodisTekstas
            // 
            this.SlaptazodisTekstas.Location = new System.Drawing.Point(425, 115);
            this.SlaptazodisTekstas.Name = "SlaptazodisTekstas";
            this.SlaptazodisTekstas.Size = new System.Drawing.Size(209, 29);
            this.SlaptazodisTekstas.TabIndex = 1;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(425, 189);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(209, 29);
            this.EmailText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vartotojo vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slaptazodis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(632, 385);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(156, 53);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Registruotis";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.SlaptazodisTekstas);
            this.Controls.Add(this.VartotojoVardas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VartotojoVardas;
        private System.Windows.Forms.TextBox SlaptazodisTekstas;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegisterButton;
    }
}

