using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Lenovo.XtraEditors
{
    /// <summary>
    /// 下拉菜单
    /// </summary>
    [ToolboxItem(true)]
    public class LenovoTreeListLookUpEdit : TreeListLookUpEdit
    {
        public LenovoTreeListLookUpEdit()
        {
            Properties.NullValuePromptShowForEmptyValue = true;
            Properties.NullValuePrompt = "请选择";
            Properties.NullText = string.Empty;
        }
    }
}
