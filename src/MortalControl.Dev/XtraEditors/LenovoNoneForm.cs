using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Lenovo.XtraEditors
{
    /// <summary>
    /// 无边框Form
    /// </summary>
    public partial class LenovoNoneForm : XtraForm
    {
        #region Attribute
        /// <summary>
        /// 当前是否最大化
        /// </summary>
        [ToolboxItem(false)]
        public bool IsMaximum { get; set; }

        private string sTitleText = "LenovoNoneForm";
        /// <summary>
        /// 窗体标题文本
        /// </summary>\
        [ToolboxItem(true)]
        [DefaultValue("LenovoNoneForm"), Category("Lenovo"), Description("窗体标题文本。")]
        public string TitleText
        {
            get { return sTitleText; }
            set
            {
                sTitleText = value;
                OnChangedAppearance();
            }
        }

        private bool bShowBottom = true;
        /// <summary>
        /// 确定窗体底部工具栏是否显示
        /// </summary>
        [ToolboxItem(true)]
        [DefaultValue(true), Category("Lenovo"), Description("确定窗体底部工具栏是否显示。")]
        public bool ShowBottom
        {
            get { return bShowBottom; }
            set
            {
                bShowBottom = value;
                OnChangedAppearance();
            }
        }

        private bool bMaximizeBox = true;
        /// <summary>
        /// 获取或设置一个值，该值指示是否在窗体的标题栏中显示“最大化”按钮。
        /// </summary>
        [ToolboxItem(true)]
        [DefaultValue(true), Category("Lenovo"), Description("确定窗体标题栏的右上角是否有最大化框。")]
        public new bool MaximizeBox
        {
            get { return bMaximizeBox; }
            set
            {
                bMaximizeBox = value;
                OnChangedAppearance();
            }
        }

        private bool bMinimizeBox = true;
        /// <summary>
        /// 获取或设置一个值，该值指示是否在窗体的标题栏中显示“最小化”按钮。
        /// </summary>
        [ToolboxItem(true)]
        [DefaultValue(true), Category("Lenovo"), Description("确定窗体标题栏的右上角是否有最小化框。")]
        public new bool MinimizeBox
        {
            get { return bMinimizeBox; }
            set
            {
                bMinimizeBox = value;
                OnChangedAppearance();
            }
        }

        private bool bCloseimumBox = true;
        /// <summary>
        /// 获取或设置一个值，该值指示是否在窗体的标题栏中显示“关闭”按钮。
        /// </summary>
        [ToolboxItem(true)]
        [DefaultValue(true), Category("Lenovo"), Description("确定窗体标题栏的右上角是否有最小化框。")]
        public bool CloseimumBox
        {
            get { return bCloseimumBox; }
            set
            {
                bCloseimumBox = value;
                OnChangedAppearance();
            }
        }
        #endregion

        #region Structure
        /// <summary>
        /// 构造:默认
        /// </summary>
        public LenovoNoneForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Register
        /// <summary>
        /// 事件:重绘
        /// 绘制边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LenovoXtraForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle myRectangle = new Rectangle(0, 0, Width, Height);

            ControlPaint.DrawBorder(e.Graphics, myRectangle,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid
                );
        }

        /// <summary>
        /// 事件:鼠标点击事件
        /// 关闭界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Close();
        }

        /// <summary>
        /// 事件:鼠标点击事件
        /// 最大化界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximumButton_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = IsMaximum ? FormWindowState.Normal : FormWindowState.Maximized;
            IsMaximum = !IsMaximum;
        }

        /// <summary>
        /// 事件:鼠标点击事件
        /// 最小化界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimumButton_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Default Method
        /// <summary>
        /// 外观、窗口样式属性变更后
        /// </summary>
        private void OnChangedAppearance()
        {
            MaximumButton.Visible = MaximizeBox;
            MinimumButton.Visible = MinimizeBox;
            CloseButton.Visible = CloseimumBox;
            TitleNameLabel.Text = TitleText;
            BottomContainer.Visible = ShowBottom;
        }
        #endregion
    }
}