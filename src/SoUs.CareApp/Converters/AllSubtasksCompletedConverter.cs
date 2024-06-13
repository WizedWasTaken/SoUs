using System.Globalization;
using SoUs.Entities;

namespace SoUs.CareApp.Converters
{
    public class AllSubtasksCompletedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is List<SubTask> subtasks)
            {
                return subtasks.All(subtask => subtask.IsCompleted);
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
