using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucIngelezenEenheidsPrijs.xaml
    /// </summary>
    public partial class ucAantalArtikelen : UserControl
    {
        public ucAantalArtikelen()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }

        public List<TextBox> listTB { get; private set; }

        string[] artikelen = { "Schoen", "Muts", "Sok", "Riem", "Broek", "Hemd", "Jas", "T-shirt", "Short", "Hoed" };
        double[] prijzen = {125, 12.5, 1.99, 24, 65, 49.99, 249.95, 9.99, 24.95, 18 };


        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            int aantal = random.Next(3, 6);
            int willekeurigGetal = 0;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i <= aantal; i++) 
            {
                willekeurigGetal = random.Next(artikelen.Length);
                stringBuilder.Append(i + " x " + artikelen[willekeurigGetal]
                    + " (" + prijzen[willekeurigGetal].ToString("F2") + ")\t= "
                    + (prijzen[willekeurigGetal] * i).ToString("F2") + "€" + Environment.NewLine);
            }

            txtResultaat.Text = stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());


        }

        private void btnGetAllItems_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < artikelen.Length; i++)
            {                
                stringBuilder.Append(artikelen[i]
                    + " (" + prijzen[i].ToString("F2") + ")" + Environment.NewLine);
            }

            txtAllItems.Text = stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}