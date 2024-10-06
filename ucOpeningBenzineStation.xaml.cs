using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucWatKostMijnAugo.xaml
    /// </summary>
    public partial class ucOpeningBenzineStation : UserControl
    {
        public ucOpeningBenzineStation()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];            
        }
        public List<TextBox> listTB { get; private set; }        

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            cboType.SelectedIndex = -1;
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? benzinePrijs = Utils.ConvertTextBoxInputToDouble(txtBenzinePrijs);
            double? dieselPrijs = Utils.ConvertTextBoxInputToDouble(txtDieselPrijs);
            double? plafond = Utils.ConvertTextBoxInputToDouble(txtPlafond);
            double? aantalLiters = Utils.ConvertTextBoxInputToDouble(txtAantalLiters);
            String brandstofType = txtBrandstofType.Text;
            double kostPrijs;

            if (benzinePrijs == null || dieselPrijs == null || plafond == null || aantalLiters == null) 
            { 
                return; 
            }

            if (brandstofType.ToLower() == "benzine")
            {
                kostPrijs = (benzinePrijs.Value * aantalLiters.Value);
            }
            else if (brandstofType.ToUpper() == "DIESEL")
            {
                kostPrijs = (dieselPrijs.Value * aantalLiters.Value);
            }
            else 
            { 
                MessageBox.Show("U moet nog een type selecteren in de ComboBox");
                return;
            }

            if (kostPrijs >= plafond)
            {
                txtGeschenk.Text = "U krijgt een geschenk";
            }

            else
            {
                txtGeschenk.Text = string.Format("U moet minstens {0} euro tanken om een geschenk te krijgen", plafond);
            }

            txtKostPrijs.Text = (Math.Ceiling(kostPrijs * 100) / 100).ToString("F2");
            txtAantalZegels.Text = Math.Truncate(aantalLiters.Value * 2).ToString();
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtBenzinePrijs.Text = Math.Round((random.NextDouble() * (2 - 1.5) + 1.5), 2).ToString("F2");
            txtDieselPrijs.Text = Math.Round((random.NextDouble() * (1.8 - 1.3) + 1.3), 2).ToString("F2");
            txtAantalLiters.Text = Math.Round((random.NextDouble() * (80 - 10) + 10), 1).ToString("F1");
            txtPlafond.Text = (random.Next(20, 50) / 5 * 5).ToString();
            if (random.Next(2) == 0)
            {
                cboType.SelectedIndex = 0;
            } else
            {
                cboType.SelectedIndex = 1;
            }            
        }

        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboType.SelectedIndex != -1) 
            {
                txtBrandstofType.Text = ((ComboBoxItem)cboType.SelectedItem).Content.ToString();
            }            
        }
    }
}