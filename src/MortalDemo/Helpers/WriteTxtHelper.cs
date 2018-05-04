using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace MortalDemo.Helpers
{
    public sealed class WriteTxtHelper
    {
        private WriteTxtHelper() { }

        /// <summary>
        /// 创建txt,存在则跳过
        /// </summary>
        /// <param name="FullFileName">带路径的文件名</param>
        /// <returns></returns>
        internal static bool CreatFile(string FullFileName)
        {
            if (File.Exists(FullFileName))
            {
                return true;
            }
            else
            {
                try
                {
                    FileStream fs = new FileStream(FullFileName, FileMode.CreateNew);
                    fs.Close();
                    return true;
                }
                catch (FileNotFoundException e)
                {
                    DebuggerLog(e.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// 保存错误信息
        /// </summary>
        /// <param name="msg"></param>
        public static void DebuggerLog(string msg)
        {
            var _Date = DateTime.Now;
            string lsFile = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Debugger.log";
            if (CreatFile(lsFile))
            {
                using (var sw = new StreamWriter(lsFile, true, Encoding.Default))
                {
                    sw.WriteLine("Time:" + _Date.ToLongDateString() + " " + _Date.ToLongTimeString());
                    sw.WriteLine("Debugger:" + msg + "");
                }
            }
        }
    }
}
