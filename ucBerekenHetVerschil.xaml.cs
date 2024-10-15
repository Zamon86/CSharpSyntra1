using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucBerekenHetVerschil : UserControl
    {
        public ucBerekenHetVerschil()
        {
            InitializeComponent();

            ListTB = [.. mainGrid.Children.OfType<TextBox>()];

        }

        public List<TextBox> ListTB { get; private set; }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(501).ToString();
            txtGetal2.Text = random.Next(501).ToString();

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(ListTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

            if (getal1.HasValue && getal2.HasValue)
            {
                if (getal1 == getal2)
                {
                    txtResultaat.Text = "De getallen zijn gelijk.";
                }
                else 
                {
                    txtResultaat.Text = Math.Abs(getal1.Value - getal2.Value).ToString();
                }
                
            }            
        }
    }
}