using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucOpeningBenzineStation2 : UserControl
    {
        public ucOpeningBenzineStation2()
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
            double? bedragSneop = Utils.ConvertTextBoxInputToDouble(txtBedragSnoep);
            String brandstofType = txtBrandstofType.Text;
            double kostPrijs;

            if (benzinePrijs == null || dieselPrijs == null || plafond == null || aantalLiters == null || bedragSneop == null) 
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
                txtGeschenk.Text = "U krijgt een Sleutelhanger";
                txtAantalZegels.Text = (Math.Truncate(aantalLiters.Value) * 2).ToString();
            }

            else
            {
                txtGeschenk.Text = "U krijgt een Geschenk";
                txtAantalZegels.Text = Math.Truncate(aantalLiters.Value).ToString();
            }

            if (bedragSneop > 5)
            {
                txtRoos.Text = "U krijgt een Roos";
            }
            else 
            {
                txtRoos.Text = "U krijgt GEEN Roos";
            }

            txtKostPrijs.Text = (Math.Ceiling(kostPrijs * 100) / 100).ToString("F2");            
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtBenzinePrijs.Text = Math.Round((random.NextDouble() * (2 - 1.5) + 1.5), 2).ToString("F2");
            txtDieselPrijs.Text = Math.Round((random.NextDouble() * (1.8 - 1.3) + 1.3), 2).ToString("F2");
            txtAantalLiters.Text = Math.Round((random.NextDouble() * (80 - 10) + 10), 1).ToString("F1");
            txtPlafond.Text = (random.Next(35, 45) / 5 * 5).ToString();
            if (random.Next(2) == 0)
            {
                cboType.SelectedIndex = 0;
            } else
            {
                cboType.SelectedIndex = 1;
            }
            if (random.Next(3) == 0)
            {
                txtBedragSnoep.Text = Math.Round((random.NextDouble() * (10 - 2.5) + 2.5), 2).ToString("F2");
            }
            else
            {
                txtBedragSnoep.Text = "0,00";
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