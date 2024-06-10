using SoUs.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.CareApp.Converters
{
    public class ItemIndexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is CollectionView collectionView && value != null)
            {
                var itemsSource = collectionView.ItemsSource as IEnumerable;
                if (itemsSource != null)
                {
                    var itemList = itemsSource.Cast<object>().ToList();
                    var index = itemList.IndexOf(value);
                    if (index >= 0)
                    {
                        return index + 1; // 1-based index
                    }
                }
            }
            return 0; // Return 0 if item not found
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
