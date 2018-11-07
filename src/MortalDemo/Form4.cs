using Lenovo.XtraPart;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MortalDemo
{
    public partial class Form4 : Form
    {
        DrawAnimate _DrawAnimate;

        public Form4()
        {
            InitializeComponent();
            _DrawAnimate = new DrawAnimate(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Html\\img\\waiting.gif"));
            _DrawAnimate.OnFrameChanged += new EventHandler<EventArgs>(image_OnFrameChanged);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void image_OnFrameChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            _DrawAnimate.Play();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            lock (_DrawAnimate.Image)
            {
                e.Graphics.DrawImage(_DrawAnimate.Image, new Point(70, 25));
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(153, 153, 153), ButtonBorderStyle.Solid);
                //var _Gr = panel1.CreateGraphics();
                //_Gr.DrawImage(_DrawAnimate.Image, new Point(0, 0));
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (button1.Text.Equals("Stop"))
        //    {
        //        _DrawAnimate.Stop();
        //        button1.Text = "Play";
        //    }
        //    else
        //    {
        //        _DrawAnimate.Play();
        //        button1.Text = "Stop";
        //    }
        //    Invalidate();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    _DrawAnimate.Reset();
        //    button1.Text = "Play";
        //    Invalidate();
        //}
    }
}
