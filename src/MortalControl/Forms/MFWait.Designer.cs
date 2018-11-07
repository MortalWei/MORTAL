namespace Lenovo.XtraPart
{
    partial class MFWait
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
            this.circleMain = new MortalCircle();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMsg.Location = new System.Drawing.Point(78, 3);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(219, 54);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "请稍候 ...";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // circleMain
            // 
            this.circleMain.Active = true;
            this.circleMain.Color = System.Drawing.Color.SkyBlue;
            this.circleMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.circleMain.InnerCircleRadius = 20;
            this.circleMain.Location = new System.Drawing.Point(3, 3);
            this.circleMain.Name = "circleMain";
            this.circleMain.NumberSpoke = 13;
            this.circleMain.OuterCircleRadius = 15;
            this.circleMain.RotationSpeed = 100;
            this.circleMain.Size = new System.Drawing.Size(75, 54);
            this.circleMain.SpokeThickness = 6;
            this.circleMain.TabIndex = 3;
            this.circleMain.Text = "mortalCircle1";
            // 
            // MFWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 60);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.circleMain);
            this.Name = "MFWait";
            this.Text = "MortalWaitCircle";
            this.Load += new System.EventHandler(this.MFWait_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMsg;
        private MortalCircle circleMain;
    }
}