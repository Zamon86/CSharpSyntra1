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
            listTB = [.. mainGrid.Children.OfType<TextBox>()];        
        }

        public List<TextBox> listTB { get; private set; }

        private void btnVulDeWaardeIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random(); 
            txtEenheidsprijs.Text = Math.Round(random.NextDouble() * (450 - 50) + 50, 2).ToString("F2");

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
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