using MortalControl.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortalControl
{
    /// <summary>
    /// 进度条等待窗体
    /// </summary>
    public partial class MortalWait : NoneForm, IProgressCall
    {
        private bool _run = true;

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
        /// 构造
        /// </summary>
        public MortalWait()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 构造:设置进度条总步长
        /// </summary>
        /// <param name="total">进度总步长</param>
        public MortalWait(int total) : this()
        {
            progressBar1.Maximum = total;
            progressBar1.Step = 1;
            progressBar1.BindingContextChanged += ProgressBar1_BindingContextChanged;
        }

        private void ProgressBar1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 异步处理方法
        /// </summary>
        /// <param name="method"></param>
        public void DoWait(Action method)
        {
            var task1 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
            });
            var _Tasks = new Task[] { task1 };
            Task.WaitAll(_Tasks);
        }

        /// <summary>
        /// 异步处理多个方法
        /// </summary>
        /// <param name="methods"></param>
        public void DoWait(Action[] methods)
        {
            if (methods == null) return;
            progressBar1.Maximum = methods.Length;
            ((Action)delegate ()
            {
                System.Threading.Thread.Sleep(1000);
                for (int i = 0; i < methods.Length; i++)
                {
                    if (!_run) break;

                    Invoke((Action)delegate ()
                    {
                        Invoke(new Action(() =>
                        {
                            progressBar1.Value = i + 1;
                            lblMsg.Text = "正在执行第[" + (i + 1) + "]个方法...";
                            methods[i]?.Invoke();
                        }));
                    });
                }
            }).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }

        /// <summary>
        /// 由用户控制的进度显示
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="frameProgress"></param>
        public void DoWait(IWin32Window handle, IProgressFrame frameProgress)
        {
            if (frameProgress == null) return;

            (new Action(() =>
            {
                System.Threading.Thread.Sleep(1000);

                if (IsDisposed) return;
                Invoke((Action)delegate ()
                {
                    frameProgress.LoadProgressHandle(this);
                });
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            if (handle == null)
            {
                ShowDialog();
            }
            else
            {
                ShowDialog(handle);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        public void DoWait(IProgressFrame frame)
        {
            DoWait(handle: null, frameProgress: frame);
        }

        public void DoWait(object param)
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
                                lblMsg.Text = "正在克隆第 \"" + (i + 1) + "\" 个[郭恒涛]";
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
            //return list; //后台工作执行完毕 可以使用结果
        }

        private void OnAsync(IAsyncResult ar)
        {
            if (_run) //后台工作正常结束
                DialogResult = DialogResult.OK;
        }

        private void MortalWait_Load(object sender, EventArgs e)
        {
            //EnableMenuItem(GetSystemMenu(Handle, 0), SC_CLOSE, MF_DISABLED | MF_GRAYED);
        }

        public void PerformStep()
        {

        }

        public void PerformStep(string title)
        {
            //lblMsg.Invoke(new EventHandler(delegate
            //{
            lblMsg.Text = title;
            lblMsg.Refresh();
            //}));

            progressBar1.PerformStep();
        }
    }
}