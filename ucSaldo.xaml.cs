using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucSaldo : UserControl
    {
        public ucSaldo()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? saldo = Utils.ConvertTextBoxInputToDouble(txtSaldo);
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
            Utils.VerwijderenTextInTextBoxes(listTB);
        }        

        private void btnVulDeWaardeIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();  
            double randomValue = random.NextDouble() * (250 - (-500)) + (-500);

            txtSaldo.Text = Math.Round(randomValue, 2).ToString("F2");
        }
    }
}