using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucCelsius_Fahrenheid.xaml
    /// </summary>
    public partial class ucCelsius_Fahrenheid : UserControl
    {
        public ucCelsius_Fahrenheid()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }       

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);          
        }

        private void btnBerekenenCF_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? celsius = Utils.ConvertTextBoxInputToDouble(txtCelsius);
            
            if (celsius != null)
            {
                txtOmzettingNaarFahrenheid.Text = Math.Round(celsius.Value * 9 / 5 + 32, 1).ToString();                
            }
        }

        private void btnBerekenenFC_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? fahrenheid = Utils.ConvertTextBoxInputToDouble(txtFahrenheid);

            if (fahrenheid != null)
            {
                txtOmzettingNaarCelsius.Text = Math.Round((fahrenheid.Value - 32) * 5 / 9, 1).ToString();
            }
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtCelsius.Text = Math.Round((random.NextDouble() * (50 - (-15)) + (-15)), 1).ToString();
            txtFahrenheid.Text = Math.Round((random.NextDouble() * 122), 1).ToString();
        }
    }
}