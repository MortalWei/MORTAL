using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;

namespace Lenovo.XtraEditors.Repository
{
    [UserRepositoryItem("LenovoRepositoryItemLookUpEdit")]
    public class LenovoRepositoryItemLookUpEdit : RepositoryItemLookUpEdit
    {
        /// <summary>
        /// 控件类型名称
        /// </summary>
        public const string EditorName = "LenovoRepositoryItemLookUpEdit";

        /// <summary>
        /// 控件类型名称
        /// </summary>
        public override string EditorTypeName { get { return EditorName; } }

        private bool m_NullValuePromptShowForEmptyValue = true;
        /// <summary>
        /// 是否开启空值提示(水印文字)
        /// </summary>
        [DefaultValue(true)]
        [DXCategory("Behavior")]
        [Localizable(true)]
        public override bool NullValuePromptShowForEmptyValue
        {
            get { return m_NullValuePromptShowForEmptyValue; }
            set
            {
                m_NullValuePromptShowForEmptyValue = value;
                OnPropertiesChanged();
            }
        }

        private string m_NullValuePrompt = "请选择";
        /// <summary>
        /// 空值提示信息(水印文字)
        /// </summary>
        [DefaultValue("请选择")]
        [DXCategory("Behavior")]
        [Localizable(true)]
        public override string NullValuePrompt
        {
            get { return m_NullValuePrompt; }
            set
            {
                m_NullValuePrompt = value;
                OnPropertiesChanged();
            }
        }

        private string m_NullText = "";
        /// <summary>
        /// Gets or sets the string displayed in the edit box when the editor's DevExpress.XtraEditors.BaseEdit.EditValue is Null
        /// </summary>
        public override string NullText
        {
            get { return m_NullText; }

            set
            {
                m_NullText = value;
                OnPropertiesChanged();
            }
        }

        /// <summary>
        /// 默认构造
        /// </summary>
        public LenovoRepositoryItemLookUpEdit()
        {
            SetDefaultAppearance();
        }

        /// <summary>
        /// 静态构造:用于控件注册
        /// </summary>
        static LenovoRepositoryItemLookUpEdit()
        {
            RegisterEditor();
        }

        /// <summary>
        /// 注册控件
        /// </summary>
        public static void RegisterEditor()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
              typeof(LenovoLookUpEdit), typeof(LenovoRepositoryItemLookUpEdit),
              typeof(LookUpEditViewInfo), new ButtonEditPainter(), true, EditImageIndexes.LookUpEdit, typeof(DevExpress.Accessibility.ComboBoxEditAccessible)));
        }

        private void SetDefaultAppearance()
        {
            Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Appearance.Options.UseFont = true;
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;

            AppearanceDisabled.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceDisabled.Options.UseFont = true;
            AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            AppearanceDisabled.Options.UseBackColor = true;
            AppearanceDisabled.Options.UseForeColor = true;

            AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceReadOnly.Options.UseFont = true;
            AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            AppearanceReadOnly.Options.UseBackColor = true;
            AppearanceReadOnly.Options.UseForeColor = true;

            AppearanceDropDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceDropDown.Options.UseFont = true;
            AppearanceDropDown.BackColor = System.Drawing.Color.White;
            AppearanceDropDown.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            AppearanceDropDown.Options.UseBackColor = true;
            AppearanceDropDown.Options.UseForeColor = true;

            AppearanceDropDownHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceDropDownHeader.Options.UseFont = true;
            AppearanceDropDownHeader.BackColor = System.Drawing.Color.White;
            AppearanceDropDownHeader.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            AppearanceDropDownHeader.Options.UseBackColor = true;
            AppearanceDropDownHeader.Options.UseForeColor = true;

            AppearanceDropDownHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceDropDownHeader.Options.UseFont = true;
            AppearanceDropDownHeader.BackColor = System.Drawing.Color.White;
            AppearanceDropDownHeader.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            AppearanceDropDownHeader.Options.UseBackColor = true;
            AppearanceDropDownHeader.Options.UseForeColor = true;
        }
        
        /// <summary>
        /// 将源项目复制到当前项
        /// </summary>
        /// <param name="item"></param>
        public override void Assign(RepositoryItem item)
        {
            LenovoRepositoryItemLookUpEdit source = item as LenovoRepositoryItemLookUpEdit;
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
