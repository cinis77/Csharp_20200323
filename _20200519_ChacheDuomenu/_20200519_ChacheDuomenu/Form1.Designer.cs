﻿namespace _20200519_ChacheDuomenu
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
            this.InformacijosRodymas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // InformacijosRodymas
            // 
            this.InformacijosRodymas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformacijosRodymas.Location = new System.Drawing.Point(0, 0);
            this.InformacijosRodymas.Name = "InformacijosRodymas";
            this.InformacijosRodymas.Size = new System.Drawing.Size(800, 450);
            this.InformacijosRodymas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InformacijosRodymas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InformacijosRodymas;
    }
}

