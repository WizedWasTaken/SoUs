using SoUs.DataObjects;
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
    public class TimeRangeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 1 && values[0] is ResidentWithAssignmentsDTO residentWithAssignments)
            {
                var assignments = residentWithAssignments.Assignments;
                if (assignments != null && assignments.Count > 0)
                {
                    var firstAssignment = assignments.First();
                    var lastAssignment = assignments.Last();
                    return $"{firstAssignment.TimeStart:HH.mm} - {lastAssignment.TimeEnd:HH.mm}";
                }
            }

            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
