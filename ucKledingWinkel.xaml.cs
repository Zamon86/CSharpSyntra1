using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucKledingWinkel : UserControl
    {
        public ucKledingWinkel()
        {
            InitializeComponent();
            ListTB = [.. mainGrid.Children.OfType<TextBox>()];
        }

        public List<TextBox> ListTB { get; private set; }


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
                if (bonBedrag == 0)
                {
                    txtResultaat.Text = "Er wordt geen kortingsbon gegeven";
                }
                else 
                {
                    txtResultaat.Text = string.Format("Er wordt een kortingsbon gegeven van {0}€", bonBedrag);
                }               
            }
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(ListTB);
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtBedrag.Text = random.Next(30, 250).ToString();
            txtKortingspercentage.Text = random.Next(5, 15).ToString();
        }
    }
}