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
            Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Properties.Appearance.Options.UseFont = true;
        }
    }
}
