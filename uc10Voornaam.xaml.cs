using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucIngelezenEenheidsPrijs.xaml
    /// </summary>
    public partial class uc10Voornaam : UserControl
    {
        public uc10Voornaam()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];        
        }

        public List<TextBox> listTB { get; private set; }
        

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {        
            StringBuilder resultaat = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                resultaat.Append(i + " Piotr" + Environment.NewLine);
            }

            txtResultaat.Text = resultaat.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}