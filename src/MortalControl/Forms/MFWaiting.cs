using Mortal.Parts.Properties;
using Mortal.Skin.Shadow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mortal.Parts
{
    /// <summary>
    /// 动画等待窗体
    /// </summary>
    internal partial class MFWaiting : NoneForm
    {
        /// <summary>
        /// 动画工具
        /// </summary>
        DrawAnimate _DrawAnimate;

        /// <summary>
        /// 动画等待
        /// </summary>
        public MFWaiting()
        {
            InitializeComponent();
            _DrawAnimate = new DrawAnimate(Resources.waiting);
            _DrawAnimate.OnFrameChanged += new EventHandler<EventArgs>(DrawAnimate_OnFrameChanged);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void DrawAnimate_OnFrameChanged(object sender, EventArgs e)
        {
            Invalidate();
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
                NoticeThread.WaitOne();
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
                        item.Item2?.Invoke();
                    }
                }

            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }

        /// <summary>
        /// Load 加载动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MFWaiting_Load(object sender, EventArgs e)
        {
            _DrawAnimate.Play();
            NoticeThread.Set();
        }

        ///// <summary>
        ///// 重绘,实现动画效果
        ///// </summary>
        ///// <param name="e"></param>
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    lock (_DrawAnimate.Image)
        //    {
        //        e.Graphics.DrawImage(_DrawAnimate.Image, new Point(70, 25));
        //    }
        //}

        private void MFWaiting_Paint(object sender, PaintEventArgs e)
        {
            lock (_DrawAnimate.Image)
            {
                e.Graphics.DrawImage(_DrawAnimate.Image, new Point(70, 25));
            }
        }
    }
}
