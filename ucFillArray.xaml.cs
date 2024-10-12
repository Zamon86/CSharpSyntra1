using System.Text;
using System.Windows.Controls;

namespace LogikaOefening
{
    public partial class ucFillArray : UserControl
    {
        public ucFillArray()
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
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            txtHardcodeArray.Text = string.Join(", ", array1);

            int[] array2 = new int[6];
            array2[0] = 101;
            array2[1] = 102;
            array2[2] = 103;
            array2[3] = 104;
            array2[4] = 105;
            array2[5] = 106;
            txtFillingArray.Text = string.Join("-", array2);
            
            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = (i + 1) * 2;
            }
            txtFillingArrayWithLoop.Text = string.Join("|", array3);
            txtGetFifthElement.Text = array3[4].ToString();

            int[,] array4 = new int[3,2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] array5 = new string[2, 2] { {"Mike", "Amy" }, { "Mary", "Albert" } };
            int[,] array6 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            StringBuilder stringBuilder1 = new StringBuilder();

            for (int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    stringBuilder1.Append(array4[i, j] + "-");
                }
                stringBuilder1.Remove(stringBuilder1.Length - 1, 1);
                stringBuilder1.Append(Environment.NewLine);
            }

            txtFillingMDArray1.Text = stringBuilder1.ToString().TrimEnd(Environment.NewLine.ToCharArray());

            StringBuilder stringBuilder2 = new StringBuilder();

            for (int i = 0; i < array5.GetLength(0); i++)
            {
                for (int j = 0; j < array5.GetLength(1); j++)
                {
                    stringBuilder2.Append(array5[i, j] + "-");
                }
                stringBuilder2.Remove(stringBuilder2.Length - 1, 1);
                stringBuilder2.Append(Environment.NewLine);
            }

            txtFillingMDArray2.Text = stringBuilder2.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}