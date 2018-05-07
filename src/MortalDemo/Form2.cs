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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle myRectangle = new Rectangle(0, 0, this.Width, this.Height);
            //ControlPaint.DrawBorder(e.Graphics, myRectangle, Color.Blue, ButtonBorderStyle.Solid);//画个边框   

            ControlPaint.DrawBorder(e.Graphics, myRectangle,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid);
        }
    }
}
