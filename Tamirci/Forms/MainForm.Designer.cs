﻿namespace Tamirci
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fİyatListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ağrızaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fİyatListesiToolStripMenuItem,
            this.ağrızaKayıtToolStripMenuItem,
            this.geçmişToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fİyatListesiToolStripMenuItem
            // 
            this.fİyatListesiToolStripMenuItem.Name = "fİyatListesiToolStripMenuItem";
            this.fİyatListesiToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fİyatListesiToolStripMenuItem.Text = "Fİyat Listesi";
            this.fİyatListesiToolStripMenuItem.Click += new System.EventHandler(this.fİyatListesiToolStripMenuItem_Click);
            // 
            // ağrızaKayıtToolStripMenuItem
            // 
            this.ağrızaKayıtToolStripMenuItem.Name = "ağrızaKayıtToolStripMenuItem";
            this.ağrızaKayıtToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ağrızaKayıtToolStripMenuItem.Text = "Ağrıza Kayıt";
            this.ağrızaKayıtToolStripMenuItem.Click += new System.EventHandler(this.ağrızaKayıtToolStripMenuItem_Click);
            // 
            // geçmişToolStripMenuItem
            // 
            this.geçmişToolStripMenuItem.Name = "geçmişToolStripMenuItem";
            this.geçmişToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.geçmişToolStripMenuItem.Text = "Geçmiş İşlemler";
            this.geçmişToolStripMenuItem.Click += new System.EventHandler(this.geçmişToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 537);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamirci";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ağrızaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fİyatListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçmişToolStripMenuItem;
    }
}

