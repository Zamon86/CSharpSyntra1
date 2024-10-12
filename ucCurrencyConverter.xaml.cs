using System.Windows.Controls;

namespace LogikaOefening
{
   
    public partial class ucCurrencyConverter : UserControl
    {
        public ucCurrencyConverter()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }        

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
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnVulDeRandomWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtEuro.Text = (random.Next(1, 11) * 100).ToString();
            txtDollarKoers.Text = Math.Round((random.NextDouble() * (0.85 - 0.65) + 0.65), 4).ToString();
            txtBritsePondKoers.Text = Math.Round((random.NextDouble() * (1.35 - 1.15) + 1.15), 4).ToString();
        }
    }
}