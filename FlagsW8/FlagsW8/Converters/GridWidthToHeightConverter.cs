using System;
using Windows.UI.Xaml.Data;

namespace FlagsW8.Converters
{
    public sealed class GridToHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (int)value * 62 / 122;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return (int)value * 122 / 62;
        }
    }
}
