using Mortal.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mortal
{
    /// <summary>
    /// 等待处理
    /// </summary>
    public sealed class MortalWait
    {
        /// <summary>
        /// 进度条窗体测试
        /// </summary>
        /// <param name="num"></param>
        public static void Waiting(int num)
        {
            if (num == 0) return;
            using (MFProgress frmw = new MFProgress())
            {
                frmw.DoWait(num);
            }
        }

        /// <summary>
        /// 进度条等待方法执行完成
        /// 同步执行
        /// </summary>
        /// <param name="methods"></param>
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
            List<Tuple<string, Action>> _list = new List<Tuple<string, Action>>();
        }
    }
}
