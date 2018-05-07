namespace MortalControl.Forms
{
    partial class MortalFormTest
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
            this.mortalCircle1 = new MortalControl.Controls.MortalCircle();
            this.SuspendLayout();
            // 
            // mortalCircle1
            // 
            this.mortalCircle1.Active = false;
            this.mortalCircle1.Color = System.Drawing.Color.SkyBlue;
            this.mortalCircle1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mortalCircle1.InnerCircleRadius = 20;
            this.mortalCircle1.Location = new System.Drawing.Point(3, 3);
            this.mortalCircle1.Name = "mortalCircle1";
            this.mortalCircle1.NumberSpoke = 13;
            this.mortalCircle1.OuterCircleRadius = 15;
            this.mortalCircle1.RotationSpeed = 100;
            this.mortalCircle1.Size = new System.Drawing.Size(75, 64);
            this.mortalCircle1.SpokeThickness = 6;
            this.mortalCircle1.TabIndex = 0;
            this.mortalCircle1.Text = "mortalCircle1";
            // 
            // MortalFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 70);
            this.Controls.Add(this.mortalCircle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MortalFormTest";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "MortalFormTest";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MortalFormTest_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MortalCircle mortalCircle1;
    }
}