using System;
using System.Globalization;
using MvvmCross.Converters;

namespace AvanadeLogin.Core.Converters
{
    public class DateToStringConverter : MvxValueConverter<DateTime, string>
    {
        protected override string Convert(DateTime value, Type targetType, object parameter, CultureInfo cultureInfo)
        {
            return value.ToString("d", cultureInfo);
        }

        protected override DateTime ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime.TryParse(value, out var result);
            return result;
        }
    }
}
