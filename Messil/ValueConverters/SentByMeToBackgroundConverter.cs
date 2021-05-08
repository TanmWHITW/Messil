using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Messil
{
    /// <summary>
    /// A converter that takes in a boolean if a message was sent by me, and returns the
    /// correct background color
    /// </summary>
    public class SentByMeToBackgroundConverter : BaseValueConverter<SentByMeToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Application.Current.FindResource("BackgroundLightBlueBrush") : Application.Current.FindResource("BackgroundGray300Brush");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}