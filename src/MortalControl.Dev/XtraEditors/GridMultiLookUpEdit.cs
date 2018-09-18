using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;

namespace MortalLib.Dev.UserControls
{
    /// <summary>
    /// 多选下拉控件
    /// </summary>
    [DXToolboxItem(true)]
    [ToolboxItem(true)]
    public partial class GridMultiLookUpEdit : GridLookUpEdit
    {
        /// <summary>
        /// 控件类型名称
        /// </summary>
        public override string EditorTypeName { get { return RepositoryItemGridMultiLookUpEdit.MultiEntiorName; } }

        /// <summary>
        /// 编辑器
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemGridMultiLookUpEdit Properties { get { return base.Properties as RepositoryItemGridMultiLookUpEdit; } }

        /// <summary>
        /// 控件大小改变后同步改变编辑器大小
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Properties.SetPopupFormSize(Size);
        }

        /// <summary>
        /// 失去焦点
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            BackColor = Color.White;
        }

        /// <summary>
        /// 获得焦点
        /// </summary>
        /// <param name="e"></param>
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            BackColor = Color.FromArgb(253, 253, 170);
        }

        static GridMultiLookUpEdit()
        {
            RepositoryItemGridMultiLookUpEdit.RegisterGridMultiLookUpEdit();
        }

        /// <summary>
        /// 默认构造
        /// </summary>
        public GridMultiLookUpEdit() : base()
        {
            Properties.View.Click += View_Click;
            Properties.View.RowClick += View_RowClick;
        }

        private void View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private static void View_Click(object sender, EventArgs e)
        {
            
        }
    }
}
