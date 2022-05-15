using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;


namespace EasyParking.Converter
{
    class NullToBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (string)value;

            if (string.IsNullOrEmpty(v))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Convert<T>(List<T> value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = value;

            if (v == null || v.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
