using Mortal.Parts;
using Mortal.Utils.WindowsUtils.APIUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortal.Skin.Shadow
{
    partial class ShadowFormSkin : NoneForm
    {
        private ShadowForm Main;
        public ShadowFormSkin(ShadowForm main)
        {
            InitializeComponent();
            SetStyles();//减少闪烁
            Main = main;//获取控件层对象
            Text = main.Text;//设置标题栏文本
            Icon = main.Icon;//设置图标
            TopMost = main.TopMost;
            FormBorderStyle = FormBorderStyle.None;//设置无边框的窗口样式
            //ShowInTaskbar = true;//显示阴影层到任务栏（win10可显示缩略图）
            Size = Main.Size;//统一大小
            Width += (Main.ShadowWidth * 2);
            Height += (Main.ShadowWidth * 2);
            Main.Owner = this;//设置控件层的拥有皮肤层
        }
        private void ShadowFormSkin_Load(object sender, EventArgs e)
        {
            DrawShadow();
        }
        #region 减少闪烁
        private void SetStyles()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer, true);
            //强制分配样式重新应用到控件上
            UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion
        #region 绘图
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParms = base.CreateParams;
                cParms.ExStyle |= 0x00080000; // WS_EX_LAYERED
                return cParms;
            }
        }

        internal void DrawShadow()
        {
            Bitmap bitmap = null;
            Graphics g = null;
            try
            {
                bitmap = new Bitmap(Width, Height);
                g = Graphics.FromImage(bitmap);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Color c = Color.FromArgb(0, 0, 0, 0);
                Pen p = new Pen(c, 3);

                for (int i = 0; i < Main.ShadowWidth; i++)
                {
                    p.Color = Color.FromArgb((255 / 10 / Main.ShadowWidth) * i, c);
                    //g.DrawRectangle(p, new Rectangle(i, i, Width - (2 * i) - 1, Height - (2 * i) - 1));
                    DrawShadowAPI.DrawRoundRectangle(g, p, new Rectangle(i, i, Width - (2 * i) - 1, Height - (2 * i) - 1), Main.ShadowWidth - i);
                }
                SetBits(bitmap);
            }
            catch { }
            finally
            {
                g?.Dispose();
                bitmap?.Dispose();
            }
        }
        public void SetBits(Bitmap bitmap)
        {
            if (!Image.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Image.IsAlphaPixelFormat(bitmap.PixelFormat))
                throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
            IntPtr oldBits = IntPtr.Zero;
            IntPtr screenDC = FormStyleAPI.GetDC(IntPtr.Zero);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr memDc = FormStyleAPI.CreateCompatibleDC(screenDC);

            try
            {
                FormStyleAPI.Point topLoc = new FormStyleAPI.Point(Left, Top);
                FormStyleAPI.Size bitMapSize = new FormStyleAPI.Size(Width, Height);
                FormStyleAPI.BLENDFUNCTION blendFunc = new FormStyleAPI.BLENDFUNCTION();
                FormStyleAPI.Point srcLoc = new FormStyleAPI.Point(0, 0);

                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                oldBits = FormStyleAPI.SelectObject(memDc, hBitmap);

                blendFunc.BlendOp = FormStyleAPI.AC_SRC_OVER;
                blendFunc.SourceConstantAlpha = Byte.Parse(((int)(Main.Opacity * 255)).ToString());
                blendFunc.AlphaFormat = FormStyleAPI.AC_SRC_ALPHA;
                blendFunc.BlendFlags = 0;

                FormStyleAPI.UpdateLayeredWindow(Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, FormStyleAPI.ULW_ALPHA);
            }
            finally
            {
                if (hBitmap != IntPtr.Zero)
                {
                    FormStyleAPI.SelectObject(memDc, oldBits);
                    FormStyleAPI.DeleteObject(hBitmap);
                }
                FormStyleAPI.ReleaseDC(IntPtr.Zero, screenDC);
                FormStyleAPI.DeleteDC(memDc);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
        }
        #endregion
    }
}
