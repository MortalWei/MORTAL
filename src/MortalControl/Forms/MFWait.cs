using MortalControl.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalControl
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
            ((Action)(() =>
            {
                lblMsg.Text = title;
                method?.Invoke();
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="title"></param>
        /// <param name="methods"></param>
        public void DoWait(string title, Action[] methods)
        {
            ((Action)(() =>
            {
                lblMsg.Text = title;
                //lblMsg.Refresh();
                for (int i = 0; i < methods.Length; i++)
                {
                    if (_RunAsync)
                    {
                        methods[i].Invoke();
                    }
                }
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }
    }
}
