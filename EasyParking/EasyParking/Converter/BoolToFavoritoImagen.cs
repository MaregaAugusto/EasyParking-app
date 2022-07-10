using System;
using System.Globalization;
using Xamarin.Forms;


namespace EasyParking.Converter
{
    class BoolToFavoritoImagen : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (bool)value;
            if (v)
            {
                return "heartFill.png";
            }
            else
            {
                return "heart.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}
