using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucFactuur.xaml
    /// </summary>
    public partial class ucFactuur : UserControl
    {
        public ucFactuur()
        {
            InitializeComponent();
        }

        double upperTotaal = 0;

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double? prijs = Utils.ConvertStringInputToDouble(txtPrijs.Text, txtPrijs.Name);
            double? btwPercent = Utils.ConvertStringInputToDouble(txtBTWPercent.Text, txtBTWPercent.Name);
            double? kortingPercentage = Utils.ConvertStringInputToDouble(txtKortingPercentage.Text, txtKortingPercentage.Name);

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

            txtHandelskorting.Text = Double.Round(handelsKorting, 2).ToString("F2") + " €";
            txtSubTotaal.Text = Double.Round(subTotal, 2).ToString("F2") + " €";
            txtBTW.Text = Double.Round(btw, 2).ToString("F2") + " €";
            txtTotaal.Text = Double.Round(totaal, 2).ToString("F2") + " €";

            upperTotaal += totaal;
            txtTotaal2.Text = Double.Round(upperTotaal, 2).ToString("F2") + " €";

        }        

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            txtPrijs.Text = String.Empty;
            txtBTWPercent.Text = String.Empty;
            txtKortingPercentage.Text = String.Empty;
            txtHandelskorting.Text= String.Empty;
            txtSubTotaal.Text= String.Empty;
            txtBTW.Text = String.Empty;
            txtTotaal.Text = String.Empty;

        }
        

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, RoutedEventArgs e)
        {
            txtPrijs.Text = "1000";
            txtBTWPercent.Text = "21";
            txtKortingPercentage.Text = "12";
        }
    }
}
