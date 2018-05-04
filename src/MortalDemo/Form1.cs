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
    public partial class Form1 : Form, IFrameProgress
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
            MortalCall.Waiting(this, this);
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

        public void LoadProgressHandle(ProgressBar progressBar)
        {
            progressBar.Minimum = 1;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Value = 1;
            for (int i = 0; i < 100; i++)
            {
                progressBar.PerformStep();
                //var ss = progressBar.Value;
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
