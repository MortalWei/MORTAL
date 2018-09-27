using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Lenovo.XtraEditors.Tools
{
    /// <summary>
    /// RibbonControl Style Api
    /// </summary>
    public class LenovoRibbonStyleApi
    {
        /// <summary>
        /// RibbonControl Default Style
        /// </summary>
        /// <param name="control"></param>
        public static void SetBasicStyle(RibbonControl control)
        {
            if (control == null) return;
            if (control.Items.Count > 0)
                foreach (BarItem item in control.Items)
                {
                    item.ItemAppearance.Disabled.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    item.ItemAppearance.Disabled.Options.UseFont = true;
                    item.ItemAppearance.Hovered.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    item.ItemAppearance.Hovered.Options.UseFont = true;
                    item.ItemAppearance.Normal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    item.ItemAppearance.Normal.Options.UseFont = true;
                    item.ItemAppearance.Pressed.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    item.ItemAppearance.Pressed.Options.UseFont = true;
                }
        }
    }
}
