namespace Mortal.Parts
{
    partial class MFWaiting
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(80, 85);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(15, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 85);
            this.panel1.TabIndex = 1;
            // 
            // MFWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(110, 110);
            this.Controls.Add(this.panel1);
            this.Name = "MFWaiting";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.Text = "MFWaiting";
            this.Load += new System.EventHandler(this.MFWaiting_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
    }
}