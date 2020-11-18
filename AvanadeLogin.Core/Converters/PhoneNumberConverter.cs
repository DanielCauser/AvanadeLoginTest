using System;
using System.Globalization;
using System.Text.RegularExpressions;
using MvvmCross.Converters;

namespace AvanadeLogin.Core.Converters
{
    public class PhoneNumberConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            if (value.Length == 1)
                return value = $"({value}";
            if (value.Length == 4)
                return value += ")-";
            else if (value.Length == 9)
                value += "-";

            return value;
        }
    
            
        protected override string ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
