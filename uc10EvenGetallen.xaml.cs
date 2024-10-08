using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucIngelezenEenheidsPrijs.xaml
    /// </summary>
    public partial class uc10EvenGetallen : UserControl
    {
        public uc10EvenGetallen()
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
            int i = 0;

            do
            {
                i += 2;
                resultaat.Append(i + Environment.NewLine);

            } while (i < 20);            

            txtResultaat.Text = resultaat.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}