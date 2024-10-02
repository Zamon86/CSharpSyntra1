
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucAantalOmwentelingen.xaml
    /// </summary>
    public partial class ucAantalOmwentelingen : UserControl
    {
        public ucAantalOmwentelingen()
        {
            InitializeComponent();
        }

        private void btnVulDeWaardeUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtDiameter.Text = "16";
            txtAantalM.Text = "100";
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? diameter = Utils.ConvertTextBoxInputToDouble(txtDiameter);
            double? aantalM = Utils.ConvertTextBoxInputToDouble(txtAantalM);
            if (diameter != null && aantalM != null)
            {
                txtAantalOmwentelingen.Text = Math.Round(aantalM.Value / (((diameter.Value * Math.PI) / 100)), 4).ToString();                
            }

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtDiameter.Text = String.Empty;
            txtAantalM.Text = String.Empty;
            txtAantalOmwentelingen.Text = String.Empty;
        }

        

    }
}