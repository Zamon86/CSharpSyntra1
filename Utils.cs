
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    public static class Utils    {
        

        public static double? ConvertTextBoxInputToDouble(TextBox tb)
        {
            double parsedDouble;
            String inputTrimmed;
            string input = tb.Text;

            List<string> symbols = new List<string>
            {
                "l/km",
                "€/l",
                "km",
                "€",
                "%",
                "cm",
                "m",
                "in",
                "°F",
                "°C",
                "j",
                "l"                
            };

            foreach (String symbol in symbols)
            {
                input = input.Replace(symbol, "");
            
            }
            
            inputTrimmed = input.Replace(".", ",").Trim();

            if (!double.TryParse(inputTrimmed, out parsedDouble))
            {
                MessageBox.Show("Ongeldig getal in veld: " + tb.Name);
                return null;
            }

            else
            {
                return parsedDouble;
            }
        }

        public static int? ConvertTextBoxInputToInteger(TextBox tb)
        {
            int parsedInt;

            if (!int.TryParse(tb.Text, out parsedInt))
            {
                MessageBox.Show("Ongeldig getal in veld: " + tb.Name);
                return null;
            }

            else
            {
                return parsedInt;
            }
        }

        public static void VerwijderenTextInTextBoxes(List<TextBox> listTB)
        {
            foreach (TextBox tb in listTB)
            {
                tb.Text = String.Empty;
            }
        }
    }


}
