
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucHetKleinsteGetal.xaml
    /// </summary>
    public partial class ucHetKleinsteGetal : UserControl
    {
        public ucHetKleinsteGetal()
        {
            InitializeComponent();
            listTB = new List<TextBox>();
            foreach (TextBox tb in MainGrid.Children.OfType<TextBox>())
            {
                listTB.Add(tb);
            }
        }

        public List<TextBox> listTB { get; private set; }


        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rnd = new Random();

            foreach (TextBox tb in listTB)
            {
                if (tb.Name.Contains("txtGetal"))
                {
                    tb.Text = rnd.Next(-100000, 100000).ToString();
                }
            }
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
            List<double> getalen = new List<double>();
            double minValue;


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