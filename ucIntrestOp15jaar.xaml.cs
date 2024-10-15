using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
 
    public partial class ucIntrestOp15jaar : UserControl
    {
        public ucIntrestOp15jaar()
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
            double? beginKapitaal = Utils.ConvertTextBoxInputToDouble(txtBeginKapitaal);
            int? aantalJaren = Utils.ConvertTextBoxInputToInteger(txtAantalJaren);
            double? vasteRentevoet = Utils.ConvertTextBoxInputToDouble(txtVasteRentevoet);

            if (beginKapitaal == null || aantalJaren == null || vasteRentevoet == null)
            {
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();


            double huidigKapitaal = beginKapitaal.Value;

            for (int i = 1; i <= aantalJaren; i++) 
            {
                huidigKapitaal += vasteRentevoet.Value / 100 * huidigKapitaal;
                stringBuilder.Append(i + " jaar\t" + huidigKapitaal.ToString("F2") + " €\t" + "Rente: (" + (huidigKapitaal - beginKapitaal).Value.ToString("F2") + "€)" + Environment.NewLine);
            }

            txtResultaat.Text = stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtBeginKapitaal.Text = (random.Next(10, 101) * 1000).ToString();
            txtAantalJaren.Text = (random.Next(5, 21) / 5 * 5).ToString();
            txtVasteRentevoet.Text = Math.Round((random.NextDouble() * (3 - 1) + 1), 2).ToString("F2");
            
        }
    }
}