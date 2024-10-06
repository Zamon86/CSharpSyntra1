using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucSomVanDrieGetallen.xaml
    /// </summary>
    public partial class ucSomVanDrieGetallen : UserControl
    {
        public ucSomVanDrieGetallen()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);
            int? getal3 = Utils.ConvertTextBoxInputToInteger(txtGetal3);

            if (getal1 == null || getal2 == null || getal3 == null)
            {               
                return;
            }

            try
            {
                int som = checked(getal1.Value + getal2.Value + getal3.Value);
                txtSom.Text = som.ToString();
            }
            catch (OverflowException)
            {
                MessageBox.Show("De som van de getallen is groter dan de maximale int32-waarde en veroorzaakt een overflow!");
                return;
            } 

        }        

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }        

        private void btnVulDeRandomWaardenIn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(100).ToString();
            txtGetal2.Text = random.Next(100).ToString();
            txtGetal3.Text = random.Next(100).ToString();
        }
    }
}
