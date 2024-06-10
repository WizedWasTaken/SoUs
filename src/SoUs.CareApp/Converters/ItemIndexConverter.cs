using SoUs.Entities;
using System;
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
            if (parameter is CollectionView collectionView && value is Assignment assignment)
            {
                var itemsSource = collectionView.ItemsSource as IList<Assignment>;
                if (itemsSource != null)
                {
                    return itemsSource.IndexOf(assignment) + 1;
                }
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
