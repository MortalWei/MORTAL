using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lenovo.XtraPart
{
    /// <summary>
    /// 环形等待窗体
    /// </summary>
    internal partial class MFWait : NoneForm
    {
        /// <summary>
        /// 环形等待
        /// </summary>
        public MFWait()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="title"></param>
        /// <param name="method"></param>
        public void DoWait(string title, Action method)
        {
            DoWait(handle: null, title: title, method: method);
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="title"></param>
        /// <param name="method"></param>
        public void DoWait(IWin32Window handle, string title, Action method)
        {
            ((Action)(() =>
            {
                lblMsg.Text = title;
                method?.Invoke();
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog(handle);
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="title"></param>
        /// <param name="methods"></param>
        public void DoWait(string title, Action[] methods)
        {
            DoWait(handle: null, title: title, methods: methods);
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="title"></param>
        /// <param name="methods"></param>
        public void DoWait(IWin32Window handle, string title, Action[] methods)
        {
            ((Action)(() =>
            {
                NoticeThread.WaitOne();
                lblMsg.Text = title;
                foreach (var method in methods)
                {
                    if (_RunAsync)
                    {
                        method.Invoke();
                    }
                }
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="title"></param>
        /// <param name="tuples"></param>
        public void DoWait(string title, List<Tuple<string, Action>> tuples)
        {
            DoWait(handle: null, title: title, tuples: tuples);
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="title"></param>
        /// <param name="tuples"></param>
        public void DoWait(IWin32Window handle, string title, List<Tuple<string, Action>> tuples)
        {
            ((Action)(() =>
            {
                NoticeThread.WaitOne();
                var _Count = tuples.Count;
                foreach (var item in tuples)
                {
                    if (_RunAsync)
                    {
                        lblMsg.Invoke((Action)(() =>
                        {
                            lblMsg.Text = item.Item1;
                        }));
                        item.Item2?.Invoke();
                    }
                }

            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MFWait_Load(object sender, EventArgs e)
        {
            NoticeThread.Set();
        }
    }
}
