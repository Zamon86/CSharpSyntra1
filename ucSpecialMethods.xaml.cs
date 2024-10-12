using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    public partial class ucSpecialMethods : UserControl
    {
        public ucSpecialMethods()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];        
        }

        public List<TextBox> listTB { get; private set; }
        

        private void btnVerwijderen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }

        private void btnBerekenen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();

            int getal1;
            int getal2;
            int mijnRefSom = 0;
            int mijnOutSom;


            if (txtGetal1.Text == String.Empty || txtGetal1.Text == null)
            {
                getal1 = random.Next(101);
                getal2 = random.Next(101);
            }
            else
            {
                int? getal1Nullable = Utils.ConvertTextBoxInputToInteger(txtGetal1);
                int? getal2Nullable = Utils.ConvertTextBoxInputToInteger(txtGetal2);

                if (getal1Nullable == null || getal2Nullable == null)
                {
                    return;
                }     
                
                getal1 = getal1Nullable.Value;
                getal2 = getal2Nullable.Value;
            }

            txtSom1.Text = string.Format("Som van getalen {0} en {1} is {2}.", getal1, getal2, Som(getal1, getal2));

            RefSom(getal1, getal2, ref mijnRefSom);
            txtSom2.Text = string.Format("Som van getalen {0} en {1} is {2}.", getal1, getal2, mijnRefSom);

            OutSom(getal1, getal2, out mijnOutSom);
            txtSom3.Text = string.Format("Som van getalen {0} en {1} is {2}.", getal1, getal2, mijnOutSom);

            int[] getallen = { getal1, getal2 };
            txtSom4.Text = string.Format("Som van getalen {0} en {1} is {2}.", getal1, getal2, SomArray(getallen)); 

        }

        private void btnVulDeWaardenIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random random = new Random();
            txtGetal1.Text = random.Next(101).ToString();
            txtGetal2.Text = random.Next(101).ToString();
        }

        private int Som()
        {

            int? getal1 = Utils.ConvertTextBoxInputToInteger(txtGetal1);
            int? getal2 = Utils.ConvertTextBoxInputToInteger(txtGetal2);

            if (getal1 == null ||getal2 == null)
            {
                MessageBox.Show("Onjuist input gegevens");
                return -1;
            }

            int som = getal1.Value + getal2.Value;
            return som; 
           
        }

        private int Som(int Getal1, int Getal2)
        {
            int som = Getal1 + Getal2;
            return som;            
        }

        private void RefSom(int Getal1, int Getal2, ref int Som)
        {
            Som = Getal1 + Getal2;
        }

        private void OutSom(int Getal1, int Getal2, out int Som)
        {
            Som = Getal1 + Getal2;
        }

        private int SomArray(int[] getallen)
        {
            return getallen.Sum();
        }

    }
}