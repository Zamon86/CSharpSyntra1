using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for ucVariabelen.xaml
    /// </summary>
    public partial class ucVariabelen : UserControl
    {
        public ucVariabelen()
        {
            InitializeComponent();
        }      

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
            txtMinInt16.Text = String.Empty;
            txtMaxInt16.Text = String.Empty;
            txtMinInt32.Text = String.Empty;
            txtMaxInt32.Text = String.Empty;
            txtMinInt64.Text = String.Empty;
            txtMaxInt64.Text = String.Empty;
            txtMinByte.Text = String.Empty;
            txtMaxByte.Text = String.Empty;
            txtMinLong.Text = String.Empty;
            txtMaxLong.Text = String.Empty;
            txtMinDouble.Text = String.Empty;
            txtMaxDouble.Text = String.Empty;
            txtMinSingle.Text = String.Empty;
            txtMaxSingle.Text = String.Empty;
            txtMinDecimal.Text = String.Empty;
            txtMaxDecimal.Text = String.Empty;
            txtMinSByte.Text = String.Empty;
            txtMaxSByte.Text = String.Empty;
            txtMinShort.Text = String.Empty;
            txtMaxShort.Text = String.Empty;
            txtMinUShort.Text = String.Empty;
            txtMaxUShort.Text = String.Empty;
            txtMinUInt.Text = String.Empty;
            txtMaxUInt.Text = String.Empty;
            txtMinULong.Text = String.Empty;
            txtMaxULong.Text = String.Empty;
            txtMinFloat.Text = String.Empty;
            txtMaxFloat.Text = String.Empty;
        }
    }
}
