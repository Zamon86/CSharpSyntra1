using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucVerzekeringsPolis : UserControl
    {
        public ucVerzekeringsPolis()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
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

            }
            else if (aantalOngevallenDitJaar == 1)
            {
                if (huidigeTrap >= maxTrap - 2)
                {
                    mijnNieuweTrap = maxTrap.Value;
                }
                else
                {
                    mijnNieuweTrap = huidigeTrap.Value + 2;
                }
            }
            else
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
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            int maxTrap = 18;
            int minTrap = 1;


            txtNaam.Text = "Piotr";
            txtHuidigeTrap.Text = random.Next(minTrap, maxTrap + 1).ToString();
            txtMaxTrap.Text = maxTrap.ToString();
            txtMinTrap.Text = minTrap.ToString();
            txtAantalOngevallenDitJaar.Text = GenerateAantalOngevallen().ToString();

        }

        static private int GenerateAantalOngevallen()
        {
            Random random = new Random();
            int randomValue = random.Next(1, 101);

            switch (randomValue)
            {
                case <= 60:
                    return 0;
                case <= 80:
                    return 1;
                case <= 90:
                    return 2;
                case <= 95:
                    return 3;
                case <= 96:
                    return 4;
                case <= 97:
                    return 5;
                case <= 98:
                    return 6;
                case <= 99:
                    return 7;
                case <= 100:
                    return 8;
                default:
                    return 0;

            }
        }
    }
}