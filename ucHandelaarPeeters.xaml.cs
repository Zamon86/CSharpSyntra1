
using System;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucHandelaarPeeters.xaml
    /// </summary>
    public partial class ucHandelaarPeeters : UserControl
    {
        public ucHandelaarPeeters()
        {
            InitializeComponent();
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double? prijs = Utils.ConvertStringInputToDouble(txtPrijs.Text, txtPrijs.Name);
            double? btwPercent = Utils.ConvertStringInputToDouble(txtBTWPercent.Text, txtBTWPercent.Name);
            double kortingBedrag = 0;
            double btwBedrag = 0;
            double totaal = 0;
            

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
            txtPrijs.Text = String.Empty;
            txtBTWPercent.Text = String.Empty;
            txtHandelskorting.Text= String.Empty;
            txtBTW.Text = String.Empty;
            txtTotaal.Text= String.Empty;
        }


        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, RoutedEventArgs e)
        {
            txtPrijs.Text = "1500";
            txtBTWPercent.Text = "21";           
        }
    }
}