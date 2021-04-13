using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Messil
{
    /// <summary>
    /// A converter that takes in a string RGB and returns WPF Brush <see cref="Visibility"/>
    /// </summary>
    public class StingRGBToBrushConverter : BaseValueConverter<StingRGBToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#{value}"));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}