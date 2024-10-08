using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucIngelezenEenheidsPrijs.xaml
    /// </summary>
    public partial class uc10GetallenOmgekeerd : UserControl
    {
        public uc10GetallenOmgekeerd()
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

            for (int i = 10; i > 0; i--)
            {
                resultaat.Append(i + Environment.NewLine);
            }

            txtResultaat.Text = resultaat.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}