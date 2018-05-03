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
        [DisplayName("文本颜色"), Description("百分比提示信息文本颜色"), Category("百分比提示")]
        public Color TitleColor
        {
            get { return titleColor; }
            set { titleColor = value; }
        }

        private Font titleFont = DefaultFont;
        [Browsable(true)]
        [DisplayName("文本格式"), Description("百分比提示信息文本格式"), Category("百分比提示")]
        public Font TitleFont
        {
            get { return titleFont; }
            set { titleFont = value; }
        }

        public MortalProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = new Rectangle(0, 0, (int)(Width * (Value / ((double)Maximum))), Height);
            var str = (Value / (double)Maximum * 100).ToString("0") + "%";
            e.Graphics.FillRectangle(new SolidBrush(ForeColor), 0, 0, bounds.Width, bounds.Height);
            e.Graphics.DrawString(str, titleFont, new SolidBrush(titleColor), new Rectangle(0, 0, Width, Height), new StringFormat { Alignment = TitleAlignment, LineAlignment = titleLineAlignment });
        }
    }
}
