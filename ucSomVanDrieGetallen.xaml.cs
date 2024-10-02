using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for ucSomVanDrieGetallen.xaml
    /// </summary>
    public partial class ucSomVanDrieGetallen : UserControl
    {
        public ucSomVanDrieGetallen()
        {
            InitializeComponent();
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);
            int? getal3 = Utils.ConvertTextBoxInputToInteger(txtGetal3);

            if (getal1 == null || getal2 == null || getal3 == null)
            {               
                return;
            }

            try
            {
                int som = checked((int)getal1 + (int)getal2 + (int)getal3);
                txtSom.Text = som.ToString();
            }
            catch (OverflowException)
            {
                MessageBox.Show("De som van de getallen is groter dan de maximale int32-waarde en veroorzaakt een overflow!");
                return;
            } 

        }        

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            txtGetal1.Text = String.Empty;
            txtGetal2.Text = String.Empty;
            txtGetal3.Text = String.Empty;
            txtSom.Text= String.Empty;
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, RoutedEventArgs e)
        {
            txtGetal1.Text = "10";
            txtGetal2.Text = "20";
            txtGetal3.Text = "30";

        }
        
    }
}
