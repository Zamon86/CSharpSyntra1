
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucSaldo.xaml
    /// </summary>
    public partial class ucSaldo : UserControl
    {
        public ucSaldo()
        {
            InitializeComponent();
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? saldo = Utils.ConvertStringInputToDouble(txtSaldo.Text, txtSaldo.Name);
            if (saldo.HasValue)
            {
                if (saldo.Value <= -250)
                {
                    txtBoodschap.Text = string.Format("Uw saldo bedraagt {0}€. Graag uw saldo aanzuiveren.", saldo.Value.ToString("F2"));
                }
                else 
                {
                    txtBoodschap.Text = "U saldo is OK.";
                }
            }

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtBoodschap.Text = string.Empty;
            txtSaldo.Text = string.Empty;
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random  random = new Random();
            double maxValue = 500;
            double minValue = -500;

            double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;

            txtSaldo.Text = Math.Round(randomValue, 2).ToString("F2");
            
        }
    }
}