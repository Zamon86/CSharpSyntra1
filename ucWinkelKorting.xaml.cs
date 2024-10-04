
using System;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucWinkelKorting.xaml
    /// </summary>
    public partial class ucWinkelKorting : UserControl
    {
        public ucWinkelKorting()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }

        public List<TextBox> listTB { get; private set; }


        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? bedrag = Utils.ConvertTextBoxInputToDouble(txtBedrag);
            double? kortingsPercentage = Utils.ConvertTextBoxInputToDouble(txtKortingspercentage);
             
            if (bedrag == null || kortingsPercentage == null)
            {
                return;
            }

            double kortingsBedrag = kortingsPercentage.Value * bedrag.Value / 100;



            if (kortingsBedrag > 15)
            {
                txtResultaat.Text = string.Format("Korting is {0}€", kortingsBedrag);
            }
            else
            {
                int bonBedrag = (int)(Math.Floor(kortingsBedrag / 5) * 5);
                txtResultaat.Text = string.Format("Er wordt een kortingsbon gegeven van {0}€", bonBedrag);
            }
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            foreach (var tb in listTB)
            {
                tb.Text = String.Empty;
            }
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rnd = new Random();
            txtBedrag.Text = rnd.Next(30, 500).ToString();
            txtKortingspercentage.Text = rnd.Next(10, 20).ToString();
        }
    }
}