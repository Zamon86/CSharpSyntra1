using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucExtra_Grootste : UserControl
    {
        public ucExtra_Grootste()
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
            Random random = new Random();
            int? maxGetal = Utils.ConvertTextBoxInputToInteger(txtMaxGetal);
            int? minGetal = Utils.ConvertTextBoxInputToInteger(txtMinGetal);
            int? aantalKeren = Utils.ConvertTextBoxInputToInteger(txtAantalkeren);
            

            if (maxGetal == null || minGetal == null || aantalKeren == null)
            {
                return;
            }

            int[] arrayGetallen = new int[aantalKeren.Value];

            for (int i = 0; i < aantalKeren; i++)
            {
                arrayGetallen[i] = random.Next(minGetal.Value, maxGetal.Value);
            }

            int[] uniekeGetallen = arrayGetallen.Distinct().ToArray();
            txtGrootste.Text = uniekeGetallen.Max().ToString();
            txtKleinste.Text = uniekeGetallen.Min().ToString();
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtMinGetal.Text = random.Next(1, 51).ToString();
            txtMaxGetal.Text = random.Next(100, 501).ToString();
            txtAantalkeren.Text = (random.Next(1, 6) * 10).ToString();                        
        }
    }
}