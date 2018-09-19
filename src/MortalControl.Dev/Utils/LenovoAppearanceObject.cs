using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lenovo.Utils
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class LenovoAppearanceObject : AppearanceObject
    {
        private Color m_BackColor = Color.White;
        public new Color BackColor
        {
            get { return m_BackColor; }
            set { m_BackColor = value; }
        }
        private Color m_BackColor2 = Color.White;
        public override Color BackColor2
        {
            get { return m_BackColor2; }
            set { m_BackColor2 = value; }
        }
        private Color m_ForeColor = Color.FromArgb(22, 23, 35);
        public new Color ForeColor
        {
            get { return m_ForeColor; }
            set { m_ForeColor = value; }
        }

        static LenovoAppearanceObject()
        {

        }

        public LenovoAppearanceObject() : base() { }
    }
}
