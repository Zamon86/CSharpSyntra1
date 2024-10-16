using System.Windows.Controls;

namespace LogikaOefening
{
    
    public partial class ucGemiddelde : UserControl
    {
        public ucGemiddelde()
        {
            InitializeComponent();
            ListTB = [.. mainGrid.Children.OfType<TextBox>()];
        }
        public List<TextBox> ListTB { get; private set; }        

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(ListTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double? januari = Utils.ConvertTextBoxInputToDouble(txtJanuari);
            double? juli = Utils.ConvertTextBoxInputToDouble(txtJuli);
            double? december = Utils.ConvertTextBoxInputToDouble(txtDecember);

            if (januari == null || juli == null || december == null)
            {
                return;
            }

            txtGemiddelde.Text = Math.Round(((januari.Value + juli.Value + december.Value)/3), 2).ToString();
        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtJanuari.Text = (random.Next(90, 201) * 1000).ToString();
            txtJuli.Text = (random.Next(90, 201) * 1000).ToString();
            txtDecember.Text = (random.Next(90, 201) * 1000).ToString();
        }
    }
}