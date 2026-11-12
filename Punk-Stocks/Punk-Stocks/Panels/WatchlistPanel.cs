using Punk_Stocks.Services;
using System;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class WatchlistPanel : UserControl, IContentPanel
    {
        public WatchlistPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(watchlistGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Watchlist");
            removeButton.Text = LanguageManager.Get("Watchlist_Remove");

            symbolColumn.HeaderText = LanguageManager.Get("Column_Symbol");
            companyColumn.HeaderText = LanguageManager.Get("Column_Company");
            sectorColumn.HeaderText = LanguageManager.Get("Column_Sector");
            priceColumn.HeaderText = LanguageManager.Get("Column_Price");
        }

        public void RefreshData()
        {
            //load watchlist wt a repo
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //remove selected stock from watchlist
        }
    }
}
