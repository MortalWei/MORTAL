using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Lenovo.XtraEditors;

namespace Lenovo.XtraEditors.Repository
{
    [UserRepositoryItem("LenovoRepositoryItemCheckEdit")]
    public class LenovoRepositoryItemCheckEdit : RepositoryItemCheckEdit
    {
        /// <summary>
        /// 控件类型名称
        /// </summary>
        public const string EditorName = "LenovoRepositoryItemCheckEdit";

        /// <summary>
        /// 控件类型名称
        /// </summary>
        public override string EditorTypeName { get { return EditorName; } }

        /// <summary>
        /// 默认构造
        /// </summary>
        public LenovoRepositoryItemCheckEdit()
        {
            SetDefaultAppearance();
        }

        /// <summary>
        /// 静态构造:用于控件注册
        /// </summary>
        static LenovoRepositoryItemCheckEdit()
        {
            RegisterEditor();
        }

        /// <summary>
        /// 注册控件
        /// </summary>
        public static void RegisterEditor()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
              typeof(LenovoCheckEdit), typeof(LenovoRepositoryItemCheckEdit),
              typeof(CheckEditViewInfo), new CheckEditPainter(), true, EditImageIndexes.CheckEdit, typeof(DevExpress.Accessibility.CheckEditAccessible)));
        }

        private void SetDefaultAppearance()
        {
            Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Appearance.Options.UseFont = true;
            //Appearance.BackColor = System.Drawing.Color.White;
            Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            //Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;

            //AppearanceFocused.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            //AppearanceFocused.Options.UseFont = true;
            //AppearanceFocused.BackColor = System.Drawing.Color.White;
            //AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            //AppearanceFocused.Options.UseBackColor = true;
            //AppearanceFocused.Options.UseForeColor = true;

            AppearanceDisabled.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceDisabled.Options.UseFont = true;
            //AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            //AppearanceDisabled.Options.UseBackColor = true;
            AppearanceDisabled.Options.UseForeColor = true;

            AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceReadOnly.Options.UseFont = true;
            //AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            //AppearanceReadOnly.Options.UseBackColor = true;
            AppearanceReadOnly.Options.UseForeColor = true;
        }

        /// <summary>
        /// 将源项目复制到当前项
        /// </summary>
        /// <param name="item"></param>
        public override void Assign(RepositoryItem item)
        {
            LenovoRepositoryItemCheckEdit source = item as LenovoRepositoryItemCheckEdit;
            BeginUpdate();
            try
            {
                base.Assign(item);
                if (source == null) return;
            }
            finally
            {
                EndUpdate();
            }
        }
    }
}
