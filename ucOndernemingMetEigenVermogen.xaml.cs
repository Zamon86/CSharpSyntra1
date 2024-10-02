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
    /// Interaction logic for ucOndernemingMetEigenVermogen.xaml
    /// </summary>
    public partial class ucOndernemingMetEigenVermogen : UserControl
    {
        public ucOndernemingMetEigenVermogen()
        {
            InitializeComponent();
        }

        private void btnK1TotaalActief_Click(object sender, RoutedEventArgs e)
        {
            double? eigenVermogen = Utils.ConvertTextBoxInputToDouble(txtK1EigenVermogen);
            double? vreemdVermogen = Utils.ConvertTextBoxInputToDouble(txtK1VreemdVermogen);

            if (eigenVermogen == null || vreemdVermogen == null)
            {
                return;
            }

            txtK1TotaalActief.Text = (eigenVermogen + vreemdVermogen).ToString();

        }

        private void btnK2TotaalActief_Click(object sender, RoutedEventArgs e)
        {

            double? totaalActief = Utils.ConvertTextBoxInputToDouble(txtK2TotaalActief);
            double? vreemdVermogen = Utils.ConvertTextBoxInputToDouble(txtK2VreemdVermogen);

            if (totaalActief == null || vreemdVermogen == null)
            {
                return;
            }

            txtK2EigenVermogen.Text = (totaalActief - vreemdVermogen).ToString();

        }

        private void btnK3TeBetalenBTW_Click(object sender, RoutedEventArgs e)
        {
            double? aftrekbareBTW = Utils.ConvertTextBoxInputToDouble(txtK3AftrekbareBTW);
            double? verschuldigdeBTW = Utils.ConvertTextBoxInputToDouble(txtK3VerschuldigdeBTW);

            if (aftrekbareBTW == null || verschuldigdeBTW == null)
            {
                return;
            }

            txtK3TeBetalenBTW.Text = (verschuldigdeBTW - aftrekbareBTW).ToString();
        }

        private void btnK4TeBetalenBTW_Click(object sender, RoutedEventArgs e)
        {
            double? aftrekbareBTW = Utils.ConvertTextBoxInputToDouble(txtK4AftrekbareBTW);
            double? verschuldigdeBTW = Utils.ConvertTextBoxInputToDouble(txtK4VerschuldigdeBTW);
            double? voorschootBTW = Utils.ConvertTextBoxInputToDouble(txtK4VoorschotBTW);

            if (aftrekbareBTW == null || verschuldigdeBTW == null || voorschootBTW == null)
            {
                return;
            }

            txtK4TeBetalenBTW.Text = (verschuldigdeBTW - aftrekbareBTW - voorschootBTW).ToString();

        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

            List<string> textBoxNamesToClear = new List<string>
            {
                "txtK1EigenVermogen",
                "txtK1VreemdVermogen",
                "txtK1TotaalActief",
                "txtK2TotaalActief",
                "txtK2VreemdVermogen",
                "txtK2EigenVermogen",
                "txtK3AftrekbareBTW",
                "txtK3VerschuldigdeBTW",
                "txtK3TeBetalenBTW",
                "txtK4AftrekbareBTW",
                "txtK4VerschuldigdeBTW",
                "txtK4VoorschotBTW",
                "txtK4TeBetalenBTW"
            };

            foreach (var control in grdVermogen.Children)
            {
                if (control is TextBox textBox)
                {
                    if (textBoxNamesToClear.Contains(textBox.Name))
                    {
                        textBox.Text = String.Empty;
                    }
                }
            }
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, RoutedEventArgs e)
        {
            txtK1EigenVermogen.Text = "60000";
            txtK1VreemdVermogen.Text = "35000";
            txtK2TotaalActief.Text = "110000";
            txtK2VreemdVermogen.Text = "40000";
            txtK3AftrekbareBTW.Text = "1600";
            txtK3VerschuldigdeBTW.Text = "3200";
            txtK4AftrekbareBTW.Text = "1112,5";
            txtK4VerschuldigdeBTW.Text = "2437";
            txtK4VoorschotBTW.Text = "545";

        }        
    }
}
