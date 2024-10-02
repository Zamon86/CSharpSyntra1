
using System;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucDrieGetallenVergelijken.xaml
    /// </summary>
    public partial class ucDrieGetallenVergelijken : UserControl
    {
        public ucDrieGetallenVergelijken()
        {
            InitializeComponent();

            listTb = new List<TextBox> ();

            foreach (TextBox tb in mainGrid.Children.OfType<TextBox>()) {
                listTb.Add(tb);
            }
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
                MessageBox.Show("kiekeboe");
            }
            

        }

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            foreach (TextBox tb in listTb) 
            {
                tb.Text = string.Empty;
            }
        }

        

        private void btnVulDeWaardenUitDeOefeningIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(20).ToString();
            txtGetal2.Text = random.Next(20).ToString();
            txtGetal3.Text = random.Next(50).ToString();
            
        }
    }
}