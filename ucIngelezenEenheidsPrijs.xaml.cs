
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucIngelezenEenheidsPrijs.xaml
    /// </summary>
    public partial class ucIngelezenEenheidsPrijs : UserControl
    {
        public ucIngelezenEenheidsPrijs()
        {
            InitializeComponent();
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            double maxRandom = 450;
            double minRandom = 50;

            double prijs = random.NextDouble() * (maxRandom - minRandom) + minRandom;
            txtEenheidsprijs.Text = Math.Round(prijs, 2).ToString("F2");

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtEenheidsprijs.Text = String.Empty;
            txtNettoTeBetalenBedrag.Text = String.Empty;
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? prijs = Utils.ConvertTextBoxInputToDouble(txtEenheidsprijs);
            double korting = 10;

            if (prijs == null)
            {
                return;
            }

            if (prijs > 250)
            {
                txtNettoTeBetalenBedrag.Text = (prijs.Value - (prijs.Value * korting) / 100).ToString("F2");
            }
            else 
            {
                txtNettoTeBetalenBedrag.Text = prijs.Value.ToString("F2");
            }


        }
    }
}