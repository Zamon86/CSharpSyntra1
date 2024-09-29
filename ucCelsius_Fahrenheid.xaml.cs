
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucCelsius_Fahrenheid.xaml
    /// </summary>
    public partial class ucCelsius_Fahrenheid : UserControl
    {
        public ucCelsius_Fahrenheid()
        {
            InitializeComponent();
        }

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtCelsius.Text = "25";
            txtFahrenheid.Text = "80";            
        }
        

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtCelsius.Text = String.Empty;
            txtFahrenheid.Text = String.Empty;
            txtOmzettingNaarCelsius.Text = String.Empty;
            txtOmzettingNaarFahrenheid.Text = String.Empty;            
        }

        private void btnBerekenenCF_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? celsius = Utils.ConvertStringInputToDouble(txtCelsius.Text, txtCelsius.Name);
            
            if (celsius != null)
            {
                txtOmzettingNaarFahrenheid.Text = Math.Round(celsius.Value * 9 / 5 + 32, 1).ToString();                
            }
        }

        private void btnBerekenenFC_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? fahrenheid = Utils.ConvertStringInputToDouble(txtFahrenheid.Text, txtFahrenheid.Name);

            if (fahrenheid != null)
            {
                txtOmzettingNaarCelsius.Text = Math.Round((fahrenheid.Value - 32) * 5 / 9, 1).ToString();
            }
        }
    }
}