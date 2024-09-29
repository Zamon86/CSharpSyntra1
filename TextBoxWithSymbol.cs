using System;
using System.Windows.Controls;

namespace LogikaOefening
{
    class TextBoxWithSymbol : TextBox
    {
        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);

            string? symbol = this.Tag?.ToString();
            if (!String.IsNullOrEmpty(symbol))
            {                
                string currentText = this.Text.Replace(symbol, "").Replace(" ","").Trim();
                this.Text = currentText + " " + symbol;
                this.SelectionStart = this.Text.Length - (symbol.Length + 1);
            }
        }
    }
}
