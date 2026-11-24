using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class GlossaryPanel : UserControl, IContentPanel
    {
        //each id has Glossary_<id>_Term and Glossary_<id>_Definition in the resource files
        private static readonly string[] TermIds =
        {
            "Stock", "Share", "Portfolio", "Holding", "AvgCost", "MarketValue",
            "Profit", "Realized", "Unrealized", "Sector", "Volatility", "Dividend",
            "DividendYield", "Watchlist", "Buy", "Sell", "Diversification"
        };

        //all terms in the current language, sorted by name
        private List<GlossaryTerm> terms = new List<GlossaryTerm>();

        public GlossaryPanel()
        {
            InitializeComponent();
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Glossary");
            searchLabel.Text = LanguageManager.Get("Glossary_Search");

            //keep the same term selected in the new language
            GlossaryTerm selected = termsListBox.SelectedItem as GlossaryTerm;

            terms = TermIds
                .Select(id => new GlossaryTerm
                {
                    Id = id,
                    Term = LanguageManager.Get("Glossary_" + id + "_Term"),
                    Definition = LanguageManager.Get("Glossary_" + id + "_Definition")
                })
                .OrderBy(t => t.Term, StringComparer.CurrentCulture)
                .ToList();

            ShowTerms(selected == null ? null : selected.Id);
        }

        public void RefreshData()
        {
            //nothing to reload
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            GlossaryTerm selected = termsListBox.SelectedItem as GlossaryTerm;
            ShowTerms(selected == null ? null : selected.Id);
        }

        //fills the list with the terms that match the search, then selects one
        private void ShowTerms(string selectId)
        {
            string search = searchTextBox.Text.Trim();
            List<GlossaryTerm> matches = terms.Where(t => Matches(t, search)).ToList();

            termsListBox.BeginUpdate();
            termsListBox.Items.Clear();
            termsListBox.Items.AddRange(matches.ToArray());
            termsListBox.EndUpdate();

            if (matches.Count == 0)
            {
                termLabel.Text = "";
                definitionLabel.Text = LanguageManager.Get("Glossary_NoResults");
                return;
            }

            int index = matches.FindIndex(t => t.Id == selectId);
            termsListBox.SelectedIndex = index < 0 ? 0 : index;
        }

        //ignores case and accents
        private static bool Matches(GlossaryTerm term, string search)
        {
            if (search.Length == 0)
                return true;

            CompareInfo compare = CultureInfo.CurrentCulture.CompareInfo;
            CompareOptions options = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace;
            return compare.IndexOf(term.Term, search, options) >= 0 || compare.IndexOf(term.Definition, search, options) >= 0;
        }

        private void termsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlossaryTerm term = termsListBox.SelectedItem as GlossaryTerm;
            if (term == null)
                return;

            termLabel.Text = term.Term;
            definitionLabel.Text = term.Definition;
        }

        private class GlossaryTerm
        {
            public string Id { get; set; }
            public string Term { get; set; }
            public string Definition { get; set; }

            public override string ToString()
            {
                return Term;
            }
        }
    }
}
