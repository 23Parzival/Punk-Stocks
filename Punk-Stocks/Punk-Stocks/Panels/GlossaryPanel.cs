using Punk_Stocks.Services;
using System;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class GlossaryPanel : UserControl, IContentPanel
    {
        public GlossaryPanel()
        {
            InitializeComponent();
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Glossary");
            searchLabel.Text = LanguageManager.Get("Glossary_Search");
        }

        public void RefreshData()
        {
            //fill termsListBox with glossary terms
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //filter terms
        }

        private void termsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show selected term in termLabel and definitionLabel
        }
    }
}
