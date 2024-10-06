using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucDrieGetallenVergelijken.xaml
    /// </summary>
    public partial class ucDrieGetallen : UserControl
    {
        public ucDrieGetallen()
        {
            InitializeComponent();
            listTb = [.. mainGrid.Children.OfType<TextBox>()];            
        }

        public List<TextBox> listTb { get; private set; }


        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            try
            {
                int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
                int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);
                int? getal3 = Utils.ConvertTextBoxInputToInteger(txtGetal3);

                if (getal1 == null || getal2 == null || getal3 == null)
                {
                    return;
                }

                if ((getal1 + getal2) < 20)
                {
                    txtResultaat.Text = (getal1 + getal2 + getal3).ToString();
                }

                else
                {
                    txtResultaat.Text = "Te groot";
                }
            }

            catch (NullReferenceException ex1)
            {
                MessageBox.Show(ex1.Message);
            }


            catch (Exception ex2)
            {

                MessageBox.Show(ex2.Message);
            }

            finally
            {
                MessageBox.Show("KIEKEBOE");
            }  
        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTb);
        }        

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(20).ToString();
            txtGetal2.Text = random.Next(20).ToString();
            txtGetal3.Text = random.Next(50).ToString();            
        }
    }
}