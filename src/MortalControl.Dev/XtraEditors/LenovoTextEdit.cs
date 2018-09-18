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
        }
    }
}
