using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
 
    public partial class ucVariabelen : UserControl
    {
        public ucVariabelen()
        {
            InitializeComponent();
            listTB = [.. mainGrid.Children.OfType<TextBox>()];
        }      

        public List<TextBox> listTB { get; private set; }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            txtMinInt16.Text = Int16.MinValue.ToString();
            txtMaxInt16.Text = Int16.MaxValue.ToString();
            txtMinInt32.Text = Int32.MinValue.ToString();
            txtMaxInt32.Text = Int32.MaxValue.ToString();
            txtMinInt64.Text = Int64.MinValue.ToString();
            txtMaxInt64.Text = Int64.MaxValue.ToString();
            txtMinByte.Text = byte.MinValue.ToString();
            txtMaxByte.Text = byte.MaxValue.ToString();
            txtMinLong.Text = long.MinValue.ToString();
            txtMaxLong.Text = long.MaxValue.ToString();
            txtMinDouble.Text = double.MinValue.ToString();
            txtMaxDouble.Text = double.MaxValue.ToString();
            txtMinSingle.Text = Single.MinValue.ToString();
            txtMaxSingle.Text = Single.MaxValue.ToString();
            txtMinDecimal.Text = decimal.MinValue.ToString();
            txtMaxDecimal.Text = decimal.MaxValue.ToString();
            txtMinSByte.Text = sbyte.MinValue.ToString();
            txtMaxSByte.Text = sbyte.MaxValue.ToString();
            txtMinShort.Text = short.MinValue.ToString();
            txtMaxShort.Text = short.MaxValue.ToString();
            txtMinUShort.Text = ushort.MinValue.ToString();
            txtMaxUShort.Text = ushort.MaxValue.ToString();
            txtMinUInt.Text = uint.MinValue.ToString();
            txtMaxUInt.Text = uint.MaxValue.ToString();
            txtMinULong.Text = ulong.MinValue.ToString();
            txtMaxULong.Text = ulong.MaxValue.ToString();
            txtMinFloat.Text = float.MinValue.ToString();
            txtMaxFloat.Text = float.MaxValue.ToString();
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            Utils.VerwijderenTextInTextBoxes(listTB);
        }
    }
}
