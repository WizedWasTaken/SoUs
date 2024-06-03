using Microsoft.EntityFrameworkCore;
using SoUs.DataObjects;
using SoUs.Entities;

namespace SoUs.DataAccess
{
    public class ResidentRepository(DataContext context) : Repository<Resident>(context), IResidentRepository
    {
        public IEnumerable<ResidentWithAssignmentsDTO> GetResidentsTasksOnDateAndEmployee(DateTime date, int employeeId)
        {
            var residentsWithAssignments = context.Assignments
                .Where(a => a.TimeStart.Date == date.Date && a.Employees.Any(e => e.EmployeeId == employeeId))
                .GroupBy(a => a.Resident)
                .Select(g => new ResidentWithAssignmentsDTO(g.Key, g.ToList()))
                .ToList();

            return residentsWithAssignments;
        }
    }
}
