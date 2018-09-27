using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using Lenovo.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Lenovo.XtraEditors
{
    /// <summary>
    /// The editor that provides lookup functionality using a dropdown feature-rich data grid (DevExpress.XtraGrid.GridControl).
    /// </summary>
    [ToolboxItem(true)]
    public class LenovoGridLookUpEdit : GridLookUpEdit
    {
        public override string EditorTypeName { get { return LenovoRepositoryItemGridLookUpEdit.EditorName; } }

        public override string AutoSearchText
        {
            get
            {
                return base.AutoSearchText;
            }

            set
            {
                base.AutoSearchText = value;
            }
        }

        public LenovoGridLookUpEdit() : base()
        {

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
        private new LenovoRepositoryItemGridLookUpEdit Properties { get { return base.Properties as LenovoRepositoryItemGridLookUpEdit; } }

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
        /// 重写KeyDown
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (IsDesignMode) { return; }
            Popup += LenovoGridLookUpEdit_Popup;
            EditValueChanging += LenovoGridLookUpEdit_EditValueChanging;
            KeyUp += LenovoGridLookUpEdit_KeyUp;
            Closed += LenovoGridLookUpEdit_Closed;
        }

        private void LenovoGridLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

        }

        private void LenovoGridLookUpEdit_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void LenovoGridLookUpEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void LenovoGridLookUpEdit_Popup(object sender, EventArgs e)
        {
            if (((LenovoGridLookUpEdit)sender).IsPopupOpen)
            {
                ((LenovoGridLookUpEdit)sender).BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
                {
                    FilterLookupGridLookUpEdit();
                }));
            }
        }

        private void FilterLookupGridLookUpEdit()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
            System.Reflection.FieldInfo fi = gridView.GetType().GetField("extraFilter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            List<CriteriaOperator> _ListCriteriaOperator = new List<CriteriaOperator>();

            if (string.IsNullOrEmpty(Properties.FilterColumn))
            {
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in Properties.View.Columns)
                {
                    _ListCriteriaOperator.Add(GetBinaryOperator(column.FieldName));
                }
            }
            else
            {
                var _Filters = Properties.FilterColumn.Split('|');
                foreach (var filter in _Filters)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn column in Properties.View.Columns)
                    {
                        if (column.FieldName == filter)
                        {
                            _ListCriteriaOperator.Add(GetBinaryOperator(filter));
                        }
                    }
                }
            }
        }

        private BinaryOperator GetBinaryOperator(string filter)
        {
            return new BinaryOperator(filter, "%" + AutoSearchText + "%", BinaryOperatorType.Like);
        }
    }
}
