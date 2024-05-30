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
        public IEnumerable<Assignment> GetAssignmentsForEmployee(DateTime date, int employeeId)
        {
            return _context.Assignments.Where(a => a.Employees.Any(e => e.EmployeeId == employeeId) && a.TimeStart.Date == date.Date).Include(a => a.Employees).Include(a => a.Medicines).ToList();
        }

        public Assignment GetBy(int id)
        {
            return _context.Assignments.Include(a => a.Employees).Include(a => a.Medicines).FirstOrDefault(a => a.AssignmentId == id);
        }
    }
}
