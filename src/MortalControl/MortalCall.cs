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
                //List<string> list = frmw.DoWait(123) as List<string>; //弹出模式等待窗体 实时更新显示后台工作进度 后台工作结束后  等待窗体消失  UI线程继续执行...
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

        public static void Waiting(IWin32Window handle, IFrameProgress frameProgress)
        {
            using (MortalWait wait = new MortalWait())
            {
                wait.DoWait(handle, frameProgress);
            }
        }
    }
}
