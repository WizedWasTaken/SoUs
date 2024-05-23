using SoUs.Entities;

namespace SoUs.DataAccess
{
    public interface IEmployeeRepository : IRepository<Entities.Employee>
    {
        IEnumerable<Employee> GetEmployeesByRole(Role role);

        IEnumerable<Employee> GetEmployeesByCareCenter(CareCenter careCenter);
    }
}
