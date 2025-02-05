using System.Windows.Controls;

namespace LogikaOefening
{

    public partial class ucBiljartClub : UserControl
    {
        public ucBiljartClub()
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
            int kandidaat1 = 0;
            int kandidaat2 = 0;

            for (int i = 0; i < 123; i++) 
            {
                if (random.Next(2) == 1)
                {
                    kandidaat1 += 1;
                }
                else
                {
                    kandidaat2 += 1;
                }
            }

            txtAantal1.Text = kandidaat1.ToString();
            txtAantal2.Text = kandidaat2.ToString();           

        }
    }
}