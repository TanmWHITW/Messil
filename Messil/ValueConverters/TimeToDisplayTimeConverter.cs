using System;
using System.Globalization;
using System.Windows;

namespace Messil
{
    /// <summary>
    /// A converter that takes in a date time and returns a friemdly time
    /// </summary>
    public class TimeToDisplayTimeConverter : BaseValueConverter<TimeToDisplayTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /// Default
            var time = (DateTimeOffset)value;

            if (time.Date == DateTimeOffset.UtcNow.Date)
                return time.ToLocalTime().ToString("HH:mm");

            if (time.Month == DateTimeOffset.UtcNow.Month)
                return time.ToLocalTime().ToString("HH:mm, d MMM");

            return time.ToLocalTime().ToString("d MMM yyyy");
                }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}