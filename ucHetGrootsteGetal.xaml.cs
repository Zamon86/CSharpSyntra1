using System.Windows.Controls;

namespace LogikaOefening
{
  
    public partial class ucHetGrootsteGetal : UserControl
    {
        public ucHetGrootsteGetal()
        {
            InitializeComponent();
            ListTB = [.. mainGrid.Children.OfType<TextBox>()];            
        }

        public List<TextBox> ListTB { get; private set; }


        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();

            foreach (TextBox tb in ListTB)
            {
                if (tb.Name.Contains("txtGetal"))
                {
                    tb.Text = random.Next(-100000, 100001).ToString();
                }
            }
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(ListTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            List<double> getalen = new List<double>();
            double maxValue;


            foreach (TextBox tb in ListTB)
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