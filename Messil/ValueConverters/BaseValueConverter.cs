using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Messil
{
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T: class, new()
    {

        #region Private Members

        private static T Converter = null;

        #endregion

        #region Markup Extension Method

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Converter ?? (Converter = new T());
        }

        #endregion

        #region ValueConverters Methods

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion
    }
}
