using MortalControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalDemo
{
    public partial class Form1 : Form, IProgressFrame
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWaitTest_Click(object sender, EventArgs e)
        {
            //List<Action> _List = new List<Action>();
            //for (int i = 0; i < 100; i++)
            //{
            //    _List.Add(Run1);
            //}
            //MortalCall.Waiting(_List.ToArray());
            MortalCall.Waiting(this, 100);
            //MortalCall.Waiting(150);
        }

        //BackgroundWorker m_Worker = new BackgroundWorker();

        private void Run1()
        {
            Helpers.WriteTxtHelper.DebuggerLog(Guid.NewGuid().ToString());
            //System.Threading.Thread.Sleep(10);
        }

        private void Run2()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //m_Worker.DoWork += Worker_DoWork;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
            //    if (m_Worker.IsBusy) return;
            //    if (!IsDisposed)
            //        lblMsg.Text = DateTime.Now.ToLongTimeString();
            //}
            //catch (Exception ex)
            //{
            //    m_Worker.CancelAsync();
            //}
        }

        public void LoadProgressHandle(IProgressCall callBack)
        {
            for (int i = 1; i < 101; i++)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("正在执行第[").Append(i).Append("]个处理...");
                callBack.PerformStep(builder.ToString());
                System.Threading.Thread.Sleep(50);
            }
        }

        public void LoadProgressHandle(ProgressBar progressBar)
        {
        }
    }
}
