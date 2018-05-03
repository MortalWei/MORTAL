using MortalControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWaitTest_Click(object sender, EventArgs e)
        {
            using (MortalWait frmw = new MortalWait())
            {
                List<string> list = frmw.DoWait(123) as List<string>; //弹出模式等待窗体 实时更新显示后台工作进度 后台工作结束后  等待窗体消失  UI线程继续执行...
                MessageBox.Show("加载字符串 " + list.Count + "个");
            }
            //MortalWait FM = new MortalWait();
            //FM.ShowDialog();
        }
    }
}
