using DevExpress.XtraGrid;

namespace Lenovo.XtraEditors.Tools
{
    public class LenovoGridStyleApi
    {
        /// <summary>
        /// 设置Grid基础样式
        /// </summary>
        public static void SetBasicStyle(GridControl gridControl)
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
                    SetBasicStyle(bandedGridView: gridView as DevExpress.XtraGrid.Views.BandedGrid.BandedGridView);
                }
                else if (gridView is DevExpress.XtraGrid.Views.Grid.GridView)
                {
                    SetBasicStyle(gridView: gridView as DevExpress.XtraGrid.Views.Grid.GridView);
                }
            }
        }

        private static void SetBasicStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView)
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

            gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(253, 232, 236);
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
        }

        private static void SetBasicStyle(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView)
        {
            bandedGridView.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            bandedGridView.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            bandedGridView.Appearance.BandPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            bandedGridView.Appearance.BandPanel.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            bandedGridView.Appearance.BandPanel.Options.UseBackColor = true;
            bandedGridView.Appearance.BandPanel.Options.UseBorderColor = true;
            bandedGridView.Appearance.BandPanel.Options.UseFont = true;
            bandedGridView.Appearance.BandPanel.Options.UseForeColor = true;

            bandedGridView.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(246, 246, 246);
            bandedGridView.Appearance.BandPanelBackground.BorderColor = System.Drawing.Color.FromArgb(196, 196, 196);
            bandedGridView.Appearance.BandPanelBackground.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            bandedGridView.Appearance.BandPanelBackground.ForeColor = System.Drawing.Color.FromArgb(134, 136, 142);
            bandedGridView.Appearance.BandPanelBackground.Options.UseBackColor = true;
            bandedGridView.Appearance.BandPanelBackground.Options.UseBorderColor = true;
            bandedGridView.Appearance.BandPanelBackground.Options.UseFont = true;
            bandedGridView.Appearance.BandPanelBackground.Options.UseForeColor = true;

            SetBasicStyle(gridView: bandedGridView);
        }
    }
}
