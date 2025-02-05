using System.Windows.Controls;

namespace LogikaOefening
{

    public partial class ucSomVan5de10de15de : UserControl
    {
        public ucSomVan5de10de15de()
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
            int arraySize = random.Next(10, 30) / 5 * 5;
            int[] getallen = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                if (random.Next(2) == 1)
                {
                    getallen[i] = i + 1;
                }
                else
                {
                    getallen[i] = -(i + 1);
                }                
            }

            int som = 0;
            int somNegativeGetallen = 0;

            txtArray.Text = "{ " + string.Join(", ", getallen) + "}";

            for (int i = 0; i < getallen.Length; i++)
            {

                if ((i + 1) % 5 == 0)
                {
                    som += getallen[i];
                }

                if (getallen[i] < 0)
                {
                    somNegativeGetallen += getallen[i];
                }
            }

            txtResultaat.Text = "Som = " + som.ToString() + Environment.NewLine +
                "Som negatievegetallen = " + somNegativeGetallen.ToString();
        }
    }
}