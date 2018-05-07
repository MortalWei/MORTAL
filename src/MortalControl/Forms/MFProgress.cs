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
    internal partial class MFProgress : NoneForm, IProgressCall
    {
        static AutoResetEvent mEvent = new AutoResetEvent(false);

        /// <summary>
        /// 构造
        /// </summary>
        public MFProgress()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 构造:设置进度条总步长
        /// </summary>
        /// <param name="total">进度总步长</param>
        public MFProgress(int total) : this()
        {
            prgMain.Maximum = total;
            prgMain.Step = 1;
            prgMain.BindingContextChanged += ProgressBar1_BindingContextChanged;
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

            ShowDialog(handle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        public void DoWait(IProgressFrame frame)
        {
            DoWait(handle: null, frameProgress: frame);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public void DoWait(int param)
        {
            int count = param;
            prgMain.Maximum = count;

            //---------------------以下代码片段可以使用线程代替
            ((Action)delegate ()
            {
                for (int i = 1; i < count + 1; ++i) //耗时操作
                {
                    if (_RunAsync)
                    {
                        this.Invoke((Action)delegate ()
                        {
                            if (!IsDisposed)
                            {
                                prgMain.Value = i;
                                lblMsg.Text = "正在克隆第 \"" + (i + 1) + "\" 个[郭恒涛]";
                            }
                        });
                        Thread.Sleep(50);
                    }
                    else
                    {
                        break;
                    }
                }

            }).BeginInvoke(new AsyncCallback(OnAsync), null);//异步执行后台工作
            //------------------------
            ShowDialog(); //UI界面等待
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="methods"></param>
        public void DoWait(Action[] methods)
        {
            if (methods == null) return;
            prgMain.Maximum = methods.Length;
            ((Action)(() =>
            {
                for (int i = 0; i < methods.Length; i++)
                {
                    if (_RunAsync)
                    {
                        Invoke((Action)(() =>
                        {
                            lblMsg.Text = "正在执行 " + (i + 1) + "/" + methods.Length;
                            prgMain.Value = i + 1;
                        }));
                        methods[i]?.Invoke();
                    }
                }
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }

        /// <summary>
        /// 执行回调函数
        /// </summary>
        /// <param name="args"></param>
        private void RunAction(Action args)
        {
            args.Invoke();
        }

        /// <summary>
        /// 
        /// </summary>
        public void PerformStep()
        {
            prgMain.PerformStep();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        public void PerformStep(string title)
        {
            lblMsg.Text = title;
            lblMsg.Refresh();
            prgMain.PerformStep();
        }
    }
}