using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucVergelijkWillekeurigGetal : UserControl
    {
        public ucVergelijkWillekeurigGetal()
        {
            InitializeComponent();
            ListTB = [.. mainGrid.Children.OfType<TextBox>()];  
        }

        public List<TextBox> ListTB { get; private set; }


        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int? getal = Utils.ConvertTextBoxInputToInteger(txtGetal);

            if (getal == null)
            {
                return;
            }

            if (getal <= 5 && getal >= 0)
            {
                txtResultaat.Text = "Het getal ligt tussen 0-5";
            }
            else
            {
                txtResultaat.Text = "Het getal ligt NIET tussen 0-5";
            }
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
           Utils.VerwijderenTextInTextBoxes(ListTB);
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            if (random.NextDouble() >= 0.5)
            {
                txtGetal.Text = random.Next(6).ToString();
            }
            else
            {
                txtGetal.Text = random.Next(201).ToString();
            }            
        }
    }
}
