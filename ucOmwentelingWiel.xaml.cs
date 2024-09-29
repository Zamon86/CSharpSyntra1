
using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucOmwentelingWiel.xaml
    /// </summary>
    public partial class ucOmwentelingWiel : UserControl
    {
        public ucOmwentelingWiel()
        {
            InitializeComponent();
        }

        private void btnVulDeWaardeUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtDiameter.Text = "16";
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? diameter = Utils.ConvertStringInputToDouble(txtDiameter.Text, txtDiameter.Name);
            if (diameter != null)
            {
                txtOmwentelingInch.Text = Math.Round(((diameter.Value * Math.PI) / 2.54), 4).ToString();
                txtOmwentelingM.Text = Math.Round(((diameter.Value * Math.PI) / 100), 4).ToString();
            }

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtDiameter.Text = String.Empty;
            txtOmwentelingInch.Text = String.Empty;
            txtOmwentelingM.Text = String.Empty;
        }        
    }
}