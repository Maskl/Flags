using System;
using System.Globalization;
using System.Windows.Data;

namespace Flags
{
    [ValueConversion(typeof(int), typeof(bool))]
    public class IntegerToBinaryFlagsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert for example '5' to 10000 (decimal 16).
            var mask = 1 << System.Convert.ToInt32(parameter);

            // Return true if value AND mask is not zero.
            return ((int)value & mask) != 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert for example '5' to 10000 (decimal 16).
            return 1 << System.Convert.ToInt32(parameter);
        }
    }
}
