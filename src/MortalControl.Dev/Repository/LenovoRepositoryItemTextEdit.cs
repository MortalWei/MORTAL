using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using System.ComponentModel;
using Lenovo.Utils;
using Lenovo.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;

namespace Lenovo.Repository
{
    [UserRepositoryItem("LenovoRepositoryItemTextEdit")]
    public class LenovoRepositoryItemTextEdit : RepositoryItemTextEdit
    {
        /// <summary>
        /// 控件类型名称
        /// </summary>
        public const string EditorName = "LenovoRepositoryItemTextEdit";

        /// <summary>
        /// 控件类型名称
        /// </summary>
        public override string EditorTypeName { get { return EditorName; } }

        public LenovoRepositoryItemTextEdit()
        {
            SetDefaultFont();
        }

        static LenovoRepositoryItemTextEdit()
        {
            RegisterLenovoTextEdit();
        }

        /// <summary>
        /// 注册控件
        /// </summary>
        public static void RegisterLenovoTextEdit()
        {
            System.Drawing.Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
              typeof(LenovoTextEdit), typeof(LenovoRepositoryItemTextEdit),
              typeof(TextEditViewInfo), new TextEditPainter(), true, img));
        }

        private void SetDefaultFont()
        {
            Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Appearance.Options.UseFont = true;
            AppearanceReadOnly.BackColor = Color.FromArgb(246, 246, 246);
            AppearanceReadOnly.BackColor2 = Color.FromArgb(246, 246, 246);
            AppearanceReadOnly.ForeColor = Color.FromArgb(22, 23, 35);
            AppearanceReadOnly.Options.UseBackColor = true;
            AppearanceReadOnly.Options.UseForeColor = true;
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                LenovoRepositoryItemTextEdit source = item as LenovoRepositoryItemTextEdit;
                if (source == null) return;
            }
            finally
            {
                EndUpdate();

            }
        }
    }
}
