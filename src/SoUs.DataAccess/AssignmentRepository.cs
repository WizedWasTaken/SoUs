using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.DataAccess
{
    public class AssignmentRepository(DataContext _context) :
        Repository<Assignment>(_context), IAssignmentRepository
    {

        public IEnumerable<Assignment> GetAssignmentsOn(DateTime date)
        {
            return _context.Assignments.Where(a => a.TimeStart == date.Date);
        }

        public IEnumerable<Assignment> GetAssignmentsForEmployee(int employeeId)
        {
            //return _context.Assignments.Where(a => a.EmployeeId == employeeId);
            return new List<Assignment>();
        }

        public IEnumerable<Assignment> GetAssignmentsForEmployee(Employee employee)
        {
            return _context.Assignments.Where(a => a.Employees.Contains(employee));
        }

        public IEnumerable<Assignment> GetAssignmentsForEmployee(string name)
        {
            return _context.Assignments.Where(a => a.Employees.Any(e => e.Name == name));
        }
    }
}
