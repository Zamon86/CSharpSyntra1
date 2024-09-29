
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucGetallenZijnGelijk.xaml
    /// </summary>
    public partial class ucGetallenZijnGelijk : UserControl
    {
        public ucGetallenZijnGelijk()
        {
            InitializeComponent();
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            int getal1 = random.Next(10, 20);
            int getal2;

            if (random.NextDouble() >= 0.5)
            {
                getal2 = getal1;
            }
            else
            {
                getal2 = random.Next(0, 10);
            }

            txtGetal1.Text = getal1.ToString();
            txtGetal2.Text = getal2.ToString();

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtBoodschap.Text = string.Empty;
            txtGetal1.Text = string.Empty;
            txtGetal2.Text = string.Empty;
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int? getal1 = Utils.ConvertStringInputToInteger(txtGetal1.Text, txtGetal1.Name);
            int? getal2 = Utils.ConvertStringInputToInteger(txtGetal2.Text, txtGetal2.Name);

            if (getal1 == null || getal2 == null)
            {
                return;
            }

            if (getal1 == getal2)
            {
                txtBoodschap.Text = "De twee getallen zijn gelijk";
            }
            else
            {
                txtBoodschap.Text = "De twee getallen zijn niet gelijk";
            }


        }
    }
}