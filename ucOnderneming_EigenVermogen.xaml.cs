using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucOnderneming_EigenVermogen : UserControl
    {
        public ucOnderneming_EigenVermogen()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> listTB { get; private set; }

        private void btnK1TotaalActief_Click(object sender, RoutedEventArgs e)
        {
            double? eigenVermogen = Utils.ConvertTextBoxInputToDouble(txtK1EigenVermogen);
            double? vreemdVermogen = Utils.ConvertTextBoxInputToDouble(txtK1VreemdVermogen);

            if (eigenVermogen == null || vreemdVermogen == null)
            {
                return;
            }

            txtK1TotaalActief.Text = (eigenVermogen + vreemdVermogen).ToString();

        }

        private void btnK2EigenVermogen_Click(object sender, RoutedEventArgs e)
        {

            double? totaalActief = Utils.ConvertTextBoxInputToDouble(txtK2TotaalActief);
            double? vreemdVermogen = Utils.ConvertTextBoxInputToDouble(txtK2VreemdVermogen);

            if (totaalActief == null || vreemdVermogen == null)
            {
                return;
            }

            txtK2EigenVermogen.Text = (totaalActief - vreemdVermogen).ToString();

        }

        private void btnK3TeBetalenBTW_Click(object sender, RoutedEventArgs e)
        {
            double? aftrekbareBTW = Utils.ConvertTextBoxInputToDouble(txtK3AftrekbareBTW);
            double? verschuldigdeBTW = Utils.ConvertTextBoxInputToDouble(txtK3VerschuldigdeBTW);

            if (aftrekbareBTW == null || verschuldigdeBTW == null)
            {
                return;
            }

            txtK3TeBetalenBTW.Text = (verschuldigdeBTW - aftrekbareBTW).ToString();
        }

        private void btnK4TeBetalenBTW_Click(object sender, RoutedEventArgs e)
        {
            double? aftrekbareBTW = Utils.ConvertTextBoxInputToDouble(txtK4AftrekbareBTW);
            double? verschuldigdeBTW = Utils.ConvertTextBoxInputToDouble(txtK4VerschuldigdeBTW);
            double? voorschootBTW = Utils.ConvertTextBoxInputToDouble(txtK4VoorschotBTW);

            if (aftrekbareBTW == null || verschuldigdeBTW == null || voorschootBTW == null)
            {
                return;
            }

            
            txtK4TeBetalenBTW.Text = (verschuldigdeBTW.Value - aftrekbareBTW.Value - voorschootBTW.Value).ToString("F2");
            

        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);            
        }        

        private void btnVulDeRandomWaardenIn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            txtK1EigenVermogen.Text = (random.Next(30, 100) * 1000).ToString();
            txtK1VreemdVermogen.Text = (random.Next(15, 50) * 1000).ToString();
            txtK2TotaalActief.Text = (random.Next(100, 150) * 1000).ToString();
            txtK2VreemdVermogen.Text = (random.Next(30, 60) * 1000).ToString();
            txtK3AftrekbareBTW.Text = (random.Next(10, 20) * 100).ToString();
            txtK3VerschuldigdeBTW.Text = (random.Next(25, 40) * 100).ToString(); ;
            txtK4AftrekbareBTW.Text = Math.Round((random.NextDouble() * (1500-1000) + 1000), 2).ToString("F2");
            txtK4VerschuldigdeBTW.Text = Math.Round((random.NextDouble() * (7500 - 2500) + 2500), 2).ToString("F2");
            txtK4VoorschotBTW.Text = Math.Round((random.NextDouble() * (1000 - 500) + 500), 2).ToString("F2");
        }
    }
}
