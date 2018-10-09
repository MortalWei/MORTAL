using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.StyleFormatConditions;
using Lenovo.XtraEditors.IEventArgs;

namespace Lenovo.XtraEditors.Tools
{
    /// <summary>
    /// TreeList Style Api
    /// </summary>
    public class LenovoTreeStyleApi
    {
        /// <summary>
        /// TreeList Default Style
        /// </summary>
        /// <param name="treeList">Control</param>
        /// <param name="loadStatus">Whether Load Default Status Style</param>
        public static void SetBasicStyle(TreeList treeList, bool loadStatus = false, System.Collections.Generic.List<ITreeColumnEventArgs> eventArgs = null)
        {
            if (treeList == null) return;
            treeList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

            treeList.Appearance.Row.BackColor = System.Drawing.Color.White;
            treeList.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.Row.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            treeList.Appearance.Row.Options.UseBackColor = true;
            treeList.Appearance.Row.Options.UseBorderColor = true;
            treeList.Appearance.Row.Options.UseFont = true;
            treeList.Appearance.Row.Options.UseForeColor = true;

            treeList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            treeList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            treeList.Appearance.HeaderPanel.Options.UseBackColor = true;
            treeList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            treeList.Appearance.HeaderPanel.Options.UseFont = true;
            treeList.Appearance.HeaderPanel.Options.UseForeColor = true;

            treeList.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            treeList.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.BandPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.BandPanel.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            treeList.Appearance.BandPanel.Options.UseBackColor = true;
            treeList.Appearance.BandPanel.Options.UseBorderColor = true;
            treeList.Appearance.BandPanel.Options.UseFont = true;
            treeList.Appearance.BandPanel.Options.UseForeColor = true;

            treeList.Appearance.Caption.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            treeList.Appearance.Caption.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.Caption.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.Caption.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            treeList.Appearance.Caption.Options.UseBackColor = true;
            treeList.Appearance.Caption.Options.UseBorderColor = true;
            treeList.Appearance.Caption.Options.UseFont = true;
            treeList.Appearance.Caption.Options.UseForeColor = true;

            treeList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            treeList.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            treeList.Appearance.FocusedRow.Options.UseBackColor = true;
            treeList.Appearance.FocusedRow.Options.UseBorderColor = true;
            treeList.Appearance.FocusedRow.Options.UseFont = true;
            treeList.Appearance.FocusedRow.Options.UseForeColor = true;

            treeList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            treeList.Appearance.FocusedCell.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            treeList.Appearance.FocusedCell.Options.UseBackColor = true;
            treeList.Appearance.FocusedCell.Options.UseBorderColor = true;
            treeList.Appearance.FocusedCell.Options.UseFont = true;
            treeList.Appearance.FocusedCell.Options.UseForeColor = true;

            treeList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            treeList.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            treeList.Appearance.SelectedRow.Options.UseBackColor = true;
            treeList.Appearance.SelectedRow.Options.UseBorderColor = true;
            treeList.Appearance.SelectedRow.Options.UseFont = true;
            treeList.Appearance.SelectedRow.Options.UseForeColor = true;

            treeList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
            treeList.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            treeList.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            treeList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            treeList.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            treeList.Appearance.HideSelectionRow.Options.UseFont = true;
            treeList.Appearance.HideSelectionRow.Options.UseForeColor = true;

            treeList.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            treeList.Appearance.VertLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            treeList.Appearance.VertLine.Options.UseBackColor = true;
            treeList.Appearance.VertLine.Options.UseForeColor = true;

            treeList.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            treeList.Appearance.HorzLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            treeList.Appearance.HorzLine.Options.UseBackColor = true;
            treeList.Appearance.HorzLine.Options.UseForeColor = true;

            treeList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(198, 198, 198);
            treeList.Appearance.FixedLine.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            treeList.Appearance.FixedLine.Options.UseBackColor = true;
            treeList.Appearance.FixedLine.Options.UseForeColor = true;

            if (loadStatus) SetBasicStatusStyle(treeList);
            SetColumnEvent(treeList, eventArgs);

        }

        private static void SetBasicStatusStyle(TreeList treeList)
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
            treeList.FormatConditions.Add(styleStop);

            //有效
            StyleFormatCondition styleSaved = new StyleFormatCondition();
            styleSaved.Appearance.BackColor = System.Drawing.Color.White;
            styleSaved.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleSaved.Appearance.Options.UseBackColor = true;
            styleSaved.Appearance.Options.UseForeColor = true;
            styleSaved.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleSaved.Expression = "Status == 1";
            treeList.FormatConditions.Add(styleSaved);

            //新增
            StyleFormatCondition styleNewly = new StyleFormatCondition();
            styleNewly.Appearance.BackColor = System.Drawing.Color.FromArgb(215, 235, 255);
            styleNewly.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleNewly.Appearance.Options.UseBackColor = true;
            styleNewly.Appearance.Options.UseForeColor = true;
            styleNewly.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleNewly.Expression = "Status == 9";
            treeList.FormatConditions.Add(styleNewly);

            //修改
            //修改-有效
            StyleFormatCondition styleChanged = new StyleFormatCondition();
            styleChanged.Appearance.BackColor = System.Drawing.Color.FromArgb(196, 225, 255);
            styleChanged.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleChanged.Appearance.Options.UseBackColor = true;
            styleChanged.Appearance.Options.UseForeColor = true;
            styleChanged.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleChanged.Expression = "(Status == 0 || Status == 1) && IsChanged == true";
            treeList.FormatConditions.Add(styleChanged);
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
            treeList.FormatConditions.Add(styleDeleted);

        }

        private static void SetColumnEvent(TreeList treeList, System.Collections.Generic.List<ITreeColumnEventArgs> eventArgs)
        {
            if (treeList == null || eventArgs == null) return;
            var _Cols = treeList.Columns;
            foreach (TreeListColumn column in _Cols)
            {
                column.Tag = eventArgs.Find(c => c.FieldName == column.FieldName);
            }
        }
    }
}
