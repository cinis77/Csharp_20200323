namespace _20200504_DelegataiWinFormos
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
            this.MinimizaOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MinimizaOpenButton
            // 
            this.MinimizaOpenButton.Location = new System.Drawing.Point(288, 159);
            this.MinimizaOpenButton.Name = "MinimizaOpenButton";
            this.MinimizaOpenButton.Size = new System.Drawing.Size(178, 88);
            this.MinimizaOpenButton.TabIndex = 0;
            this.MinimizaOpenButton.Text = "minimizuoti ir atidaryti";
            this.MinimizaOpenButton.UseVisualStyleBackColor = true;
            this.MinimizaOpenButton.Click += new System.EventHandler(this.MinimizaOpenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinimizaOpenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MinimizaOpenButton;
    }
}

