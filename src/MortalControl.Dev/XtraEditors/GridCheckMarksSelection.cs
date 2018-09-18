using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortalLib.Dev.UserControls
{
    public class GridCheckMarksSelection
    {
        #region Fileds
        RepositoryItemGridLookUpEdit _currentRepository;

        protected ArrayList selection;
        protected String checkColumnFieldName = "CheckMarkSelection";
        RepositoryItemCheckEdit edit;
        const Int32 CheckboxIndent = 4;
        #endregion

        #region Construct
        public GridCheckMarksSelection(RepositoryItemGridLookUpEdit repository)
            : this()
        {
            CurrentRepository = repository;
        }

        public RepositoryItemGridLookUpEdit CurrentRepository
        {
            get { return _currentRepository; }
            set
            {
                if (_currentRepository != value)
                {
                    Detach();
                    Attach(value);
                }
            }
        }

        public GridCheckMarksSelection()
        {
            selection = new ArrayList();
            this.OnSelectionChanged();
        }
        #endregion

        #region Attribute
        public ArrayList Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        public Int32 SelectedCount { get { return selection.Count; } }
        #endregion

        #region GridSelect
        public object GetSelectedRow(Int32 index)
        { return selection[index]; }

        public Int32 GetSelectedIndex(object row)
        { return selection.IndexOf(row); }

        public void ClearSelection(GridView currentView)
        {
            selection.Clear();
            Invalidate(currentView);
            OnSelectionChanged();
        }

        public void SelectAll(object sourceObject)
        {
            selection.Clear();
            if (sourceObject != null)
            {
                if (sourceObject is ICollection)
                    selection.AddRange(((ICollection)sourceObject));
                else
                {
                    GridView currentView = sourceObject as GridView;
                    for (Int32 i = 0; i < currentView.DataRowCount; i++)
                        selection.Add(currentView.GetRow(i));
                    Invalidate(currentView);
                }
            }
            this.OnSelectionChanged();
        }

        public delegate void SelectionChangedEventHandler(object sender, EventArgs e);
        public event SelectionChangedEventHandler SelectionChanged;
        public void OnSelectionChanged()
        {
            if (SelectionChanged != null)
            {
                EventArgs e = new EventArgs();
                SelectionChanged(this, e);
            }
        }
        public void SelectGroup(GridView currentView, Int32 rowHandle, bool select)
        {
            if (IsGroupRowSelected(currentView, rowHandle) && select) return;
            for (Int32 i = 0; i < currentView.GetChildRowCount(rowHandle); i++)
            {
                Int32 childRowHandle = currentView.GetChildRowHandle(rowHandle, i);
                if (currentView.IsGroupRow(childRowHandle))
                    SelectGroup(currentView, childRowHandle, select);
                else
                    SelectRow(currentView, childRowHandle, select, false);
            }
            Invalidate(currentView);
        }

        public void SelectRow(GridView currentView, Int32 rowHandle, bool select)
        {
            SelectRow(currentView, rowHandle, select, true);
        }

        public void InvertRowSelection(GridView currentView, Int32 rowHandle)
        {
            if (currentView.IsDataRow(rowHandle))
                SelectRow(currentView, rowHandle, !IsRowSelected(currentView, rowHandle));
            if (currentView.IsGroupRow(rowHandle))
                SelectGroup(currentView, rowHandle, !IsGroupRowSelected(currentView, rowHandle));
        }

        public bool IsGroupRowSelected(GridView currentView, Int32 rowHandle)
        {
            for (Int32 i = 0; i < currentView.GetChildRowCount(rowHandle); i++)
            {
                Int32 row = currentView.GetChildRowHandle(rowHandle, i);
                if (currentView.IsGroupRow(row))
                {
                    if (!IsGroupRowSelected(currentView, row)) return false;
                }
                else
                    if (!IsRowSelected(currentView, row)) return false;
            }
            return true;
        }

        public bool IsRowSelected(GridView currentView, Int32 rowHandle)
        {
            if (currentView.IsGroupRow(rowHandle))
                return IsGroupRowSelected(currentView, rowHandle);

            object row = currentView.GetRow(rowHandle);
            return GetSelectedIndex(row) != -1;
        }
        #endregion

        #region Attach|Detach
        protected virtual void Attach(RepositoryItemGridLookUpEdit rep)
        {
            if (rep == null) return;
            selection.Clear();
            _currentRepository = rep;

            edit = _currentRepository.View.GridControl.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            GridColumn column = _currentRepository.View.Columns.Add();
            column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.VisibleIndex = 0;
            column.FieldName = checkColumnFieldName;
            column.Caption = "Mark";
            column.OptionsColumn.ShowCaption = false;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.AllowSize = false;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            column.Width = GetCheckBoxWidth();
            column.ColumnEdit = edit;

            _currentRepository.View.Click += new EventHandler(View_Click);
            _currentRepository.View.CustomDrawColumnHeader += new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
            _currentRepository.View.CustomDrawGroupRow += new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
            _currentRepository.View.CustomUnboundColumnData += new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
            _currentRepository.View.KeyDown += new KeyEventHandler(view_KeyDown);
        }

        protected virtual void Detach()
        {
            if (_currentRepository == null) return;
            if (edit != null)
            {
                _currentRepository.View.GridControl.RepositoryItems.Remove(edit);
                edit.Dispose();
            }
            _currentRepository.View.Click -= new EventHandler(View_Click);
            _currentRepository.View.CustomDrawColumnHeader -= new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
            _currentRepository.View.CustomDrawGroupRow -= new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
            _currentRepository.View.CustomUnboundColumnData -= new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
            _currentRepository.View.KeyDown -= new KeyEventHandler(view_KeyDown);
            _currentRepository = null;
        }

        void Invalidate(GridView currentView)
        {
            currentView.BeginUpdate();
            currentView.EndUpdate();
        }
        void SelectRow(GridView currentView, Int32 rowHandle, bool select, bool invalidate)
        {
            if (IsRowSelected(currentView, rowHandle) == select) return;
            object row = currentView.GetRow(rowHandle);
            if (select)
                selection.Add(row);
            else
                selection.Remove(row);
            if (invalidate)
                Invalidate(currentView);
            OnSelectionChanged();
        }
        void view_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column != null && e.Column.FieldName == checkColumnFieldName)
            {
                if (e.IsGetData)
                    e.Value = IsRowSelected(currentView, currentView.GetRowHandle(e.ListSourceRowIndex));
                else
                    SelectRow(currentView, currentView.GetRowHandle(e.ListSourceRowIndex), (bool)e.Value);
            }
        }
        void view_KeyDown(object sender, KeyEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (currentView.FocusedColumn.FieldName != checkColumnFieldName || e.KeyCode != Keys.Space) return;
            InvertRowSelection(currentView, currentView.FocusedRowHandle);
        }
        void View_Click(object sender, EventArgs e)
        {
            GridHitInfo info;
            GridView currentView = (sender as GridView);
            Point pt = currentView.GridControl.PointToClient(Control.MousePosition);
            info = currentView.CalcHitInfo(pt);
            if (info.Column != null && info.Column.FieldName == checkColumnFieldName)
            {
                if (info.InColumn)
                {
                    if (SelectedCount == currentView.DataRowCount)
                        ClearSelection(currentView);
                    else
                        SelectAll(currentView);
                }
                if (info.InRowCell)
                    InvertRowSelection(currentView, info.RowHandle);
            }
            if (info.InRow && currentView.IsGroupRow(info.RowHandle) && info.HitTest != GridHitTest.RowGroupButton)
                InvertRowSelection(currentView, info.RowHandle);
        }
        void View_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == checkColumnFieldName)
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e.Graphics, e.Bounds, SelectedCount == (sender as GridView).DataRowCount);
                e.Handled = true;
            }
        }
        void View_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo info;
            info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;

            info.GroupText = "         " + info.GroupText.TrimStart();
            e.Info.Paint.FillRectangle(e.Graphics, e.Appearance.GetBackBrush(e.Cache), e.Bounds);
            e.Painter.DrawObject(e.Info);

            Rectangle r = info.ButtonBounds;
            r.Offset(r.Width + CheckboxIndent * 2 - 1, 0);
            DrawCheckBox(e.Graphics, r, IsGroupRowSelected((sender as GridView), e.RowHandle));
            e.Handled = true;
        }
        #endregion

        #region CheckBox
        protected Int32 GetCheckBoxWidth()
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            Int32 width = 0;
            GraphicsInfo.Default.AddGraphics(null);
            try
            {
                width = info.CalcBestFit(GraphicsInfo.Default.Graphics).Width;
            }
            finally
            {
                GraphicsInfo.Default.ReleaseGraphics();
            }
            return width + CheckboxIndent * 2;
        }

        protected void DrawCheckBox(Graphics g, Rectangle r, bool Checked)
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
            info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            painter = edit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
            info.EditValue = Checked;
            info.Bounds = r;
            info.CalcViewInfo(g);
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }
        #endregion
    }
}
