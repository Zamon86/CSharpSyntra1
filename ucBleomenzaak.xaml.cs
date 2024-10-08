using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucWatKostMijnAugo.xaml
    /// </summary>
    public partial class ucBleomenzaak : UserControl
    {
        public ucBleomenzaak()
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
            double? bedragBloemen = Utils.ConvertTextBoxInputToDouble(txtBedragBloemen);            
            String plantType = txtPlantType.Text;
            

            if (bedragBloemen  == null) 
            { 
                return; 
            }

            if (bedragBloemen > 100)
            {
                txtTeBetalenBedrag.Text = Math.Round((bedragBloemen.Value * 0.9), 2).ToString("F2");
                txtHetGeschenk.Text = "Geen geschenk, 10% korting";
            }
            else
            {
                txtTeBetalenBedrag.Text = Math.Round(bedragBloemen.Value, 2).ToString("F2");

                if (bedragBloemen >= 40 && plantType.ToLower() == "snijbloemen")
                {
                    txtHetGeschenk.Text = "Vaste plant twv 2.5€";
                }
                else if (bedragBloemen >= 25 && plantType.ToUpper() == "VASTE PLANT")
                {
                    txtHetGeschenk.Text = "Lelie";
                }                
                else
                {
                    txtHetGeschenk.Text = "Geen geschenk";
                }  
            }           
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtBedragBloemen.Text = Math.Round((random.NextDouble() * (150 - 5) + 5), 2).ToString("F2");            
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
                txtPlantType.Text = ((ComboBoxItem)cboType.SelectedItem).Content.ToString();
            }            
        }
    }
}