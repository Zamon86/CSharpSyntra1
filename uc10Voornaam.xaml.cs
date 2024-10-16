using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
   
    public partial class uc10Voornaam : UserControl
    {
        public uc10Voornaam()
        {
            InitializeComponent();
            ListTB = [.. mainGrid.Children.OfType<TextBox>()];        
        }

        public List<TextBox> ListTB { get; private set; }
        

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(ListTB);
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