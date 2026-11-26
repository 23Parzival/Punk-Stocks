using Punk_Stocks.Models.Enums;
using Punk_Stocks.Services;
using System;
using System.Windows.Forms;

namespace Punk_Stocks.Forms
{
    //asks for the direction and target price of a new alert
    public partial class AlertForm : Form
    {
        private readonly Stock stock;

        //read these after ShowDialog returns OK
        internal AlertDirection Direction { get { return (AlertDirection)directionComboBox.SelectedIndex; } }
        internal decimal TargetPrice { get { return targetNumericUpDown.Value; } }

        internal AlertForm(Stock stock)
        {
            InitializeComponent();
            this.stock = stock;
            ApplyLanguage();

            //start at the current price
            targetNumericUpDown.Value = Math.Max(targetNumericUpDown.Minimum, Math.Min(targetNumericUpDown.Maximum, stock.CurrentPrice));
        }

        private void ApplyLanguage()
        {
            Text = LanguageManager.Get("Market_AddAlert");
            promptLabel.Text = LanguageManager.Format("Alert_Prompt", stock.Symbol);
            currentPriceLabel.Text = LanguageManager.Format("Alert_CurrentPrice", stock.CurrentPrice.ToString("C2"));
            okButton.Text = LanguageManager.Get("Common_OK");
            cancelButton.Text = LanguageManager.Get("Common_Cancel");

            directionComboBox.Items.Clear();
            directionComboBox.Items.Add(LanguageManager.Get("Alert_Above"));
            directionComboBox.Items.Add(LanguageManager.Get("Alert_Below"));
            directionComboBox.SelectedIndex = (int)AlertDirection.Above;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //an alert that is already reached would go off right away
            bool alreadyReached = Direction == AlertDirection.Above ? stock.CurrentPrice >= TargetPrice : stock.CurrentPrice <= TargetPrice;
            if (alreadyReached)
            {
                string key = Direction == AlertDirection.Above ? "Alert_AlreadyAbove" : "Alert_AlreadyBelow";
                MessageBox.Show(LanguageManager.Format(key, stock.Symbol, TargetPrice.ToString("C2")), Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
