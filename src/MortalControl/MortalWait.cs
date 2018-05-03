using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MortalControl
{
    public partial class MortalWait : Form
    {
        private const int SC_CLOSE = 0xF060;

        private const int MF_GRAYED = 0x00000001;

        private const int MF_DISABLED = 0x00000002;

        private bool _run = true;

        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, int bRevert);

        [DllImport("User32.dll")]
        public static extern bool EnableMenuItem(IntPtr hMenu, int uIDEnableItem, int uEnable);

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

        public MortalWait()
        {
            InitializeComponent();
        }

        public object DoWait(object param)
        {
            List<string> list = new List<string>();
            int count = (int)param;
            progressBar1.Maximum = count;

            //---------------------以下代码片段可以使用线程代替
            ((Action)delegate ()
            {
                System.Threading.Thread.Sleep(1000);

                for (int i = 0; i < count; ++i) //耗时操作
                {
                    if (_run)
                    {
                        string s = DateTime.Now.ToLongTimeString();
                        list.Add(s);
                        this.Invoke((Action)delegate ()
                        {
                            if (!IsDisposed)
                            {
                                progressBar1.Value = i;
                                lblMsg.Text = "正在载入字符串 \"" + s + "\"";
                            }
                        });
                        System.Threading.Thread.Sleep(50);
                    }
                    else
                    {
                        break;
                    }
                }

            }).BeginInvoke(new AsyncCallback(OnAsync), null);  //异步执行后台工作
            //------------------------

            ShowDialog(); //UI界面等待
            return list; //后台工作执行完毕 可以使用结果
        }

        private void OnAsync(IAsyncResult ar)
        {
            if (_run) //后台工作正常结束
                DialogResult = DialogResult.OK;
        }

        private void MortalWait_Load(object sender, EventArgs e)
        {
            EnableMenuItem(GetSystemMenu(Handle, 0), SC_CLOSE, MF_DISABLED | MF_GRAYED);
        }
    }
}