
using System;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucControleRekeningNummer.xaml
    /// </summary>
    public partial class ucControleRekeningNummer : UserControl
    {
        public ucControleRekeningNummer()
        {
            InitializeComponent();

            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }

        public List<TextBox> listTB { get; private set; }


        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rnd = new Random();
            string group1 = string.Empty;
            string group2 = string.Empty; ;
            string group3 = string.Empty; ;

            if (rnd.Next(2) == 1)
            {
                MessageBox.Show("CorrectNUmber");
                int g3 = rnd.Next(1, 98);

                if (g3 < 10)
                {
                    group3 = "0" + g3;
                } else
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
            foreach (TextBox tb in listTB)
            {
                tb.Text = String.Empty;
            }
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}