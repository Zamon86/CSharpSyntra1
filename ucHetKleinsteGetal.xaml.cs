using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucHetKleinsteGetal : UserControl
    {
        public ucHetKleinsteGetal()
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
                    tb.Text = random.Next(100001).ToString();
                }
            }
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            foreach (TextBox tb in ListTB)
            {
                tb.Text = String.Empty;
            }
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            List<double> getalen = new List<double>();
            double minValue;

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
                minValue = getalen.Min();
            }
            else
            {
                return; 
            }

            txtHetKleinsteGetal.Text = minValue.ToString();
        }
    }
}