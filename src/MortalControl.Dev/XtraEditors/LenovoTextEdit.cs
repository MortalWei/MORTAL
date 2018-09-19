using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoTextEdit : TextEdit
    {
        public LenovoTextEdit()
        {
            Properties.NullValuePromptShowForEmptyValue = true;
            Properties.NullValuePrompt = "请输入";
            Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Properties.Appearance.Options.UseFont = true;
        }
    }
}
