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
        }
    }
}
