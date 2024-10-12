using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucFactuur : UserControl
    {
        public ucFactuur()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
            listTB.Remove(txtTotaal2);
        }
        public List<TextBox> listTB { get; private set; }
        private double upperTotaal = 0;

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double? prijs = Utils.ConvertTextBoxInputToDouble(txtPrijs);
            double? btwPercent = Utils.ConvertTextBoxInputToDouble(txtBTWPercent);
            double? kortingPercentage = Utils.ConvertTextBoxInputToDouble(txtKortingPercentage);

            if (prijs == null || btwPercent == null || kortingPercentage == null)
            {
                return;
            }

            double handelsKorting;
            double subTotal;
            double btw;
            double totaal;

            handelsKorting = (prijs.Value * kortingPercentage.Value) / 100;
            subTotal = prijs.Value - handelsKorting;
            btw = (subTotal * btwPercent.Value) / 100;
            totaal = subTotal + btw;

            txtHandelskorting.Text = Double.Round(handelsKorting, 2).ToString("F2");
            txtSubTotaal.Text = Double.Round(subTotal, 2).ToString("F2");
            txtBTW.Text = Double.Round(btw, 2).ToString("F2");
            txtTotaal.Text = Double.Round(totaal, 2).ToString("F2");

            upperTotaal += totaal;
            txtTotaal2.Text = Double.Round(upperTotaal, 2).ToString("F2");

        }        

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }   

        private void btnVulDeRandomWaardenIn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            txtPrijs.Text = random.Next(500, 5001).ToString();

            int[] btws = { 0, 6, 9, 12, 21 };            
            txtBTWPercent.Text = btws[random.Next(btws.Length)].ToString();

            txtKortingPercentage.Text = random.Next(5, 25).ToString();
        }
    }
}
