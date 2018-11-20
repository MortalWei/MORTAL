namespace Lenovo.XtraEditors
{
    partial class LenovoNoneForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LenovoNoneForm));
            this.HeaderContainer = new DevExpress.XtraEditors.PanelControl();
            this.TitleNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.MinimumButton = new DevExpress.XtraEditors.SimpleButton();
            this.img16 = new DevExpress.Utils.ImageCollection(this.components);
            this.MaximumButton = new DevExpress.XtraEditors.SimpleButton();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.BottomContainer = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderContainer)).BeginInit();
            this.HeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderContainer
            // 
            this.HeaderContainer.Appearance.BackColor = System.Drawing.Color.White;
            this.HeaderContainer.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.HeaderContainer.Appearance.Options.UseBackColor = true;
            this.HeaderContainer.Appearance.Options.UseBorderColor = true;
            this.HeaderContainer.Controls.Add(this.TitleNameLabel);
            this.HeaderContainer.Controls.Add(this.MinimumButton);
            this.HeaderContainer.Controls.Add(this.MaximumButton);
            this.HeaderContainer.Controls.Add(this.CloseButton);
            this.HeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.HeaderContainer.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.HeaderContainer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.HeaderContainer.Name = "HeaderContainer";
            this.HeaderContainer.Size = new System.Drawing.Size(775, 30);
            this.HeaderContainer.TabIndex = 0;
            // 
            // TitleNameLabel
            // 
            this.TitleNameLabel.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TitleNameLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.TitleNameLabel.Appearance.Options.UseFont = true;
            this.TitleNameLabel.Appearance.Options.UseForeColor = true;
            this.TitleNameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.TitleNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleNameLabel.Location = new System.Drawing.Point(2, 2);
            this.TitleNameLabel.Name = "TitleNameLabel";
            this.TitleNameLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.TitleNameLabel.Size = new System.Drawing.Size(675, 26);
            this.TitleNameLabel.TabIndex = 1;
            this.TitleNameLabel.Text = "LenovoXtraForm";
            // 
            // MinimumButton
            // 
            this.MinimumButton.Appearance.BackColor = System.Drawing.Color.White;
            this.MinimumButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.MinimumButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.MinimumButton.Appearance.Options.UseBackColor = true;
            this.MinimumButton.Appearance.Options.UseBorderColor = true;
            this.MinimumButton.Appearance.Options.UseForeColor = true;
            this.MinimumButton.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.MinimumButton.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.MinimumButton.AppearanceDisabled.Options.UseBackColor = true;
            this.MinimumButton.AppearanceDisabled.Options.UseBorderColor = true;
            this.MinimumButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MinimumButton.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MinimumButton.AppearanceHovered.Options.UseBackColor = true;
            this.MinimumButton.AppearanceHovered.Options.UseBorderColor = true;
            this.MinimumButton.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MinimumButton.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MinimumButton.AppearancePressed.Options.UseBackColor = true;
            this.MinimumButton.AppearancePressed.Options.UseBorderColor = true;
            this.MinimumButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.MinimumButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimumButton.ImageIndex = 2;
            this.MinimumButton.ImageList = this.img16;
            this.MinimumButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.MinimumButton.Location = new System.Drawing.Point(677, 2);
            this.MinimumButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.MinimumButton.Name = "MinimumButton";
            this.MinimumButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.MinimumButton.Size = new System.Drawing.Size(32, 26);
            this.MinimumButton.TabIndex = 4;
            this.MinimumButton.Visible = false;
            this.MinimumButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimumButton_MouseClick);
            // 
            // img16
            // 
            this.img16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img16.ImageStream")));
            this.img16.Images.SetKeyName(0, "exit16.png");
            this.img16.Images.SetKeyName(1, "max16.png");
            this.img16.Images.SetKeyName(2, "min16.png");
            this.img16.Images.SetKeyName(3, "restore16.png");
            // 
            // MaximumButton
            // 
            this.MaximumButton.Appearance.BackColor = System.Drawing.Color.White;
            this.MaximumButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.MaximumButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.MaximumButton.Appearance.Options.UseBackColor = true;
            this.MaximumButton.Appearance.Options.UseBorderColor = true;
            this.MaximumButton.Appearance.Options.UseForeColor = true;
            this.MaximumButton.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.MaximumButton.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.MaximumButton.AppearanceDisabled.Options.UseBackColor = true;
            this.MaximumButton.AppearanceDisabled.Options.UseBorderColor = true;
            this.MaximumButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MaximumButton.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MaximumButton.AppearanceHovered.Options.UseBackColor = true;
            this.MaximumButton.AppearanceHovered.Options.UseBorderColor = true;
            this.MaximumButton.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MaximumButton.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MaximumButton.AppearancePressed.Options.UseBackColor = true;
            this.MaximumButton.AppearancePressed.Options.UseBorderColor = true;
            this.MaximumButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.MaximumButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximumButton.ImageIndex = 1;
            this.MaximumButton.ImageList = this.img16;
            this.MaximumButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.MaximumButton.Location = new System.Drawing.Point(709, 2);
            this.MaximumButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.MaximumButton.Name = "MaximumButton";
            this.MaximumButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.MaximumButton.Size = new System.Drawing.Size(32, 26);
            this.MaximumButton.TabIndex = 3;
            this.MaximumButton.Visible = false;
            this.MaximumButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaximumButton_MouseClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Appearance.BackColor = System.Drawing.Color.White;
            this.CloseButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Appearance.Options.UseBackColor = true;
            this.CloseButton.Appearance.Options.UseBorderColor = true;
            this.CloseButton.Appearance.Options.UseForeColor = true;
            this.CloseButton.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.CloseButton.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.CloseButton.AppearanceDisabled.Options.UseBackColor = true;
            this.CloseButton.AppearanceDisabled.Options.UseBorderColor = true;
            this.CloseButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.CloseButton.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.CloseButton.AppearanceHovered.Options.UseBackColor = true;
            this.CloseButton.AppearanceHovered.Options.UseBorderColor = true;
            this.CloseButton.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.CloseButton.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.CloseButton.AppearancePressed.Options.UseBackColor = true;
            this.CloseButton.AppearancePressed.Options.UseBorderColor = true;
            this.CloseButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.ImageIndex = 0;
            this.CloseButton.ImageList = this.img16;
            this.CloseButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.CloseButton.Location = new System.Drawing.Point(741, 2);
            this.CloseButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.CloseButton.Size = new System.Drawing.Size(32, 26);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            // 
            // BottomContainer
            // 
            this.BottomContainer.Appearance.BackColor = System.Drawing.Color.White;
            this.BottomContainer.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BottomContainer.Appearance.Options.UseBackColor = true;
            this.BottomContainer.Appearance.Options.UseBorderColor = true;
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(0, 451);
            this.BottomContainer.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.BottomContainer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(775, 30);
            this.BottomContainer.TabIndex = 1;
            // 
            // LenovoNoneForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 481);
            this.Controls.Add(this.BottomContainer);
            this.Controls.Add(this.HeaderContainer);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinName = "Office 2013";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LenovoNoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LenovoXtraForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderContainer)).EndInit();
            this.HeaderContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl HeaderContainer;
        private DevExpress.Utils.ImageCollection img16;
        private DevExpress.XtraEditors.SimpleButton CloseButton;
        private DevExpress.XtraEditors.SimpleButton MinimumButton;
        private DevExpress.XtraEditors.SimpleButton MaximumButton;
        protected DevExpress.XtraEditors.PanelControl BottomContainer;
        private DevExpress.XtraEditors.LabelControl TitleNameLabel;
    }
}