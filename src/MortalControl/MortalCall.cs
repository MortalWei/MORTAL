using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalControl
{
    /// <summary>
    /// 等待处理
    /// </summary>
    public sealed class MortalWait
    {
        public static void Waiting(int num)
        {
            using (MFProgress frmw = new MFProgress())
            {
                frmw.DoWait(num);
            }
        }

        public static void Waiting(Action[] methods)
        {
            using (MFProgress frmw = new MFProgress())
            {
                frmw.DoWait(methods);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="frameProgress"></param>
        public static void Waiting(IWin32Window handle, IProgressFrame frameProgress)
        {
            using (MFProgress wait = new MFProgress())
            {
                wait.DoWait(handle, frameProgress);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        /// <param name="total"></param>
        public static void Waiting(IProgressFrame frame, int total)
        {
            using (MFProgress wait = new MFProgress(total))
            {
                wait.DoWait(frame);
            }
        }

        /// <summary>
        /// 等待
        /// </summary>
        /// <param name="method"></param>
        /// <param name="title"></param>
        public static void Waiting(string title, Action method)
        {
            using (MFWait wait = new MFWait())
            {
                wait.DoWait(title, method);
            }
        }

        /// <summary>
        /// 等待执行
        /// </summary>
        /// <param name="title"></param>
        /// <param name="methods"></param>
        public static void Waiting(string title, Action[] methods)
        {
            using (MFWait wait = new MFWait())
            {
                wait.DoWait(title, methods);
            }
        }
    }
}
