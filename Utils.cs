
using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    public static class Utils    {
        

        public static double? ConvertStringInputToDouble(String input, String nameOfTxtField)
        {
            double parsedDouble;
            String inputTrimmed;

            List<string> symbols = new List<string>
            {
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
                MessageBox.Show("Ongeldig getal in veld: " + nameOfTxtField);
                return null;
            }

            else
            {
                return parsedDouble;
            }
        }

        public static int? ConvertStringInputToInteger(String input, String nameOfTxtField)
        {
            int parsedInt;

            if (!int.TryParse(input, out parsedInt))
            {
                MessageBox.Show("Ongeldig getal in veld: " + nameOfTxtField);
                return null;
            }

            else
            {
                return parsedInt;
            }
        }
    }


}
