
namespace Lenovo.XtraEditors.IEventArgs
{
    /// <summary>
    /// TreeList Column Custom Event Args Register
    /// </summary>
    public interface ITreeColumnEventArgs
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
        void CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e);

        /// <summary>
        /// 单元格值改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e);

        /// <summary>
        /// 自定义单元格显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e);

        /// <summary>
        /// 自定义单元格编辑器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomNodeCellEdit(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e);

        /// <summary>
        /// 绘制正在编辑中的单元格编辑器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomNodeCellEditForEditing(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e);

        /// <summary>
        /// 验证单元格失败时对应处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e);

        /// <summary>
        /// 无效节点异常显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void InvalidNodeException(object sender, DevExpress.XtraTreeList.InvalidNodeExceptionEventArgs e);

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
        void MouseClick(object sender, System.Windows.Forms.MouseEventArgs e);

        /// <summary>
        /// 单元格样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e);

        /// <summary>
        /// 验证之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Validated(object sender, System.EventArgs e);

        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e);
    }
}
