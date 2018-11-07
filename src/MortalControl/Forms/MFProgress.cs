using System;
using System.Windows.Forms;

namespace Lenovo.XtraPart
{
    /// <summary>
    /// 进度条等待窗体
    /// </summary>
    internal partial class MFProgress : NoneForm, IProgressCall
    {
        #region Attribute & Variable
        private string DefaultTitle = string.Empty;
        #endregion 

        #region Structure
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
        }
        #endregion

        #region Event Processing
        private void MFProgress_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(50);
            NoticeThread.Set();
        }
        #endregion

        #region Menthod
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public void DoWait(int param)
        {
            int count = param;
            prgMain.Maximum = count;

            ((Action)delegate ()
            {
                NoticeThread.WaitOne();
                for (int i = 1; i < count + 1; ++i) //耗时操作
                {
                    if (_RunAsync)
                    {
                        this.Invoke((Action)delegate ()
                        {
                            if (!IsDisposed)
                            {
                                prgMain.Value = i;
                                lblMsg.Text = "正在克隆第 \"" + (i + 1) + "\" 个[周泽生]";
                            }
                        });
                        System.Threading.Thread.Sleep(50);
                    }
                    else
                    {
                        break;
                    }
                }

            }).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog();
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="methods"></param>
        public void DoWait(Action[] methods)
        {
            DoWait(handle: null, methods: methods);
        }

        /// <summary>
        /// 等待函数执行完成
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="methods"></param>
        public void DoWait(IWin32Window handle, Action[] methods)
        {
            prgMain.Maximum = methods.Length;
            ((Action)(() =>
            {
                NoticeThread.WaitOne();//等待句柄
                int num = 1;
                foreach (var method in methods)
                {
                    //TODO:1.验证是否取消
                    //TODO:2.验证是否抛出异常
                    if (_RunAsync)
                    {
                        Invoke((Action)(() =>
                        {
                            var _Msg = method.MethodDescription();
                            lblMsg.Text = num + "/" + methods.Length + ",正在执行 " + _Msg + " 操作...";
                            prgMain.Value = num;
                        }));
                        method?.Invoke();
                        num++;
                    }
                }
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog(handle);
        }

        /// <summary>
        /// 用户控制的进度
        /// </summary>
        /// <param name="frame"></param>
        public void DoWait(IProgressFrame frame)
        {
            DoWait(handle: null, frameProgress: frame);
        }

        /// <summary>
        /// 用户控制的进度
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="frameProgress"></param>
        public void DoWait(IWin32Window handle, IProgressFrame frameProgress)
        {
            if (frameProgress == null) return;

            (new Action(() =>
            {
                NoticeThread.WaitOne();
                if (IsDisposed) return;
                Invoke((Action)delegate ()
                {
                    frameProgress.LoadProgressHandle(this);
                });
            })).BeginInvoke(new AsyncCallback(OnAsync), null);

            ShowDialog(handle);
        }
        #endregion

        #region Setting Progress
        /// <summary>
        /// 执行下一步操作
        /// </summary>
        /// <param name="title"></param>
        public void PerformStep(string title)
        {
            lblMsg.Text = string.IsNullOrEmpty(title) ? DefaultTitle : title;
            lblMsg.Refresh();
            prgMain.PerformStep();
        }

        /// <summary>
        /// 完成
        /// </summary>
        public void Finish()
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 设置进度条默认最大值
        /// </summary>
        /// <param name="title">默认标题</param>
        /// <param name="total">总进度数</param>
        public void SetTotal(string title, int total)
        {
            prgMain.Maximum = total;
            DefaultTitle = title;
        }
        #endregion 
    }
}