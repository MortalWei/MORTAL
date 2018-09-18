using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoMemoEdit : MemoEdit
    {
        public LenovoMemoEdit()
        {
            Properties.NullValuePromptShowForEmptyValue = true;
            Properties.NullValuePrompt = "请输入";
        }
    }
}
