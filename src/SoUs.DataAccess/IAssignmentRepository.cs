using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.DataAccess
{
    public interface IAssignmentRepository : IRepository<Assignment>
    {
        IEnumerable<Assignment> GetAssignmentsForEmployee(DateTime date, int employeeId);
        Assignment GetBy(int id);
    }
}
