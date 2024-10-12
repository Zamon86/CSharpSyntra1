using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
   
    public partial class ucBiljartClub : UserControl
    {
        public ucBiljartClub()
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
            int Kandidaat1 = 0;
            int Kandidaat2 = 0;

            for (int i = 0; i < 123; i++) 
            {
                if (random.Next(2) == 1)
                {
                    Kandidaat1 += 1;
                }
                else
                {
                    Kandidaat2 += 1;
                }
            }

            txtAantal1.Text = Kandidaat1.ToString();
            txtAantal2.Text = Kandidaat2.ToString();
            

        }
    }
}