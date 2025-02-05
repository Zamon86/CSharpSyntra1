using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    public partial class ucFunction : UserControl
    {
        public ucFunction()
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
            Random random = new Random();

            if (txtGetal1.Text == String.Empty || txtGetal1.Text == null)
            {
                int getal1 = random.Next(101);
                int getal2 = random.Next(101);
                int som = Som(getal1, getal2);
                txtSom.Text = string.Format("Som van getalen {0} en {1} is {2}.", getal1, getal2, som);

                int verschil = Verschil(getal1, getal2);
                txtVerschil.Text = string.Format("Verschil van getalen {0} en {1} is {2}.", getal1, getal2, verschil);
                
                (double delenResult, string delenText) = Delen(getal1);
                txtDelen.Text = delenText + delenResult + ".";

                int maal = Maal(getal1);
                txtMaal.Text = string.Format("{0} maal 2 is {1}.", getal1, maal);                
            }
            else
            {
                int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
                int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

                if (getal1 == null || getal2 == null)
                {
                    return;
                }

                txtSom.Text = Som().ToString();

                txtVerschil.Text = Verschil(getal1.Value, getal2.Value).ToString();

                (double delenResult, string delenText) = Delen(getal1.Value);
                txtDelen.Text = delenText + delenResult + ".";

                txtMaal.Text = Maal(getal1.Value, getal2.Value).ToString();                
            }
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(101).ToString();
            txtGetal2.Text = random.Next(101).ToString();
        }

        private int Som()
        {

            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

            if (getal1 == null ||getal2 == null)
            {
                MessageBox.Show("Onjuist input gegevens");
                return -1;
            }

            int som = getal1.Value + getal2.Value;
            return som; 
           
        }

        private int Som(int Getal1, int Getal2)
        {
            int som = Getal1 + Getal2;
            return som;            
        }

        private int Verschil(int getal1, int getal2)
        {
            return getal1 - getal2;              
        }

        private (double, string) Delen(int getal1)
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
                    MessageBox.Show("Onjuist input gegevens.");
                    return (-1, "Onjuist input gegevens. Code: ");
                }
            }

            if (getal2.Value == 0)
            {
                return (-1, "Kan niet delen door 0.");
            }
            else 
            {
                double delen = (double)getal1 / getal2.Value;
                return (Math.Round(delen, 2), string.Format("Delen van getal {0} door {1} is ", getal1, getal2));                
            } 
        }

        private int Maal(int getal1, int getal2 = 2)
        {
            return getal1 * getal2;  
        }
    }
}