using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
   
    public partial class uc10Getallen : UserControl
    {
        public uc10Getallen()
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
                resultaat.Append(i + Environment.NewLine);
            }

            txtResultaat.Text = resultaat.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}