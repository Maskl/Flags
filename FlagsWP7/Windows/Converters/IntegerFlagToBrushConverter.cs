using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Flags
{
    //[ValueConversion(typeof(int), typeof(float))]
    public class IntegerFlagToBrushConverter : IValueConverter
    {
        public Brush FalseValue { get; set; }
        public Brush TrueValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert for example '5' to 10000 (decimal 16).
            var mask = 1 << System.Convert.ToInt32(parameter);

            // Return true if value AND mask is not zero.
            return ((int)value & mask) != 0 ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert for example '5' to 10000 (decimal 16).
            return 1 << System.Convert.ToInt32(parameter);
        }
    }
}
