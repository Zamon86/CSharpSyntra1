using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucControleRekeningNummer : UserControl
    {
        public ucControleRekeningNummer()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }

        public List<TextBox> listTB { get; private set; }


        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rnd = new Random();
            string group1 = string.Empty;
            string group2 = string.Empty;
            string group3 = string.Empty;

            if (rnd.Next(2) == 1)            
            {                
                int g3 = rnd.Next(1, 98);

                if (g3 < 10)
                {
                    group3 = "0" + g3;
                } 
                else
                {
                    group3 = g3.ToString();
                }

                int maxMultiplicator = 10309278;
                int minMultiplicator = 2062;

                long basis = rnd.Next(minMultiplicator, maxMultiplicator) * 97;
                long basisMetRest = g3 == 97 ? basis : (basis + g3);
                string group23 = basisMetRest.ToString();

                while (group23.Length < 10)
                {
                    group23 = "0" + group23;
                }
                    
                group1 = group23.Substring(0, 3);
                group2 = group23.Substring(3, 7);
            }
            else 
            {
                for (int i = 0; i < 3; i++) 
                {
                    group1 = group1 + rnd.Next(10).ToString();                       
                }

                for (int i = 0; i < 7; i++)
                {
                    group2 = group2 + rnd.Next(10).ToString();
                }

                for (int i = 0; i < 2; i++)
                {
                    group3 = group3 + rnd.Next(10).ToString();
                }

            }

            txtGetal1.Text = group1;
            txtGetal2.Text = group2;
            txtGetal3.Text = group3;

            txtRekeningnummer.Text = group1 + "-" + group2 + "-" + group3;
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string group12 = txtGetal1.Text + txtGetal2.Text;            
            string group3 = txtGetal3.Text;
            long group12int = long.Parse(group12);
            int restDeling = (int)(group12int % 97);

            if (restDeling == 0)
            {
                restDeling = 97;
            }

            if (Int32.Parse(group3) == restDeling)
            {
                txtResultaat.Text = "Rekeningnummer is juist";
            }
            else
            {
                txtResultaat.Text = "Rekeningnummer is niet juist";
            }
        }
    }
}