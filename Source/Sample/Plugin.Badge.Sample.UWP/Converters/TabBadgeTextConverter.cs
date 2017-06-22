using Plugin.Badge.Abstractions;
using System;
using Xamarin.Forms;
using UI = Windows.UI;

namespace Plugin.Badge.Sample.UWP.Converters
{
    public class TabBadgeTextConverter : UI.Xaml.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Page)
            {
                var badgeText = TabBadge.GetBadgeText((Page)value);

                return badgeText;
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}