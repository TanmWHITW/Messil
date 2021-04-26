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
    public class IsSelectedToBorderBrushConverter : BaseValueConverter<IsSelectedToBorderBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Application.Current.FindResource("BackgroundBlueBrush") : Application.Current.FindResource("BackgroundTransparent");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}