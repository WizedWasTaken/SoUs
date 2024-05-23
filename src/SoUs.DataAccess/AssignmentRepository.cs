using Microsoft.EntityFrameworkCore;
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
        public new IEnumerable<Assignment> GetAll()
        {
            var res = _context.Assignments

                    .Include(a => a.Resident)
                    .ThenInclude(r => r.Prescriptions)

                .ToList();
            return res;
        }

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
    }
}
