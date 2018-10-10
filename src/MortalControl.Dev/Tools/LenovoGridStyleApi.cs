using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Lenovo.XtraEditors.IEventArgs;

namespace Lenovo.XtraEditors.Tools
{
    /// <summary>
    /// GridControl Style Api
    /// </summary>
    public class LenovoGridStyleApi
    {
        /// <summary>
        /// Set GridControl Deafult Style
        /// <param name="gridControl">Control</param>
        /// <param name="loadStatus">Whether Load Default Status Style</param>
        /// <param name="eventArgs">Column Event Args</param>
        /// </summary>
        public static void SetBasicStyle(GridControl gridControl, bool loadStatus = false, System.Collections.Generic.List<IGridColumnEventArgs> eventArgs = null)
        {
            if (gridControl == null) return;
            if (gridControl.Views.Count == 0) return;
            gridControl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            foreach (DevExpress.XtraGrid.Views.Base.BaseView gridView in gridControl.Views)
            {
                if (gridView is DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
                   ||
                   gridView is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
                {
                    SetBasicStyle(bandedGridView: gridView as DevExpress.XtraGrid.Views.BandedGrid.BandedGridView, loadStatus: loadStatus);
                }
                else if (gridView is DevExpress.XtraGrid.Views.Grid.GridView)
                {
                    SetBasicStyle(gridView: gridView as DevExpress.XtraGrid.Views.Grid.GridView, loadStatus: loadStatus);
                }
                if (eventArgs != null) SetColumnEvent(gridView as DevExpress.XtraGrid.Views.Grid.GridView, eventArgs);
            }
        }

        /// <summary>
        /// Set Only Font Style
        /// </summary>
        /// <param name="gridControl"></param>
        public static void SetFontStyle(GridControl gridControl)
        {
            if (gridControl == null) return;
            if (gridControl.Views.Count == 0) return;
            foreach (DevExpress.XtraGrid.Views.Base.BaseView gridView in gridControl.Views)
            {
                if (gridView is DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
                   ||
                   gridView is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
                {
                    SetFontStyle(bandedGridView: gridView as DevExpress.XtraGrid.Views.BandedGrid.BandedGridView);
                }
                else if (gridView is DevExpress.XtraGrid.Views.Grid.GridView)
                {
                    SetFontStyle(gridView: gridView as DevExpress.XtraGrid.Views.Grid.GridView);
                }
            }
        }

        private static void SetFontStyle(GridView gridView)
        {
            gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            gridView.Appearance.HeaderPanel.Options.UseFont = true;
            
            gridView.Appearance.Row.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.Row.Options.UseFont = true;
            
            gridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.FocusedCell.Options.UseFont = true;
            
            gridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.FocusedRow.Options.UseFont = true;
            
            gridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.SelectedRow.Options.UseFont = true;
            
            gridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.HideSelectionRow.Options.UseFont = true;

            gridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.VertLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.VertLine.Options.UseBackColor = true;
            gridView.Appearance.VertLine.Options.UseForeColor = true;

            gridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.HorzLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.HorzLine.Options.UseBackColor = true;
            gridView.Appearance.HorzLine.Options.UseForeColor = true;

            gridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.FixedLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.FixedLine.Options.UseBackColor = true;
            gridView.Appearance.FixedLine.Options.UseForeColor = true;
        }

        private static void SetFontStyle(BandedGridView bandedGridView)
        {
            bandedGridView.Appearance.BandPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            bandedGridView.Appearance.BandPanel.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            bandedGridView.Appearance.BandPanel.Options.UseFont = true;

            SetFontStyle(gridView: bandedGridView);
        }

        private static void SetColumnEvent(DevExpress.XtraGrid.Views.Grid.GridView gridView, System.Collections.Generic.List<IGridColumnEventArgs> eventArgs)
        {
            var _Cols = gridView.Columns;
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in _Cols)
            {
                column.Tag = eventArgs.Find(c => c.FieldName == column.FieldName);
            }
        }

        private static void SetBasicStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView, bool loadStatus = false)
        {
            gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            gridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            gridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            gridView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            gridView.Appearance.HeaderPanel.Options.UseFont = true;
            gridView.Appearance.HeaderPanel.Options.UseForeColor = true;

            gridView.Appearance.Row.BackColor = System.Drawing.Color.White;
            gridView.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            gridView.Appearance.Row.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.Row.Options.UseBackColor = true;
            gridView.Appearance.Row.Options.UseBorderColor = true;
            gridView.Appearance.Row.Options.UseFont = true;
            gridView.Appearance.Row.Options.UseForeColor = true;

            gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(196, 225, 255);
            gridView.Appearance.FocusedCell.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            gridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.FocusedCell.Options.UseBackColor = true;
            gridView.Appearance.FocusedCell.Options.UseBorderColor = true;
            gridView.Appearance.FocusedCell.Options.UseFont = true;
            gridView.Appearance.FocusedCell.Options.UseForeColor = true;

            gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            gridView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            gridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView.Appearance.FocusedRow.Options.UseBorderColor = true;
            gridView.Appearance.FocusedRow.Options.UseFont = true;
            gridView.Appearance.FocusedRow.Options.UseForeColor = true;

            gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            gridView.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            gridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            gridView.Appearance.SelectedRow.Options.UseBorderColor = true;
            gridView.Appearance.SelectedRow.Options.UseFont = true;
            gridView.Appearance.SelectedRow.Options.UseForeColor = true;

            gridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            gridView.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            gridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            gridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            gridView.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            gridView.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView.Appearance.HideSelectionRow.Options.UseForeColor = true;

            gridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.VertLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.VertLine.Options.UseBackColor = true;
            gridView.Appearance.VertLine.Options.UseForeColor = true;

            gridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.HorzLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.HorzLine.Options.UseBackColor = true;
            gridView.Appearance.HorzLine.Options.UseForeColor = true;

            gridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.FixedLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            gridView.Appearance.FixedLine.Options.UseBackColor = true;
            gridView.Appearance.FixedLine.Options.UseForeColor = true;

            if (loadStatus) SetBasicStatusStyle(gridView);
        }

