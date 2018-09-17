using SmartHotel.Clients.Core.Models;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace SmartHotel.Clients.Core.Converters
{
    public class NotificationTypeToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is NotificationType)
            {
                var notificationType = (NotificationType)value;

                switch(notificationType)
                {
                    case NotificationType.BeGreen:
                        if (Device.RuntimePlatform == Device.Tizen)
                            return string.Format("ic_be_green{0}.png", parameter ?? string.Empty);
                        else if (Device.RuntimePlatform == Device.UWP)
                            return string.Format("Assets/ic_be_green{0}.png", parameter ?? string.Empty);
                        else 
                            return string.Format("ic_be_green{0}.png", parameter ?? string.Empty);
                    case NotificationType.Hotel:
                        if (Device.RuntimePlatform == Device.Tizen)
                            return string.Format("ic_hotel{0}.png", parameter ?? string.Empty);
                        else if (Device.RuntimePlatform == Device.UWP)
                            return string.Format("Assets/ic_hotel{0}.png", parameter ?? string.Empty);
                        else
                            return string.Format("ic_hotel{0}.png", parameter ?? string.Empty);
                    case NotificationType.Room:
                        if (Device.RuntimePlatform == Device.Tizen)
                            return string.Format("ic_room{0}.png", parameter ?? string.Empty);
                        else if (Device.RuntimePlatform == Device.UWP)
                            return string.Format("Assets/ic_room{0}.png", parameter ?? string.Empty);
                        else
                            return string.Format("ic_room{0}.png", parameter ?? string.Empty);
                    case NotificationType.Other:
                        if (Device.RuntimePlatform == Device.Tizen)
                            return string.Format("ic_others{0}.png", parameter ?? string.Empty);
                        else if (Device.RuntimePlatform == Device.UWP)
                            return string.Format("Assets/ic_others{0}.png", parameter ?? string.Empty);
                        else
                            return string.Format("ic_others{0}.png", parameter ?? string.Empty);
                }
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}