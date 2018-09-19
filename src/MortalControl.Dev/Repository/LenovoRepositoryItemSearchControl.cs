using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Lenovo.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.Repository
{
    [UserRepositoryItem("LenovoRepositoryItemSearchControl")]
    public class LenovoRepositoryItemSearchControl : RepositoryItemSearchControl
    {
        /// <summary>
        /// 控件类型名称
        /// </summary>
        public const string EditorName = "LenovoRepositoryItemSearchControl";

        /// <summary>
        /// 控件类型名称
        /// </summary>
        public override string EditorTypeName { get { return EditorName; } }

        private bool m_NullValuePromptShowForEmptyValue = true;
        /// <summary>
        /// 是否开启空值提示(水印文字)
        /// </summary>
        //[DefaultValue(true)]
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

        private string m_NullValuePrompt = "请输入搜索内容";
        /// <summary>
        /// 空值提示信息(水印文字)
        /// </summary>
        //[DefaultValue("请输入搜索内容")]
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

        /// <summary>
        /// 默认构造
        /// </summary>
        public LenovoRepositoryItemSearchControl()
        {
            SetDefaultAppearance();
        }

        /// <summary>
        /// 静态构造:用于控件注册
        /// </summary>
        static LenovoRepositoryItemSearchControl()
        {
            RegisterEditor();
        }

        /// <summary>
        /// 注册控件
        /// </summary>
        public static void RegisterEditor()
        {
            System.Drawing.Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
              typeof(LenovoSearchControl), typeof(LenovoRepositoryItemSearchControl),
              typeof(SearchControlViewInfo), new ButtonEditPainter(), true, EditImageIndexes.MemoEdit, typeof(DevExpress.Accessibility.PopupEditAccessible)));
        }

        private void SetDefaultAppearance()
        {
            Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Appearance.Options.UseFont = true;
            Appearance.BackColor = Color.White;
            Appearance.ForeColor = Color.FromArgb(22, 23, 35);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;

            //AppearanceFocused.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            //AppearanceFocused.Options.UseFont = true;
            //AppearanceFocused.BackColor = Color.White;
            //AppearanceFocused.ForeColor = Color.FromArgb(22, 23, 35);
            //AppearanceFocused.Options.UseBackColor = true;
            //AppearanceFocused.Options.UseForeColor = true;

            AppearanceDisabled.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceDisabled.Options.UseFont = true;
            AppearanceDisabled.BackColor = Color.FromArgb(246, 246, 246);
            AppearanceDisabled.ForeColor = Color.FromArgb(22, 23, 35);
            AppearanceDisabled.Options.UseBackColor = true;
            AppearanceDisabled.Options.UseForeColor = true;

            AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            AppearanceReadOnly.Options.UseFont = true;
            AppearanceReadOnly.BackColor = Color.FromArgb(246, 246, 246);
            AppearanceReadOnly.ForeColor = Color.FromArgb(22, 23, 35);
            AppearanceReadOnly.Options.UseBackColor = true;
            AppearanceReadOnly.Options.UseForeColor = true;
        }

        /// <summary>
        /// 将源项目复制到当前项
        /// </summary>
        /// <param name="item"></param>
        public override void Assign(RepositoryItem item)
        {
            LenovoRepositoryItemSearchControl source = item as LenovoRepositoryItemSearchControl;
            BeginUpdate();
            try
            {
                base.Assign(item);
                if (source == null) return;
                //m_NullValuePrompt = source.NullValuePrompt;
                //m_NullValuePromptShowForEmptyValue = source.NullValuePromptShowForEmptyValue;
                //this.Mask.Assign(source.Mask);
            }
            finally
            {
                EndUpdate();
            }
            //Events.AddHandler(spin, source.Events[spin]);
            //Events.AddHandler(beforeShowMenu, source.Events[beforeShowMenu]);
        }
    }
}
