using System.Windows.Controls;

namespace LogikaOefening
{
    class TextBoxWithSymbol : TextBox
    {
        private bool _isSettingTextToEmptyString = false;
        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);

            if (_isSettingTextToEmptyString)
            {
                return;
            }

            string? symbol = this.Tag?.ToString();
            if (this.Text == " " + symbol)
            {
                _isSettingTextToEmptyString = true;
                this.Text = String.Empty;
                _isSettingTextToEmptyString = false;
            }

            else if (!String.IsNullOrEmpty(symbol) && this.Text != String.Empty)
            {                
                string currentText = this.Text.Replace(symbol, "").Replace(" ","").Trim();
                this.Text = currentText + " " + symbol;
                this.SelectionStart = this.Text.Length - (symbol.Length + 1);
            }
        }
    }
}
