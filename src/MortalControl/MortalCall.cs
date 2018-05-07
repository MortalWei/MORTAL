using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalControl
{
    public sealed class MortalCall
    {
        public static void Waiting(int num)
        {
            using (MortalWait frmw = new MortalWait())
            {
                frmw.DoWait(num);
            }
        }

        public static void Waiting(Action[] methods)
        {
            using (MortalWait frmw = new MortalWait())
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
            using (MortalWait wait = new MortalWait())
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
            using (MortalWait wait = new MortalWait(total))
            {
                wait.DoWait(frame);
            }
        }
    }
}
