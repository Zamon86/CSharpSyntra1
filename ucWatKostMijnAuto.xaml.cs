
using System;
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
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtAankoopPrijsAuto.Text = "25000";
            txtBTWPercentage.Text = "21";
            txtJaarlijkseVerkeersbelasting.Text = "500";
            txtJaarlijkseVerzekering.Text = "1200";
            txtAfschrijftermijn.Text = "8";
            txtAantalKmJ.Text = "30000";
            txtPrijsLiterDiesel.Text = "1,5";
            txtVerbruik.Text = "7,5";
            txtOnderhoud.Text = "450";
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtAankoopPrijsAuto.Text = String.Empty;
            txtBTWPercentage.Text = String.Empty;
            txtJaarlijkseVerkeersbelasting.Text = String.Empty;
            txtAfschrijftermijn.Text = String.Empty;
            txtAantalKmJ.Text = String.Empty;
            txtPrijsLiterDiesel.Text = String.Empty;
            txtVerbruik.Text = String.Empty;
            txtOnderhoud.Text = String.Empty;
            txtVasteKosten.Text = String.Empty;
            txtVariabeleKosten.Text = String.Empty;
            txtJaarlijkseKost.Text = String.Empty;
            txtTotaleKost.Text = String.Empty;
            txtJaarlijkseVerzekering.Text = String.Empty;
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
    }
}