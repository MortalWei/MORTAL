using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoSimpleButton : SimpleButton
    {
        public LenovoSimpleButton()
        {
            LookAndFeel.UseDefaultLookAndFeel = false;
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
        }

        static LenovoSimpleButton()
        {

        }

        private SimpleTheme m_StyleTheme = SimpleTheme.Default;

        private bool m_LoadTheme = false;

        private Font m_Font = new Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

        /// <summary>
        /// 定义特定的文本格式，包括字体、字号和字形属性。
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font
        {
            get { return m_Font; }

            set { m_Font = value; }
        }

        /// <summary>
        /// 设置主题
        /// </summary>
        [DefaultValue(0)]
        public SimpleTheme StyleTheme
        {
            get { return m_StyleTheme; }
            set
            {
                m_StyleTheme = value;
                OnThemeChanged();
            }
        }

        private void OnThemeChanged()
        {
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            switch (StyleTheme)
            {
                case SimpleTheme.Blue:
                    SetAppearance(Color.White, Color.Blue, Color.MediumBlue, Color.Silver);
                    break;
                case SimpleTheme.Yellow:
                    SetAppearance(Color.White, Color.Yellow, Color.Gold, Color.Silver);
                    break;
                case SimpleTheme.Red:
                    SetAppearance(Color.White, Color.Red, Color.Brown, Color.Silver);
                    break;
                case SimpleTheme.Cyan:
                    SetAppearance(Color.White, Color.Cyan, Color.PaleTurquoise, Color.Silver);
                    break;
                case SimpleTheme.Green:
                    SetAppearance(Color.White, Color.Green, Color.ForestGreen, Color.Silver);
                    break;
                case SimpleTheme.Orange:
                    SetAppearance(Color.White, Color.Orange, Color.Goldenrod, Color.Silver);
                    break;
                case SimpleTheme.Gray:
                    SetAppearance(Color.White, Color.Gray, Color.LightGray, Color.Silver);
                    break;
                default:
                    ReSetAppearance();
                    break;
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        private void ReSetAppearance()
        {
            ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            Appearance.Options.UseBackColor = false;
            Appearance.Options.UseForeColor = false;
            Appearance.Options.UseBorderColor = false;
            AppearanceDisabled.Options.UseBackColor = false;
            AppearanceDisabled.Options.UseForeColor = false;
            AppearanceDisabled.Options.UseBorderColor = false;
            AppearanceHovered.Options.UseBackColor = false;
            AppearanceHovered.Options.UseForeColor = false;
            AppearanceHovered.Options.UseBorderColor = false;
            AppearancePressed.Options.UseBackColor = false;
            AppearancePressed.Options.UseForeColor = false;
            AppearancePressed.Options.UseBorderColor = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="backColor">背景色</param>
        /// <param name="foreColor">前景色</param>
        /// <param name="hoverColor">更深的色彩</param>
        /// <param name="disableColor">禁用时的色彩</param>
        private void SetAppearance(Color backColor, Color foreColor, Color hoverColor, Color disableColor)
        {
            ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            Appearance.BackColor = backColor;
            Appearance.ForeColor = foreColor;
            Appearance.BorderColor = foreColor;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            Appearance.Options.UseBorderColor = true;

            AppearanceDisabled.BackColor = backColor;
            AppearanceDisabled.ForeColor = foreColor;
            AppearanceDisabled.BorderColor = foreColor;
            AppearanceDisabled.Options.UseBackColor = true;
            AppearanceDisabled.Options.UseForeColor = true;
            AppearanceDisabled.Options.UseBorderColor = true;

            AppearanceHovered.BackColor = hoverColor;
            AppearanceHovered.ForeColor = backColor;
            AppearanceHovered.BorderColor = hoverColor;
            AppearanceHovered.Options.UseBackColor = true;
            AppearanceHovered.Options.UseForeColor = true;
            AppearanceHovered.Options.UseBorderColor = true;

            AppearancePressed.BackColor = hoverColor;
            AppearancePressed.ForeColor = backColor;
            AppearancePressed.BorderColor = hoverColor;
            AppearancePressed.Options.UseBackColor = true;
            AppearancePressed.Options.UseForeColor = true;
            AppearancePressed.Options.UseBorderColor = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!m_LoadTheme && StyleTheme != SimpleTheme.Default)
            {
                OnThemeChanged();
                m_LoadTheme = true;
            }

            base.OnPaint(e);
        }
    }
}
