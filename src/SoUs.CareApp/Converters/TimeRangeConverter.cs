using System;
using System.Diagnostics;
using System.Globalization;

namespace SoUs.CareApp.Converters
{
    public class TimeRangeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length < 2)
            {
                Debug.WriteLine("TimeRangeConverter: Invalid values array");
                return string.Empty;
            }

            if (values[0] is DateTime start && values[1] is DateTime end)
            {
                Debug.WriteLine($"TimeRangeConverter: Start={start}, End={end}");
                return $"{start:HH.mm} - {end:HH.mm}";
            }

            Debug.WriteLine($"TimeRangeConverter: Unexpected value types. StartType={values[0]?.GetType()}, EndType={values[1]?.GetType()}");
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
