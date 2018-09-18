using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MortalLib.Dev.UserControls
{
    /// <summary>
    /// 多选下拉控件
    /// </summary>
    [UserRepositoryItem("RepositoryItemGridMultiLookUpEdit")]
    public class RepositoryItemGridMultiLookUpEdit : RepositoryItemGridLookUpEdit, ICloneable
    {
        /// <summary>
        /// 控件类型名称
        /// </summary>
        public const string MultiEntiorName = "RepositoryItemGridMultiLookUpEdit";

        /// <summary>
        /// 控件类型名称
        /// </summary>
        public override string EditorTypeName { get { return MultiEntiorName; } }

        /// <summary>
        /// 是否允许设置空值
        /// </summary>
        public bool IsAllowNullSet = true;

        /// <summary>
        /// 选中列FieldName
        /// </summary>
        [DefaultValue(typeof(string), "IsSelected"), Category("数据"), Description("Selected FieldName。")]
        public string SelectedMember { get; set; }

        static RepositoryItemGridMultiLookUpEdit()
        {
            RegisterGridMultiLookUpEdit();
        }

        /// <summary>
        /// 注册控件
        /// </summary>
        public static void RegisterGridMultiLookUpEdit()
        {
            System.Drawing.Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(MultiEntiorName,
              typeof(GridMultiLookUpEdit), typeof(RepositoryItemGridMultiLookUpEdit),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true, img));
        }

        /// <summary>
        /// 默认构造
        /// </summary>
        public RepositoryItemGridMultiLookUpEdit() : base()
        {
            NullText = string.Empty;
            SetView();
            SetViewEvent();
            ShowFooter = false;
            ShowPopupShadow = false;
        }

        /// <summary>
        /// 注册View事件
        /// </summary>
        private void SetViewEvent()
        {
            //View.RowCellClick += View_RowCellClick;
            //View.Click += View_Click;
        }

        private void View_Click(object sender, EventArgs e)
        {
            GridHitInfo info;
            GridView currentView = (sender as GridView);
            Point pt = currentView.GridControl.PointToClient(Control.MousePosition);
            info = currentView.CalcHitInfo(pt);
            if (info.Column != null && info.Column.FieldName == SelectedMember)
            {
                //if (info.InColumn)
                //{
                //    if (SelectedCount == currentView.DataRowCount)
                //        ClearSelection(currentView);
                //    else
                //        SelectAll(currentView);
                //}
                //if (info.InRowCell)
                //    InvertRowSelection(currentView, info.RowHandle);
            }
            //if (info.InRow && currentView.IsGroupRow(info.RowHandle) && info.HitTest != GridHitTest.RowGroupButton)
            //    InvertRowSelection(currentView, info.RowHandle);
        }

        private void View_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            GridHitInfo info;
            GridView currentView = (sender as GridView);
            Point pt = currentView.GridControl.PointToClient(Control.MousePosition);
            info = currentView.CalcHitInfo(pt);
            if (info.Column != null && info.Column.FieldName == SelectedMember)
            {
                //if (info.InColumn)
                //{
                //    if (SelectedCount == currentView.DataRowCount)
                //        ClearSelection(currentView);
                //    else
                //        SelectAll(currentView);
                //}
                //if (info.InRowCell)
                //    InvertRowSelection(currentView, info.RowHandle);
            }
            //if (info.InRow && currentView.IsGroupRow(info.RowHandle) && info.HitTest != GridHitTest.RowGroupButton)
            //    InvertRowSelection(currentView, info.RowHandle);
        }

        /// <summary>
        /// 设置弹出View
        /// </summary>
        private void SetView()
        {
            GridColumn _ColCheck = new GridColumn();
            _ColCheck.Name = "MutilColumn1";
            _ColCheck.FieldName = "IsSelected";
            _ColCheck.Width = 30;
            _ColCheck.Caption = string.Empty;
            _ColCheck.OptionsColumn.AllowEdit = true;
            _ColCheck.OptionsColumn.AllowMove = false;
            _ColCheck.OptionsColumn.AllowSize = false;
            _ColCheck.OptionsColumn.FixedWidth = true;

            GridColumn _ColName = new GridColumn();
            _ColName.Name = "MutilColumn2";
            _ColName.FieldName = "Name";
            _ColName.Width = 120;
            _ColName.Caption = "名称";
            _ColName.OptionsColumn.AllowEdit = false;
            _ColName.OptionsColumn.AllowMove = false;
            _ColName.OptionsColumn.AllowSize = false;
            _ColName.OptionsColumn.FixedWidth = true;

            View.Columns.Add(_ColCheck);
            View.Columns.Add(_ColName);
            View.OptionsView.ShowColumnHeaders = false;
        }

        /// <summary>
        /// 将源项目复制到当前对象
        /// </summary>
        /// <param name="item"></param>
        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemGridMultiLookUpEdit source = item as RepositoryItemGridMultiLookUpEdit;
                if (source == null) { return; }
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
