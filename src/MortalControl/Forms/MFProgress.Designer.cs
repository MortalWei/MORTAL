using MortalControl.Controls;

namespace MortalControl
{
    partial class MFProgress
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.prgMain = new MortalControl.Controls.MortalProgressBar();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 11.5F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMsg.Location = new System.Drawing.Point(3, 26);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(3);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(294, 16);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "请稍候...";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.prgMain.BackColor = System.Drawing.Color.SkyBlue;
            this.prgMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgMain.ForeColor = System.Drawing.Color.DodgerBlue;
            this.prgMain.Location = new System.Drawing.Point(3, 3);
            this.prgMain.Name = "progressBar1";
            this.prgMain.Size = new System.Drawing.Size(294, 23);
            this.prgMain.TabIndex = 2;
            this.prgMain.TitleColor = System.Drawing.Color.White;
            this.prgMain.TitleFont = new System.Drawing.Font("宋体", 11.5F);
            // 
            // MFProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 45);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.prgMain);
            this.Name = "MFProgress";
            this.Text = "MortalWait";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMsg;
        private MortalProgressBar prgMain;
    }
}