using Punk_Stocks.Services;
using System;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class ReportsPanel : UserControl, IContentPanel
    {
        public ReportsPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(reportGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Reports");
            reportTypeLabel.Text = LanguageManager.Get("Reports_Type");
            generateButton.Text = LanguageManager.Get("Reports_Generate");

            int selected = reportTypeComboBox.SelectedIndex;
            reportTypeComboBox.Items.Clear();
            reportTypeComboBox.Items.Add(LanguageManager.Get("Reports_Portfolio"));
            reportTypeComboBox.Items.Add(LanguageManager.Get("Reports_Sectors"));
            reportTypeComboBox.Items.Add(LanguageManager.Get("Reports_ProfitLoss"));
            reportTypeComboBox.SelectedIndex = selected < 0 ? 0 : selected;
        }

        public void RefreshData()
        {
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //build the selected report into reportGrid
        }
    }
}
