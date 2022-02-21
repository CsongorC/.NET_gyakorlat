using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ProductApp.Helper
{
    [ValueConversion(typeof(int), typeof(Brushes))]
    class IntegerToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int.Parse(value.ToString()) < 10000) ? Brushes.Red : Brushes.MediumBlue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}