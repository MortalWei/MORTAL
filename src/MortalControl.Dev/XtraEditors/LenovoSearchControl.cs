using DevExpress.XtraEditors;
using Lenovo.Repository;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoSearchControl : SearchControl
    {
        public override string EditorTypeName { get { return LenovoRepositoryItemSearchControl.EditorName; } }

        /// <summary>
        /// 默认构造
        /// </summary>
        public LenovoSearchControl() 
        {
        }

        /// <summary>
        /// 静态构造:用于控件注册
        /// </summary>
        static LenovoSearchControl()
        {
            LenovoRepositoryItemSearchControl.RegisterEditor();
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
        public new LenovoRepositoryItemSearchControl Properties { get { return base.Properties as LenovoRepositoryItemSearchControl; } }
    }
}
