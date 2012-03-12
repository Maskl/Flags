﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Flags
{
    public class CountryTagToFlagUriConverter100 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format("/FlagsWP7;component/Media/Flags/100/{0}.png", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
