namespace _20200420_NuotraukuGalerija
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.NuotraukuGalerijosVaizdas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(212, 82);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Atidaryti";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // NuotraukuGalerijosVaizdas
            // 
            this.NuotraukuGalerijosVaizdas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NuotraukuGalerijosVaizdas.AutoScroll = true;
            this.NuotraukuGalerijosVaizdas.Location = new System.Drawing.Point(270, 12);
            this.NuotraukuGalerijosVaizdas.Name = "NuotraukuGalerijosVaizdas";
            this.NuotraukuGalerijosVaizdas.Size = new System.Drawing.Size(1928, 1007);
            this.NuotraukuGalerijosVaizdas.TabIndex = 1;
            this.NuotraukuGalerijosVaizdas.SizeChanged += new System.EventHandler(this.NuotraukuGalerijosVaizdas_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2210, 1031);
            this.Controls.Add(this.NuotraukuGalerijosVaizdas);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Galerija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Panel NuotraukuGalerijosVaizdas;
    }
}

