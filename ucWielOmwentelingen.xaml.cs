using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucOmwentelingWiel.xaml
    /// </summary>
    public partial class ucWielOmwentelingen : UserControl
    {
        public ucWielOmwentelingen()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? diameter = Utils.ConvertTextBoxInputToDouble(txtDiameter);
            if (diameter != null)
            {
                txtOmwentelingInch.Text = Math.Round(((diameter.Value * Math.PI) / 2.54), 4).ToString();
                txtOmwentelingM.Text = Math.Round(((diameter.Value * Math.PI) / 100), 4).ToString();
            }
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnVulDeWaardeIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtDiameter.Text = random.Next(10, 51).ToString();
        }
    }
}