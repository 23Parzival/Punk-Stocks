using Punk_Stocks.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    internal static class PanelStyle
    {
        public static readonly Color AccentColor = Color.FromArgb(99, 102, 241);
        public static readonly Color GainColor = Color.SeaGreen;
        public static readonly Color LossColor = Color.IndianRed;

        //grid settings for every panel
        public static void StyleGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.DefaultCellStyle.SelectionBackColor = AccentColor;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        public static Color ProfitColor(decimal value)
        {
            if (value > 0)
                return GainColor;
            if (value < 0)
                return LossColor;
            return Color.Black;
        }

        public static void ShowLoadError(Exception ex)
        {
            MessageBox.Show("Could not load the data:" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
