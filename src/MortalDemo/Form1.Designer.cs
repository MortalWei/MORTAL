namespace MortalDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWaitTest = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWaitTest
            // 
            this.btnWaitTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWaitTest.Location = new System.Drawing.Point(0, 0);
            this.btnWaitTest.Name = "btnWaitTest";
            this.btnWaitTest.Size = new System.Drawing.Size(584, 23);
            this.btnWaitTest.TabIndex = 0;
            this.btnWaitTest.Text = "进度条";
            this.btnWaitTest.UseVisualStyleBackColor = true;
            this.btnWaitTest.Click += new System.EventHandler(this.btnWaitTest_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.Location = new System.Drawing.Point(0, 349);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(584, 12);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCircle
            // 
            this.btnCircle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCircle.Location = new System.Drawing.Point(0, 23);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(584, 23);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "等待";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnWaitTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWaitTest;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCircle;
    }
}

