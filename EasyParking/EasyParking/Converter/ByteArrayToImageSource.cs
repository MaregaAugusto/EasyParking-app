using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace EasyParking.Converter
{
    public class ByteArrayToImageSource : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imageArray = (byte[])value;

            return ImageSource.FromStream(() =>
            {
                return new MemoryStream(imageArray);
            });
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
