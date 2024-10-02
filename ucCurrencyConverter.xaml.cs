
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucCurrencyConverter.xaml
    /// </summary>
    public partial class ucCurrencyConverter : UserControl
    {
        public ucCurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnVulDeWaardeUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtEuro.Text = "1000";
            txtDollarKoers.Text = "0,7321";
            txtBritsePondKoers.Text = "1,2215";
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? euro = Utils.ConvertTextBoxInputToDouble(txtEuro);
            double? dollarKoers = Utils.ConvertTextBoxInputToDouble(txtDollarKoers);
            double? britsePondKoers = Utils.ConvertTextBoxInputToDouble(txtBritsePondKoers);
            if (euro != null && dollarKoers != null && britsePondKoers != null)
            {
                txtBritsePond.Text = Math.Round(euro.Value/britsePondKoers.Value, 2).ToString("F2");
                txtDollars.Text = Math.Round(euro.Value/dollarKoers.Value, 2).ToString("F2");
            }

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtEuro.Text = String.Empty;
            txtDollarKoers.Text = String.Empty;
            txtBritsePondKoers.Text = String.Empty;
            txtBritsePond.Text = String.Empty;
            txtDollars.Text = String.Empty;
        }
    }
}