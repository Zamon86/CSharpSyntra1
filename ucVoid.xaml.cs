using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
    public partial class ucVoid : UserControl
    {
        public ucVoid()
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

            if (txtGetal1.Text == String.Empty || txtGetal1.Text == null)
            {
                Som(random.Next(101), random.Next(101));
                Verschil(random.Next(101), random.Next(101), true);
                Delen(random.Next(101), true);
                Maal(random.Next(101), true);
            }
            else
            {
                int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
                int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

                if (getal1 == null || getal2 == null)
                {
                    return;
                }
                Som();
                Verschil(getal1.Value, getal2.Value, false);
                Delen(getal1.Value, false);
                Maal(getal1.Value, false, getal2.Value);
            }
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(101).ToString();
            txtGetal2.Text = random.Next(101).ToString();
        }

        private void Som()
        {

            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

            if (getal1 == null ||getal2 == null)
            {
                return;
            }

            int som = getal1.Value + getal2.Value;
            txtSom.Text = som.ToString(); 
        }

        private void Som(int Getal1, int Getal2)
        {
            int som = Getal1 + Getal2;
            txtSom.Text = string.Format("Som van getalen {0} en {1} is {2}.", Getal1, Getal2, som);
        }

        private void Verschil(int getal1, int getal2, bool isRandom)
        {
            int verschil = getal1 - getal2;
            if (isRandom)
            {
                txtVerschil.Text = string.Format("Verschil van getalen {0} en {1} is {2}.", getal1, getal2, verschil);
            }
            else
            {
                txtVerschil.Text = verschil.ToString();
            }
            
        }

        private void Delen(int getal1, bool isRandom)
        {

            int? getal2;

            if (txtGetal2.Text == null || txtGetal2.Text == string.Empty)
            {
                Random random = new Random();
                getal2 = random.Next(101);
                
            }
            else
            {
                getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);
                if (getal2 == null)
                {
                    return;
                }
            }

            if (getal2.Value == 0)
            {
                txtDelen.Text = "Kan niet delen door 0.";
            }
            else 
            {
                double delen = (double)getal1 / getal2.Value;
                txtDelen.Text = string.Format("Delen van getal {0} door {1} is {2}.", getal1, getal2, Math.Round(delen,2));
            } 
        }

        private void Maal(int getal1, bool isRandom, int getal2 = 2)
        {
            int maal = getal1 * getal2;
            if (isRandom)
            {
                txtMaal.Text = string.Format("{0} maal {1} is {2}.", getal1, getal2, maal);
            }
            else
            {
                txtMaal.Text = maal.ToString();
            }

        }
    }
}