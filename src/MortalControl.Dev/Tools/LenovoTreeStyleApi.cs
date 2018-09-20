﻿using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.StyleFormatConditions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lenovo.XtraEditors.Tools
{
    public class LenovoTreeStyleApi
    {
        public static void SetBasicStyle(TreeList treeList)
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
        }

        public static void SetBasicStatusStyle(TreeList treeList)
        {
            //0:无效 1:有效 9:新增 10:删除
            StyleFormatCondition styleNewly = new StyleFormatCondition();
            styleNewly.Appearance.BackColor = Color.FromArgb(215, 235, 255);
            styleNewly.Appearance.ForeColor = Color.FromArgb(22, 23, 35);
            styleNewly.Appearance.Options.UseBackColor = true;
            styleNewly.Appearance.Options.UseForeColor = true;
            styleNewly.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleNewly.Expression = "Status == 9";
            treeList.FormatConditions.Add(styleNewly);

            StyleFormatCondition styleSaved = new StyleFormatCondition();
            styleSaved.Appearance.BackColor = Color.White;
            styleSaved.Appearance.ForeColor = Color.FromArgb(22, 23, 35);
            styleSaved.Appearance.Options.UseBackColor = true;
            styleSaved.Appearance.Options.UseForeColor = true;
            styleSaved.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleSaved.Expression = "Status == 1";
            treeList.FormatConditions.Add(styleSaved);

            StyleFormatCondition styleChanged = new StyleFormatCondition();
            styleChanged.Appearance.BackColor = System.Drawing.Color.FromArgb(196, 225, 255);
            styleChanged.Appearance.ForeColor = System.Drawing.Color.FromArgb(22, 23, 35);
            styleChanged.Appearance.Options.UseBackColor = true;
            styleChanged.Appearance.Options.UseForeColor = true;
            styleChanged.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleChanged.Expression = "Status != 9 && IsChanged == true";
            treeList.FormatConditions.Add(styleChanged);

            StyleFormatCondition styleStop = new StyleFormatCondition();
            styleStop.Appearance.BackColor = Color.FromArgb(198, 198, 198);
            styleStop.Appearance.ForeColor = Color.FromArgb(134, 136, 142);
            styleStop.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Pixel);
            styleStop.Appearance.Options.UseBackColor = true;
            styleStop.Appearance.Options.UseForeColor = true;
            styleStop.Appearance.Options.UseFont = true;
            styleStop.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleStop.Expression = "Status == 0 || Status == 10";
            treeList.FormatConditions.Add(styleStop);
        }
    }
}