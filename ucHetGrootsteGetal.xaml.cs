using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucHetGrootsteGetal : UserControl
    {
        public ucHetGrootsteGetal()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];            
        }

        public List<TextBox> listTB { get; private set; }


        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rnd = new Random();

            foreach (TextBox tb in listTB)
            {
                if (tb.Name.Contains("txtGetal"))
                {
                    tb.Text = rnd.Next(-100000, 100001).ToString();
                }
            }
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            List<double> getalen = new List<double>();
            double maxValue;


            foreach (TextBox tb in listTB)
            {
                if (tb.Name.Contains("txtGetal"))
                {
                    double? getal = Utils.ConvertTextBoxInputToDouble(tb);
                    if (getal.HasValue) 
                    {
                        getalen.Add(getal.Value);
                    }
                    
                }
            }
            if (getalen.Count > 0)
            {
                maxValue = getalen.Max();
            }
            else
            {
                return;
            }              
            
            txtHetGrootsteGetal.Text = maxValue.ToString();
        }
    }
}