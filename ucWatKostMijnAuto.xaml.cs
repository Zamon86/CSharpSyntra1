using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucWatKostMijnAugo.xaml
    /// </summary>
    public partial class ucWatKostMijnAuto : UserControl
    {
        public ucWatKostMijnAuto()
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
            double? aankoopPrijsAuto = Utils.ConvertTextBoxInputToDouble(txtAankoopPrijsAuto);
            double? btwPercentage = Utils.ConvertTextBoxInputToDouble(txtBTWPercentage);
            double? jaarlijkseVerkeersbelasting = Utils.ConvertTextBoxInputToDouble(txtJaarlijkseVerkeersbelasting);
            double? afschrijftermijn = Utils.ConvertTextBoxInputToDouble(txtAfschrijftermijn);
            double? aantalKmJ = Utils.ConvertTextBoxInputToDouble(txtAantalKmJ);
            double? prijsLiterDiesel = Utils.ConvertTextBoxInputToDouble(txtPrijsLiterDiesel);
            double? verbruik = Utils.ConvertTextBoxInputToDouble(txtVerbruik);
            double? onderhoud = Utils.ConvertTextBoxInputToDouble(txtOnderhoud);
            double? jaarlijkseVerzekering = Utils.ConvertTextBoxInputToDouble(txtJaarlijkseVerzekering);

            if (aankoopPrijsAuto == null || btwPercentage == null || jaarlijkseVerkeersbelasting == null ||
            afschrijftermijn == null || aantalKmJ == null || prijsLiterDiesel == null ||
            verbruik == null || onderhoud == null || jaarlijkseVerzekering == null)
            {
                return;
            }

            double vasteKosten = Math.Round((aankoopPrijsAuto.Value * (btwPercentage.Value + 100)) / 100, 2);
            txtVasteKosten.Text = vasteKosten.ToString("F2");

            double variabeleKosten = Math.Round((jaarlijkseVerkeersbelasting.Value + jaarlijkseVerzekering.Value + onderhoud.Value + (((aantalKmJ.Value * prijsLiterDiesel.Value * verbruik.Value / 100)))) * afschrijftermijn.Value, 2);
            txtVariabeleKosten.Text = variabeleKosten.ToString("F2");

            txtJaarlijkseKost.Text = Math.Round((variabeleKosten + vasteKosten) / afschrijftermijn.Value, 2).ToString("F2");

            txtTotaleKost.Text = (variabeleKosten + vasteKosten).ToString("F2");

        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtAankoopPrijsAuto.Text = (random.Next(15, 201) * 1000).ToString();
            txtBTWPercentage.Text = "21";
            txtJaarlijkseVerkeersbelasting.Text = (random.Next(25, 101) * 10).ToString();
            txtJaarlijkseVerzekering.Text = (random.Next(5, 26) * 100).ToString();
            txtAfschrijftermijn.Text = random.Next(5, 10).ToString();
            txtAantalKmJ.Text = (random.Next(15, 101) * 1000).ToString(); ;
            txtPrijsLiterDiesel.Text = Math.Round((random.NextDouble() * (2.3 - 1.5) + 1.5), 2).ToString("F2");
            txtVerbruik.Text = Math.Round((random.NextDouble() * (12 - 4) + 4), 1).ToString("F1");
            txtOnderhoud.Text = (random.Next(45, 201) * 10).ToString();
        }
    }
}