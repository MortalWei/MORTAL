
namespace Lenovo.XtraEditors.IEventArgs
{
    /// <summary>
    /// GridView Column Custom Event Args Register
    /// </summary>
    public interface IGridColumnEventArgs
    {
        /// <summary>
        /// 字段名
        /// </summary>
        string FieldName { get; }

        /// <summary>
        /// 单元格值改变后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e);

        /// <summary>
        /// 单元格值改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e);

        /// <summary>
        /// 自定义单元格显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e);

        /// <summary>
        /// 自定义单元格编辑器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e);

        /// <summary>
        /// 绘制正在编辑中的单元格编辑器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e);

        /// <summary>
        /// 验证单元格失败时对应处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e);

        /// <summary>
        /// 准备显示编辑器时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e);

        /// <summary>
        /// 显示编辑器之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ShownEditor(object sender, System.EventArgs e);

        /// <summary>
        /// 关闭编辑器之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void HiddenEditor(object sender, System.EventArgs e);

        /// <summary>
        /// 鼠标点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MouseDown(object sender, System.Windows.Forms.MouseEventArgs e);

        /// <summary>
        /// 验证单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e);
    }
}
