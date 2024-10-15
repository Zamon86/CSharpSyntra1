using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
   
    public partial class ucPrognoseVerkoop : UserControl
    {
        public ucPrognoseVerkoop()
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
            int? jaartal = Utils.ConvertTextBoxInputToInteger(txtJaartal);
            int? aantalJaren = Utils.ConvertTextBoxInputToInteger(txtAantalJaren);
            double? groei = Utils.ConvertTextBoxInputToDouble(txtGroei);
            double? omzet = Utils.ConvertTextBoxInputToDouble(txtOmzet);

            if (jaartal == null || aantalJaren == null || groei == null || omzet == null) 
            {
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();
            double tussenTijdseOmzet = omzet.Value;
            double tussenTijdseOmzetgroei = 0;

            for (int i = 1; i <= aantalJaren; i++)
            {
                tussenTijdseOmzetgroei = tussenTijdseOmzet * (groei.Value / 100d + 1) - tussenTijdseOmzet;
                tussenTijdseOmzet = tussenTijdseOmzet * (groei.Value / 100d + 1);
                stringBuilder.Append(string.Format("De omzetgroei voor {0} bedraagt {1} €.{2}", jaartal + i, tussenTijdseOmzetgroei.ToString("F2"), Environment.NewLine));
            }

            txtResultaat.Text = stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());            
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtJaartal.Text = DateTime.Today.Year.ToString();
            txtOmzet.Text = (random.Next(10,51) * 1000).ToString();
            txtGroei.Text = Math.Round((random.NextDouble() * (20 - 10) + 10), 1).ToString("F1");
            txtAantalJaren.Text = random.Next(5,11).ToString();
        }
    }
}