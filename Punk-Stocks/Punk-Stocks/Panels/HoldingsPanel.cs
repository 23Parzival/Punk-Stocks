using Punk_Stocks.Repositories;
using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class HoldingsPanel : UserControl, IContentPanel
    {
        private readonly HoldingRepository holdingRepository = new HoldingRepository();

        public HoldingsPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(holdingsGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Holdings");

            symbolColumn.HeaderText = LanguageManager.Get("Column_Symbol");
            companyColumn.HeaderText = LanguageManager.Get("Column_Company");
            quantityColumn.HeaderText = LanguageManager.Get("Column_Quantity");
            avgCostColumn.HeaderText = LanguageManager.Get("Column_AvgCost");
            priceColumn.HeaderText = LanguageManager.Get("Column_Price");
            marketValueColumn.HeaderText = LanguageManager.Get("Column_MarketValue");
            profitColumn.HeaderText = LanguageManager.Get("Column_Profit");
        }

        public async void RefreshData()
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            List<Holding> holdings;
            try
            {
                holdings = await Task.Run(() => holdingRepository.GetForUser(user.UserID));
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            holdingsGrid.DataSource = holdings.Select(h => new
            {
                h.Stock.Symbol,
                h.Stock.CompanyName,
                h.Quantity,
                h.AvgCost,
                h.Stock.CurrentPrice,
                MarketValue = h.Quantity * h.Stock.CurrentPrice,
                Profit = h.Quantity * (h.Stock.CurrentPrice - h.AvgCost)
            }).ToList();
        }

        private void holdingsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == profitColumn.Index && e.Value is decimal)
                e.CellStyle.ForeColor = PanelStyle.ProfitColor((decimal)e.Value);
        }
    }
}
