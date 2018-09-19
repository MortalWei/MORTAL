using DevExpress.XtraEditors;
using System.ComponentModel;

namespace MortalLib.Dev.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoSerachControl : SearchControl
    {
        public LenovoSerachControl()
        {
            Properties.NullValuePromptShowForEmptyValue = true;
            Properties.NullValuePrompt = "请输入搜索内容";
            Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Properties.Appearance.Options.UseFont = true;
        }
    }
}
