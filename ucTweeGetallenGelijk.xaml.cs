using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucGetallenZijnGelijk.xaml
    /// </summary>
    public partial class ucTweeGetallenGelijk : UserControl
    {
        public ucTweeGetallenGelijk()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(10, 21).ToString();            

            if (random.NextDouble() >= 0.66)
            {
                txtGetal2.Text = txtGetal1.Text;
            }
            else
            {
                txtGetal2.Text = random.Next(0, 31).ToString();
            }      
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

            if (getal1 == null || getal2 == null)
            {
                return;
            }

            if (getal1 == getal2)
            {
                txtBoodschap.Text = "De twee getallen zijn gelijk";
            }
            else
            {
                txtBoodschap.Text = "De twee getallen zijn niet gelijk";
            }
        }
    }
}