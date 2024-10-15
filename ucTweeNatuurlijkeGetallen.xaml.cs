using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucTweeNatuurlijkeGetallen : UserControl
    {
        public ucTweeNatuurlijkeGetallen()
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
            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

            if (getal1 == null || getal2 == null)
            {
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = getal1.Value; i <= getal2.Value; i++)
            {
                stringBuilder.Append(i + Environment.NewLine);
            }

            txtResultaat.Text =  stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            int getal1 = random.Next(1, 21);
            txtGetal1.Text = getal1.ToString();
            txtGetal2.Text = (random.Next(1, 21) + getal1).ToString();            
        }
    }
}