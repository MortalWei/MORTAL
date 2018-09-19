using DevExpress.XtraEditors;
using Lenovo.Repository;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.XtraEditors
{
    [ToolboxItem(true)]
    public class LenovoTextEdit : TextEdit
    {
        public override string EditorTypeName { get { return LenovoRepositoryItemTextEdit.EditorName; } }

        public LenovoTextEdit()
        {
            //Properties.NullValuePromptShowForEmptyValue = true;
            //Properties.NullValuePrompt = "请输入";
            //Properties.Appearance.Font = Font;
            //Properties.Appearance.Options.UseFont = true;
            //Properties.AppearanceReadOnly.BackColor = Color.FromArgb(246, 246, 246);
            //Properties.AppearanceReadOnly.BackColor2 = Color.FromArgb(246, 246, 246);
            //Properties.AppearanceReadOnly.ForeColor = Color.FromArgb(22, 23, 35);
            //Properties.AppearanceReadOnly.Options.UseBackColor = true;
            //Properties.AppearanceReadOnly.Options.UseForeColor = true;
        }

        static LenovoTextEdit()
        {
            LenovoRepositoryItemTextEdit.RegisterLenovoTextEdit();
        }

        private Font m_Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font
        {
            get
            {
                return m_Font;
            }

            set
            {
                m_Font = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new LenovoRepositoryItemTextEdit Properties { get { return base.Properties as LenovoRepositoryItemTextEdit; } }
    }
}
