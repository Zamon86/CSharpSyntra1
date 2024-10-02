
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucHetVerschil.xaml
    /// </summary>
    public partial class ucHetVerschil : UserControl
    {
        public ucHetVerschil()
        {
            InitializeComponent();

            listTb = [.. mainGrid.Children.OfType<TextBox>()];

        }

        public List<TextBox> listTb { get; private set; }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(100).ToString();
            txtGetal2.Text = random.Next(100).ToString();

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            foreach (TextBox tb in listTb)
            {
                tb.Text = String.Empty;
            }
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

            if (getal1.HasValue && getal2.HasValue)
            {
                txtResultaat.Text = Math.Abs(getal1.Value - getal2.Value).ToString();
            }

            
        }
    }
}