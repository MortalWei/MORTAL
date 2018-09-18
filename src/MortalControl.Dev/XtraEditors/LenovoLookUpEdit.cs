using DevExpress.XtraEditors;
using System.ComponentModel;

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
        }
    }
}
