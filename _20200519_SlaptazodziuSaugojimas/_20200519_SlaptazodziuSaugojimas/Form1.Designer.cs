namespace _20200519_SlaptazodziuSaugojimas
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
            this.VartotojoSlaptazodis = new System.Windows.Forms.TextBox();
            this.md5HashSlaptazodis = new System.Windows.Forms.TextBox();
            this.HashMd5 = new System.Windows.Forms.Button();
            this.SHA1Text = new System.Windows.Forms.TextBox();
            this.SHA1button = new System.Windows.Forms.Button();
            this.HashWithSaltText = new System.Windows.Forms.TextBox();
            this.HashWithSalt = new System.Windows.Forms.Button();
            this.SlaptazodisText = new System.Windows.Forms.TextBox();
            this.UnhashSalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VartotojoSlaptazodis
            // 
            this.VartotojoSlaptazodis.Location = new System.Drawing.Point(222, 13);
            this.VartotojoSlaptazodis.Name = "VartotojoSlaptazodis";
            this.VartotojoSlaptazodis.Size = new System.Drawing.Size(259, 29);
            this.VartotojoSlaptazodis.TabIndex = 0;
            // 
            // md5HashSlaptazodis
            // 
            this.md5HashSlaptazodis.Location = new System.Drawing.Point(34, 84);
            this.md5HashSlaptazodis.Name = "md5HashSlaptazodis";
            this.md5HashSlaptazodis.Size = new System.Drawing.Size(338, 29);
            this.md5HashSlaptazodis.TabIndex = 1;
            // 
            // HashMd5
            // 
            this.HashMd5.Location = new System.Drawing.Point(422, 67);
            this.HashMd5.Name = "HashMd5";
            this.HashMd5.Size = new System.Drawing.Size(164, 65);
            this.HashMd5.TabIndex = 2;
            this.HashMd5.Text = "MD5";
            this.HashMd5.UseVisualStyleBackColor = true;
            this.HashMd5.Click += new System.EventHandler(this.HashMd5_Click);
            // 
            // SHA1Text
            // 
            this.SHA1Text.Location = new System.Drawing.Point(34, 193);
            this.SHA1Text.Name = "SHA1Text";
            this.SHA1Text.Size = new System.Drawing.Size(338, 29);
            this.SHA1Text.TabIndex = 3;
            // 
            // SHA1button
            // 
            this.SHA1button.Location = new System.Drawing.Point(422, 169);
            this.SHA1button.Name = "SHA1button";
            this.SHA1button.Size = new System.Drawing.Size(164, 79);
            this.SHA1button.TabIndex = 4;
            this.SHA1button.Text = "SHA1";
            this.SHA1button.UseVisualStyleBackColor = true;
            this.SHA1button.Click += new System.EventHandler(this.SHA1button_Click);
            // 
            // HashWithSaltText
            // 
            this.HashWithSaltText.Location = new System.Drawing.Point(34, 317);
            this.HashWithSaltText.Name = "HashWithSaltText";
            this.HashWithSaltText.Size = new System.Drawing.Size(338, 29);
            this.HashWithSaltText.TabIndex = 5;
            // 
            // HashWithSalt
            // 
            this.HashWithSalt.Location = new System.Drawing.Point(422, 289);
            this.HashWithSalt.Name = "HashWithSalt";
            this.HashWithSalt.Size = new System.Drawing.Size(164, 73);
            this.HashWithSalt.TabIndex = 6;
            this.HashWithSalt.Text = "Hash su druska";
            this.HashWithSalt.UseVisualStyleBackColor = true;
            this.HashWithSalt.Click += new System.EventHandler(this.HashWithSalt_Click);
            // 
            // SlaptazodisText
            // 
            this.SlaptazodisText.Location = new System.Drawing.Point(34, 440);
            this.SlaptazodisText.Name = "SlaptazodisText";
            this.SlaptazodisText.Size = new System.Drawing.Size(338, 29);
            this.SlaptazodisText.TabIndex = 7;
            // 
            // UnhashSalt
            // 
            this.UnhashSalt.Location = new System.Drawing.Point(422, 425);
            this.UnhashSalt.Name = "UnhashSalt";
            this.UnhashSalt.Size = new System.Drawing.Size(164, 79);
            this.UnhashSalt.TabIndex = 8;
            this.UnhashSalt.Text = "UnhashSalt";
            this.UnhashSalt.UseVisualStyleBackColor = true;
            this.UnhashSalt.Click += new System.EventHandler(this.UnhashSalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.UnhashSalt);
            this.Controls.Add(this.SlaptazodisText);
            this.Controls.Add(this.HashWithSalt);
            this.Controls.Add(this.HashWithSaltText);
            this.Controls.Add(this.SHA1button);
            this.Controls.Add(this.SHA1Text);
            this.Controls.Add(this.HashMd5);
            this.Controls.Add(this.md5HashSlaptazodis);
            this.Controls.Add(this.VartotojoSlaptazodis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VartotojoSlaptazodis;
        private System.Windows.Forms.TextBox md5HashSlaptazodis;
        private System.Windows.Forms.Button HashMd5;
        private System.Windows.Forms.TextBox SHA1Text;
        private System.Windows.Forms.Button SHA1button;
        private System.Windows.Forms.TextBox HashWithSaltText;
        private System.Windows.Forms.Button HashWithSalt;
        private System.Windows.Forms.TextBox SlaptazodisText;
        private System.Windows.Forms.Button UnhashSalt;
    }
}

