using System;
using System.Globalization;
using System.Windows;

namespace Messil
{
    /// <summary>
    /// A converter that takes in a boolean and returns a <see cref="Visibility"/>
    /// </summary>
    public class BooleanToVisiblityConverter : BaseValueConverter<BooleanToVisiblityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /// Default
            if(parameter == null)
                return (bool)value ? Visibility.Hidden : Visibility.Visible;
            /// Lets make convertion with not standart "True" parameter
            else 
                return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}