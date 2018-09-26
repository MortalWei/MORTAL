﻿using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    [Description("Allows an associated option to be checked and unchecked.")]
    public class LenovoCheckEdit : CheckEdit
    {
        public LenovoCheckEdit()
        {
            Properties.Appearance.Font = Font;
            Properties.Appearance.Options.UseFont = true;
            Properties.AppearanceReadOnly.BackColor = Color.FromArgb(246, 246, 246);
            Properties.AppearanceReadOnly.BackColor2 = Color.FromArgb(246, 246, 246);
            Properties.AppearanceReadOnly.ForeColor = Color.FromArgb(22, 23, 35);
            Properties.AppearanceReadOnly.Options.UseBackColor = true;
            Properties.AppearanceReadOnly.Options.UseForeColor = true;
        }

        private Font m_Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font
        {
            get
            {
                return m_Font;
            }

            set
            {
                m_Font = value;
            }
        }
    }
}
