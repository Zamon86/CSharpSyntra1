using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucIngelezenEenheidsPrijs.xaml
    /// </summary>
    public partial class ucVreemdeMuntenOmzetten : UserControl
    {
        public ucVreemdeMuntenOmzetten()
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
            String vreemdeMunt = txtVreemdeMunt.Text;
            double? wisselkoers = Utils.ConvertTextBoxInputToDouble(txtWisselkores);
            int? aantalRegels = Utils.ConvertTextBoxInputToInteger(txtAantalRegels);

            if (aantalRegels == null || wisselkoers == null)
            {
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Format("\tEuro \t{0}" + Environment.NewLine, vreemdeMunt));

            string temp = String.Empty;
            for (int i = 1; i <= aantalRegels; i++)
            {
                temp = Math.Round((i * wisselkoers.Value), 4).ToString("F4");
                stringBuilder.Append(string.Format("\t{0} \t{1}" + Environment.NewLine, i, temp));
            }

            txtResultaat.Text = stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();

            string[] pln = { "PLN", "4,2424" };
            string[] bef = { "BEF", "40,3399" };
            string[] rub = { "RUB", "106,2424" };
            string[] cny = { "CNY", "7,7402" };

            string[][] vreemdeMunten = { pln, bef, rub, cny };

            int munt = random.Next(vreemdeMunten.Length);
            txtVreemdeMunt.Text = vreemdeMunten[munt][0];
            txtWisselkores.Text = vreemdeMunten[munt][1];
            txtAantalRegels.Text = (random.Next(10, 20) / 5 * 5).ToString();
        }
    }
}