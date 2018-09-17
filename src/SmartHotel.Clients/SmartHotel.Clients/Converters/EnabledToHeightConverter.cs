﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace SmartHotel.Clients.Core.Converters
{
    public class EnabledToHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                var isEnabled = (bool)value;

                return isEnabled ? (TargetIdiom.TV == Device.Idiom ? 120 : 60) : 0;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}