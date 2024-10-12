using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucAantalOmwentelingen : UserControl
    {
        public ucAantalOmwentelingen()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }        

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
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtDiameter.Text = random.Next(10, 51).ToString();
            txtAantalM.Text = random.Next(50, 101).ToString();
        }
    }
}