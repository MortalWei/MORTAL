namespace MortalDemo
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gridMultiLookUpEdit1 = new MortalLib.Dev.UserControls.GridMultiLookUpEdit();
            this.gridMultiLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultiLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultiLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "加载数据";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gridMultiLookUpEdit1
            // 
            this.gridMultiLookUpEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridMultiLookUpEdit1.Location = new System.Drawing.Point(0, 0);
            this.gridMultiLookUpEdit1.Name = "gridMultiLookUpEdit1";
            this.gridMultiLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridMultiLookUpEdit1.Properties.NullText = "";
            this.gridMultiLookUpEdit1.Properties.PopupFormSize = new System.Drawing.Size(280, 60);
            this.gridMultiLookUpEdit1.Properties.ShowFooter = false;
            this.gridMultiLookUpEdit1.Properties.ShowPopupShadow = false;
            this.gridMultiLookUpEdit1.Properties.View = this.gridMultiLookUpEdit1View;
            this.gridMultiLookUpEdit1.Size = new System.Drawing.Size(284, 20);
            this.gridMultiLookUpEdit1.TabIndex = 4;
            // 
            // gridMultiLookUpEdit1View
            // 
            this.gridMultiLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridMultiLookUpEdit1View.Name = "gridMultiLookUpEdit1View";
            this.gridMultiLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridMultiLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.gridMultiLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gridMultiLookUpEdit1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.gridMultiLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultiLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStart;
        private MortalLib.Dev.UserControls.GridMultiLookUpEdit gridMultiLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMultiLookUpEdit1View;
    }
}