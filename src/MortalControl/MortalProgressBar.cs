using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalControl
{
    public class MortalProgressBar : ProgressBar
    {
        private StringAlignment msgAlignment = StringAlignment.Center;
        [Browsable(true)]
        [DisplayName("水平对齐方式"), Description("百分比提示信息水平对齐方式"), Category("百分比提示"), DefaultValue(StringAlignment.Center)]
        public StringAlignment TitleAlignment
        {
            get { return msgAlignment; }
            set { msgAlignment = value; }
        }

        private StringAlignment titleLineAlignment = StringAlignment.Center;
        [Browsable(true)]
        [DisplayName("垂直对齐方式"), Description("百分比提示信息垂直对齐方式"), Category("百分比提示"), DefaultValue(StringAlignment.Center)]
        public StringAlignment TitleLineAlignment
        {
            get { return titleLineAlignment; }
            set { titleLineAlignment = value; }
        }

        private Color titleColor = Color.White;
        [Browsable(true)]
        [DisplayName("提示"), Description("百分比提示信息文本颜色"), Category("百分比提示"), DefaultValue(StringAlignment.Center)]
        public Color TitleColor
        {
            get { return titleColor; }
            set { titleColor = value; }
        }

        public MortalProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = null;
            Rectangle bounds = new Rectangle(0, 0, base.Width, base.Height);
            bounds.Width = ((int)(bounds.Width * (Value / ((double)Maximum))));
            //brush = new SolidBrush(Color.Coral);
            brush = new SolidBrush(ForeColor);
            e.Graphics.FillRectangle(Brushes.DodgerBlue, 0, 0, bounds.Width, bounds.Height);

            var str = (((double)base.Value / (double)base.Maximum) * 100).ToString("0") + "%";

            Font font = new Font("宋体", (float)11, FontStyle.Regular);
            Brush brushStr = Brushes.White;
            Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
            e.Graphics.DrawString(str, font, new SolidBrush(titleColor), rectangle, new StringFormat { Alignment = TitleAlignment, LineAlignment = titleLineAlignment });
        }
    }
}
