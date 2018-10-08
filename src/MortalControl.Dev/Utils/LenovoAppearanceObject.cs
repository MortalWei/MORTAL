using System.Drawing;
using DevExpress.Utils;

namespace Lenovo.XtraEditors.Utils
{
    public class LenovoAppearanceObject : AppearanceObject
    {
        public LenovoAppearanceObject() { }


        private Font m_Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        public override Font Font
        {
            get { return m_Font; }
            set { m_Font = value; }
        }
    }
}
