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
            this.lenovoLookUpEdit1 = new Lenovo.XtraEditors.LenovoLookUpEdit();
            this.lenovoMemoEdit1 = new Lenovo.XtraEditors.LenovoMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lenovoLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenovoMemoEdit1.Properties)).BeginInit();
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
            // lenovoLookUpEdit1
            // 
            this.lenovoLookUpEdit1.Location = new System.Drawing.Point(13, 69);
            this.lenovoLookUpEdit1.Name = "lenovoLookUpEdit1";
            this.lenovoLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lenovoLookUpEdit1.Properties.NullText = "";
            this.lenovoLookUpEdit1.Properties.NullValuePrompt = "请选择";
            this.lenovoLookUpEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.lenovoLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.lenovoLookUpEdit1.TabIndex = 7;
            // 
            // lenovoMemoEdit1
            // 
            this.lenovoMemoEdit1.Location = new System.Drawing.Point(13, 95);
            this.lenovoMemoEdit1.Name = "lenovoMemoEdit1";
            this.lenovoMemoEdit1.Properties.NullValuePrompt = "请输入";
            this.lenovoMemoEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.lenovoMemoEdit1.Size = new System.Drawing.Size(100, 96);
            this.lenovoMemoEdit1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lenovoLookUpEdit1);
            this.Controls.Add(this.lenovoMemoEdit1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.lenovoLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenovoMemoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Lenovo.XtraEditors.LenovoMemoEdit lenovoMemoEdit1;
        private Lenovo.XtraEditors.LenovoLookUpEdit lenovoLookUpEdit1;
        //private Lenovo.XtraEditors.LenovoTreeListLookUpEdit lenovoTreeListLookUpEdit1;
        //private DevExpress.XtraTreeList.TreeList lenovoTreeListLookUpEdit1TreeList;
    }
}