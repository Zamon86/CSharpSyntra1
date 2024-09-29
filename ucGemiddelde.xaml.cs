
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucGemiddelde.xaml
    /// </summary>
    public partial class ucGemiddelde : UserControl
    {
        public ucGemiddelde()
        {
            InitializeComponent();
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtJanuari.Text = "110000";
            txtJuli.Text = "115000";
            txtDecember.Text = "100000";
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtJanuari.Text = String.Empty;
            txtJuli.Text = String.Empty;
            txtDecember.Text = String.Empty;
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? januari = Utils.ConvertStringInputToDouble(txtJanuari.Text, txtJanuari.Name);
            double? juli = Utils.ConvertStringInputToDouble(txtJuli.Text, txtJuli.Name);
            double? december = Utils.ConvertStringInputToDouble(txtDecember.Text, txtDecember.Name);

            if (januari == null || juli == null || december == null)
            {
                return;
            }

            txtGemiddelde.Text = Math.Round(((januari.Value + juli.Value + december.Value)/3), 2).ToString();

        }
    }
}