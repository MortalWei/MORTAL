using DevExpress.XtraLayout;

namespace Lenovo.XtraEditors.Tools
{
    /// <summary>
    /// LyoutControl Style Api
    /// </summary>
    public class LenovoLayoutStyleApi
    {
        /// <summary>
        /// Set LayoutControl Deafult Style
        /// </summary>
        /// <param name="layoutControl">Control</param>
        /// <param name="loadControls">Whether Load Child Control Style</param>
        public static void SetBasicStyle(LayoutControl layoutControl, bool loadControls = false)
        {
            if (layoutControl == null) return;
            if (layoutControl.Root == null) return;

            layoutControl.Root.AppearanceGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            layoutControl.Root.AppearanceGroup.Options.UseFont = true;
            layoutControl.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            layoutControl.Root.AppearanceGroup.Options.UseBackColor = true;

            layoutControl.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            layoutControl.Root.AppearanceItemCaption.Options.UseFont = true;
            layoutControl.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            layoutControl.Root.AppearanceGroup.Options.UseBackColor = true;

            layoutControl.Root.AppearanceTabPage.Header.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            layoutControl.Root.AppearanceTabPage.Header.Options.UseFont = true;
            layoutControl.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            layoutControl.Root.AppearanceGroup.Options.UseBackColor = true;

            layoutControl.Root.AppearanceTabPage.HeaderActive.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            layoutControl.Root.AppearanceTabPage.HeaderActive.Options.UseFont = true;
            layoutControl.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            layoutControl.Root.AppearanceGroup.Options.UseBackColor = true;

            layoutControl.Root.AppearanceTabPage.HeaderDisabled.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            layoutControl.Root.AppearanceTabPage.HeaderDisabled.Options.UseFont = true;
            layoutControl.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            layoutControl.Root.AppearanceGroup.Options.UseBackColor = true;

            layoutControl.Root.AppearanceTabPage.HeaderHotTracked.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            layoutControl.Root.AppearanceTabPage.HeaderHotTracked.Options.UseFont = true;
            layoutControl.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            layoutControl.Root.AppearanceGroup.Options.UseBackColor = true;

            layoutControl.Root.AppearanceTabPage.PageClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            layoutControl.Root.AppearanceTabPage.PageClient.Options.UseFont = true;
            layoutControl.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            layoutControl.Root.AppearanceGroup.Options.UseBackColor = true;

            if (loadControls) SetBasicControlsStyle(layoutControl);
        }

        private static void SetBasicControlsStyle(LayoutControl layoutControl)
        {
            if (layoutControl.Controls.Count == 0) return;
            foreach (System.Windows.Forms.Control control in layoutControl.Controls)
            {
                control.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }
        }
    }
}
