
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucVerzekeringsPolis.xaml
    /// </summary>
    public partial class ucVerzekeringsPolis : UserControl
    {
        public ucVerzekeringsPolis()
        {
            InitializeComponent();
            listTB = new List<TextBox>();
            foreach (TextBox tb in MainGrid.Children.OfType<TextBox>())
            {
                listTB.Add(tb);
            }

        }

        public List<TextBox> listTB { get; private set; }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            String naam = txtNaam.Text;
            int? huidigeTrap = Utils.ConvertTextBoxInputToInteger(txtHuidigeTrap);
            int? maxTrap = Utils.ConvertTextBoxInputToInteger(txtMaxTrap);
            int? minTrap = Utils.ConvertTextBoxInputToInteger(txtMinTrap);
            int? aantalOngevallenDitJaar = Utils.ConvertTextBoxInputToInteger(txtAantalOngevallenDitJaar);
            int mijnNieuweTrap;

            if (huidigeTrap == null || maxTrap == null || minTrap == null || aantalOngevallenDitJaar == null)
            {
                return;
            }

            if (aantalOngevallenDitJaar == 0)
            {
                if (huidigeTrap > minTrap)
                {
                    mijnNieuweTrap = huidigeTrap.Value - 1;
                }
                else
                {
                    mijnNieuweTrap = huidigeTrap.Value;
                }

            } else if (aantalOngevallenDitJaar == 1) 
            {
                if (huidigeTrap >= maxTrap - 2)
                {
                    mijnNieuweTrap = maxTrap.Value;
                }
                else
                {
                    mijnNieuweTrap = huidigeTrap.Value + 2;
                }
            } else
            {
                if (huidigeTrap == maxTrap || huidigeTrap - 2 + (aantalOngevallenDitJaar - 1) * 3 > maxTrap)
                {
                    mijnNieuweTrap = maxTrap.Value;
                }
                else
                {
                    mijnNieuweTrap = huidigeTrap.Value - 2 + (aantalOngevallenDitJaar.Value - 1) * 3;
                }
            }

            txtMijnNieuweTrap.Text = mijnNieuweTrap.ToString();

        }



        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            foreach (TextBox tb in listTB)
            {
                tb.Text = String.Empty;
            }
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtNaam.Text = "Piotr";
            txtHuidigeTrap.Text = "10";
            txtMaxTrap.Text = "18";
            txtMinTrap.Text = "1";
            txtAantalOngevallenDitJaar.Text = "1";

        }
    }
}