using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
 
    public partial class ucGemiddeldeVerbruik : UserControl
    {
        public ucGemiddeldeVerbruik()
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
            int somLiters = 0;
            int somKm = 0;

            string[] aantalLiters = txtAantalLiters.Text.Split(", ");
            string[] aantalKm = txtAantalKm.Text.Split(", ");

            for (int i = 0; i < aantalLiters.Length; i++)
            {
                somLiters += int.Parse(aantalLiters[i]);
            }

            for (int i = 0; i < aantalKm.Length; i++)
            {
                somKm += int.Parse(aantalKm[i]);
            }

            if (aantalLiters.Length != aantalKm.Length)
            {
                MessageBox.Show("Gegevens zijn onjuist");
                return;
            }

            txtGemiddeldeVerbruik.Text = Math.Round((somLiters * 100d / somKm), 2).ToString();

        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StringBuilder aantalLiters = new StringBuilder();
            StringBuilder aantalKm = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                aantalLiters.Append(random.Next(20, 26).ToString() + ", ");
                aantalKm.Append(random.Next(400, 701).ToString() + ", ");
            }

            txtAantalKm.Text = aantalKm.ToString().TrimEnd(',', ' ');
            txtAantalLiters.Text = aantalLiters.ToString().TrimEnd(',', ' ');
        }
    }
}