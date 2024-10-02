using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucEenWillekeurigGetalvergelijken.xaml
    /// </summary>
    public partial class ucEenWillekeurigGetalvergelijken : UserControl
    {
        public ucEenWillekeurigGetalvergelijken()
        {
            InitializeComponent();
            listTb = new List<TextBox>();

            foreach (TextBox tb in mainGrid.Children.OfType<TextBox>())
            {
                listTb.Add(tb);
            }

        }

        public List<TextBox> listTb { get; private set; }


        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int? getal = Utils.ConvertTextBoxInputToInteger(txtGetal);

            if (getal == null)
            {
                return;
            }

            if (getal <= 5 && getal >= 0)
            {
                txtResultaat.Text = "Het getal ligt tussen 0-5";
            }
            else
            {
                txtResultaat.Text = "Het getal ligt NIET tussen 0-5";
            }

        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in listTb)
            {
                tb.Text = String.Empty;
            }
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal.Text = random.Next(25).ToString();
        }
    }
}
