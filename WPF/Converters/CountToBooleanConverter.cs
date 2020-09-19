using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using YouTube.Downloader.Utilities;

namespace WPF.Converters
{

    [ValueConversion(typeof(int), typeof(bool))]
    internal class CountToBooleanConverter : IValueConverter
    {
        public static CountToBooleanConverter Default { get; } = new CountToBooleanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value > 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw ThrowHelper.NotSupported();
        }
    }
}