        private static void SetBasicStyle(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView, bool loadStatus = false)
        {
            bandedGridView.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            bandedGridView.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            bandedGridView.Appearance.BandPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            bandedGridView.Appearance.BandPanel.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            bandedGridView.Appearance.BandPanel.Options.UseBackColor = true;
            bandedGridView.Appearance.BandPanel.Options.UseBorderColor = true;
            bandedGridView.Appearance.BandPanel.Options.UseFont = true;
            bandedGridView.Appearance.BandPanel.Options.UseForeColor = true;

            SetBasicStyle(gridView: bandedGridView, loadStatus: loadStatus);
        }

        private static void SetBasicStatusStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            //0:无效 1:有效 9:新增 10:删除
            //无效
            StyleFormatCondition styleStop = new StyleFormatCondition();
            styleStop.Appearance.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            styleStop.Appearance.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            styleStop.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Pixel);
            styleStop.Appearance.Options.UseBackColor = true;
            styleStop.Appearance.Options.UseForeColor = true;
            styleStop.Appearance.Options.UseFont = true;
            styleStop.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleStop.Expression = "Status == 0 || Status == 10";
            gridView.FormatConditions.Add(styleStop);

            //有效
            StyleFormatCondition styleSaved = new StyleFormatCondition();
            styleSaved.Appearance.BackColor = System.Drawing.Color.White;
            styleSaved.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleSaved.Appearance.Options.UseBackColor = true;
            styleSaved.Appearance.Options.UseForeColor = true;
            styleSaved.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleSaved.Expression = "Status == 1";
            gridView.FormatConditions.Add(styleSaved);

            //新增
            StyleFormatCondition styleNewly = new StyleFormatCondition();
            styleNewly.Appearance.BackColor = System.Drawing.Color.FromArgb(215, 235, 255);
            styleNewly.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleNewly.Appearance.Options.UseBackColor = true;
            styleNewly.Appearance.Options.UseForeColor = true;
            styleNewly.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleNewly.Expression = "Status == 9";
            gridView.FormatConditions.Add(styleNewly);

            //修改
            //修改-有效
            StyleFormatCondition styleChanged = new StyleFormatCondition();
            styleChanged.Appearance.BackColor = System.Drawing.Color.FromArgb(196, 225, 255);
            styleChanged.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleChanged.Appearance.Options.UseBackColor = true;
            styleChanged.Appearance.Options.UseForeColor = true;
            styleChanged.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleChanged.Expression = "(Status == 0 || Status == 1) && IsChanged == true";
            gridView.FormatConditions.Add(styleChanged);
            //修改-删除
            StyleFormatCondition styleDeleted = new StyleFormatCondition();
            styleDeleted.Appearance.BackColor = System.Drawing.Color.FromArgb(196, 225, 255);
            styleDeleted.Appearance.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            styleDeleted.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Pixel);
            styleDeleted.Appearance.Options.UseBackColor = true;
            styleDeleted.Appearance.Options.UseForeColor = true;
            styleDeleted.Appearance.Options.UseFont = true;
            styleDeleted.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleDeleted.Expression = "Status == 10 && IsChanged == true";
            gridView.FormatConditions.Add(styleDeleted);

            //选中
            StyleFormatCondition styleChecked = new StyleFormatCondition();
            styleChecked.Appearance.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            styleChecked.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleChecked.Appearance.Options.UseBackColor = true;
            styleChecked.Appearance.Options.UseForeColor = true;
            styleChecked.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleChecked.Expression = "IsChecked == true";
            gridView.FormatConditions.Add(styleChecked);

            StyleFormatCondition styleSelected = new StyleFormatCondition();
            styleSelected.Appearance.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            styleSelected.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleSelected.Appearance.Options.UseBackColor = true;
            styleSelected.Appearance.Options.UseForeColor = true;
            styleSelected.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleSelected.Expression = "IsChecked == true";
            gridView.FormatConditions.Add(styleSelected);
        }
    }
}
