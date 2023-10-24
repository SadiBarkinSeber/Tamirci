namespace Tamirci.Forms
{
    partial class GecmisIslemler
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
            this.lbVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbVeriler
            // 
            this.lbVeriler.FormattingEnabled = true;
            this.lbVeriler.Location = new System.Drawing.Point(12, 12);
            this.lbVeriler.Name = "lbVeriler";
            this.lbVeriler.Size = new System.Drawing.Size(688, 472);
            this.lbVeriler.TabIndex = 0;
            // 
            // GecmisIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 500);
            this.Controls.Add(this.lbVeriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GecmisIslemler";
            this.Text = "GecmisIslemler";
            this.Load += new System.EventHandler(this.GecmisIslemler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbVeriler;
    }
}