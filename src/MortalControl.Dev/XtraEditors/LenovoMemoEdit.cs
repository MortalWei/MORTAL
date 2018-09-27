using DevExpress.XtraEditors;
using Lenovo.XtraEditors.Repository;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoMemoEdit : MemoEdit
    {
        public override string EditorTypeName { get { return LenovoRepositoryItemMemoEdit.EditorName; } }

        /// <summary>
        /// 默认构造
        /// </summary>
        public LenovoMemoEdit() : base()
        {
        }

        /// <summary>
        /// 静态构造:用于控件注册
        /// </summary>
        static LenovoMemoEdit()
        {
            LenovoRepositoryItemMemoEdit.RegisterEditor();
        }

        private Font m_Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        /// <summary>
        /// 定义特定的文本格式，包括字体、字号和字形属性。
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font
        {
            get { return m_Font; }

            set { m_Font = value; }
        }

        /// <summary>
        /// 编辑器设置
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new LenovoRepositoryItemMemoEdit Properties { get { return base.Properties as LenovoRepositoryItemMemoEdit; } }
    }
}
