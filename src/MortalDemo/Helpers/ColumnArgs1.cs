using Lenovo.XtraEditors.IEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Windows.Forms;

namespace MortalDemo.HYGrid
{
    public class ColumnArgs1 : IGridColumnEventArgs
    {
        public string FieldName
        {
            get
            {
                return "ColumnArgs1";
            }
        }

        public void CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

        }

        public void CellValueChanging(object sender, CellValueChangedEventArgs e)
        {

        }

        public void CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {

        }

        public void CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {

        }

        public void CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {

        }

        public void HiddenEditor(object sender, EventArgs e)
        {

        }

        public void InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {

        }

        public void MouseDown(object sender, MouseEventArgs e)
        {

        }

        public void ShowingEditor(object sender, CancelEventArgs e)
        {

        }

        public void ShownEditor(object sender, EventArgs e)
        {

        }

        public void ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {

        }
    }
}
