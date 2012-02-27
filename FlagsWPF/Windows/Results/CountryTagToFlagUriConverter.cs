﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Flags
{
    [ValueConversion(typeof(string), typeof(string))]
    public class CountryTagToFlagUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format("/Media/Flags/100/{0}.png", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
