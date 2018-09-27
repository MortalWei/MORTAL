using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.XtraEditors.Repository
{
    /// <summary>
    /// Contains settings specific to the DevExpress.XtraEditors.GridLookUpEdit control.
    /// </summary>
    public class LenovoRepositoryItemGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        /// <summary>
        /// 控件类型名称
        /// </summary>
        public const string EditorName = "LenovoRepositoryItemCheckEdit";

        /// <summary>
        /// 控件类型名称
        /// </summary>
        public override string EditorTypeName { get { return EditorName; } }

        private bool m_NullValuePromptShowForEmptyValue = true;
        /// <summary>
        /// 是否开启空值提示(水印文字)
        /// </summary>
        [DefaultValue(true), Category("LenovoBehavior")]
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
        [DefaultValue("请选择"), Category("LenovoBehavior")]
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

        private string m_FilterColumn = string.Empty;
        [DefaultValue(""), Category("LenovoBehavior"), Description("设置筛选列，根据FieldName筛选，多列用|分割，查询方式FieldName加%，如 %工号|%姓名% 未指定属性则按照所有显示列筛选。")]
        [DXCategory("Behavior")]
        [Localizable(true)]
        public virtual string FilterColumn
        {
            get { return m_FilterColumn; }
            set
            {
                m_FilterColumn = value;
                OnPropertiesChanged();
            }
        }

        private bool m_IsEscape = false;
        /// <summary>
        /// 按Escape键关闭
        /// </summary>
        [DefaultValue(false), Category("LenovoBehavior"), Description("按Escape键关闭")]
        public virtual bool IsEscape
        {
            get { return m_IsEscape; }
            set
            {
                m_IsEscape = value;
                OnPropertiesChanged();
            }
        }

        public LenovoRepositoryItemGridLookUpEdit()
        {
            SetDefaultAppearance();
        }

        static LenovoRepositoryItemGridLookUpEdit()
        {
            RegisterEditor();
        }

        /// <summary>
        /// 注册控件
        /// </summary>
        public static void RegisterEditor()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
              typeof(LenovoGridLookUpEdit), typeof(LenovoRepositoryItemGridLookUpEdit),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true, img, typeof(DevExpress.Accessibility.PopupEditAccessible)));
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
        }

        /// <summary>
        /// 将源项目复制到当前项
        /// </summary>
        /// <param name="item"></param>
        public override void Assign(RepositoryItem item)
        {
            LenovoRepositoryItemGridLookUpEdit source = item as LenovoRepositoryItemGridLookUpEdit;
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

        /// <summary>
        /// 设置控件大小
        /// </summary>
        /// <param name="size"></param>
        internal void SetPopupFormSize(System.Drawing.Size size)
        {
            PopupFormSize = new System.Drawing.Size(size.Width - 4, 60);
        }
    }
}
