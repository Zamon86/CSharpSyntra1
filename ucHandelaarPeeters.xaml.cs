using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucHandelaarPeeters : UserControl
    {
        public ucHandelaarPeeters()
        {
            InitializeComponent();
            ListTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> ListTB { get; private set; }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double? prijs = Utils.ConvertTextBoxInputToDouble(txtPrijs);
            double? btwPercent = Utils.ConvertTextBoxInputToDouble(txtBTWPercent);
            double kortingBedrag = 0;
            double btwBedrag;
            double totaal;
            

            if (prijs == null || btwPercent == null)
            {
                return;
            }

            if (chkIsBetaaldBinnen10Dagen.IsChecked == true)
            {
                kortingBedrag = prijs.Value * 0.02;
            }

            btwBedrag = (prijs.Value - kortingBedrag) * btwPercent.Value / 100;
            totaal = prijs.Value - kortingBedrag + btwBedrag;

            txtHandelskorting.Text = Math.Round(kortingBedrag, 2).ToString("F2");
            txtBTW.Text = Math.Round(btwBedrag, 2).ToString("F2");
            txtTotaal.Text = Math.Round(totaal, 2).ToString("F2");       
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(ListTB);
        }
        

        private void btnVulDeWaardenIn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            txtPrijs.Text = (random.Next(10, 51) * 100).ToString();
            
            int[] btws = { 0, 6, 9, 12, 21 };
            txtBTWPercent.Text = btws[random.Next(btws.Length)].ToString();
        }
    }
}