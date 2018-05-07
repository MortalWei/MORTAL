using System.Windows.Forms;

namespace MortalControl.BaseClass
{
    /// <summary>
    /// 无边框纯框体
    /// a.禁用ALT|F4关闭
    /// b.默认打开位置CenterScreen
    /// c.显示所有窗体之前
    /// </summary>
    public class NoneForm : Form
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public NoneForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
        }
    }
}