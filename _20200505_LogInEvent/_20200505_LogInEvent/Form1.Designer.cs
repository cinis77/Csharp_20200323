namespace _20200505_LogInEvent
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
            this.VartotojoVardasText = new System.Windows.Forms.TextBox();
            this.SlaptazodisText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VartotojoVardasText
            // 
            this.VartotojoVardasText.Location = new System.Drawing.Point(273, 58);
            this.VartotojoVardasText.Name = "VartotojoVardasText";
            this.VartotojoVardasText.Size = new System.Drawing.Size(236, 29);
            this.VartotojoVardasText.TabIndex = 0;
            // 
            // SlaptazodisText
            // 
            this.SlaptazodisText.Location = new System.Drawing.Point(273, 143);
            this.SlaptazodisText.Name = "SlaptazodisText";
            this.SlaptazodisText.PasswordChar = '*';
            this.SlaptazodisText.Size = new System.Drawing.Size(236, 29);
            this.SlaptazodisText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SlaptazodisText);
            this.Controls.Add(this.VartotojoVardasText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VartotojoVardasText;
        private System.Windows.Forms.TextBox SlaptazodisText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

