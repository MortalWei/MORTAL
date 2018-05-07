using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalControl.Forms
{
    public partial class MortalFormTest : Form
    {
        public MortalFormTest()
        {
            InitializeComponent();
        }

        private void MortalFormTest_Paint(object sender, PaintEventArgs e)
        {
            Rectangle myRectangle = new Rectangle(0, 0, this.Width, this.Height);
            ControlPaint.DrawBorder(e.Graphics, myRectangle,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid
            );
        }
    }
}
