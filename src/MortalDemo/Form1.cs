using Mortal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //for (int i = 0; i < 50; i++)
            //{
            //    if (i % 2 == 0) _List.Add(Run1);
            //    else _List.Add(Run2);
            //}
            //MortalWait.Waiting(_List.ToArray());
            MortalWait.Waiting(this, this);
            //MortalWait.Waiting(150);
        }

        //BackgroundWorker m_Worker = new BackgroundWorker();

        private void Run1()
        {
            //Helpers.WriteTxtHelper.DebuggerLog(Guid.NewGuid().ToString());
            System.Threading.Thread.Sleep(200);
        }

        [Description("奔跑吧2")]
        private void Run2()
        {
            System.Threading.Thread.Sleep(5000);
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

        private void btnCircle_Click(object sender, EventArgs e)
        {
            //MortalWait.Waiting();

            var _List = new Action[] { Run2, Run2, Run2, Run2 };

            MortalWait.Waiting("正在保存,请稍候....", _List);

            //MortalWaitCircle fm = new MortalWaitCircle();
            //fm.ShowDialog();

            //MortalControl.Forms.MortalFormTest fm = new MortalControl.Forms.MortalFormTest();
            //fm.ShowDialog();

            //Form2 fm = new Form2();
            //fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MortalWait.TestWaiting();
        }
    }
}
