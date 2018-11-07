using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lenovo.XtraPart
{
    /// <summary>
    /// 无边框纯框体
    /// a.禁用ALT|F4关闭
    /// b.默认打开位置CenterScreen
    /// c.显示所有窗体之前
    /// </summary>
    internal class NoneForm : Form
    {
        /// <summary>
        /// 后台工作正常结束
        /// </summary>
        protected bool _RunAsync = true;

        /// <summary>
        /// 等待执行
        /// </summary>
        protected AutoResetEvent NoticeThread = new AutoResetEvent(false);

        /// <summary>
        /// 禁用 Alt|F4
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        /// <summary>
        /// 默认构造
        /// </summary>
        public NoneForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            //TopMost = true;
            Padding = new Padding(3, 3, 3, 3);

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// 异步执行完成后
        /// </summary>
        /// <param name="ar"></param>
        protected void OnAsync(IAsyncResult ar)
        {
            if (_RunAsync)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.No;
        }

        /// <summary>
        /// 重绘Form边框
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(CreateGraphics(), ClientRectangle, Color.FromArgb(153, 153, 153), ButtonBorderStyle.Solid);
            base.OnPaint(e);
        }
    }
}