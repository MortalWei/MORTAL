using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoLookUpEdit : LookUpEdit
    {
        public LenovoLookUpEdit()
        {
            Properties.NullValuePromptShowForEmptyValue = true;
            Properties.NullValuePrompt = "请选择";
            Properties.NullText = string.Empty;
            Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Properties.Appearance.Options.UseFont = true;
        }
    }
}
