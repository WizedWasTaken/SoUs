using SoUs.DataObjects;
using SoUs.Entities;

namespace SoUs.DataAccess
{
    public interface IResidentRepository : IRepository<Resident>
    {
        IEnumerable<ResidentWithAssignmentsDTO> GetResidentsTasksOnDateAndEmployee(DateTime date, int employeeId);
    }
}
