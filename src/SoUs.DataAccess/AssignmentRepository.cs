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
        public IEnumerable<Assignment> GetAssignmentsForEmployee(Employee employee)
        {
            return _context.Assignments.Where(a => a.Employees.Contains(employee));
        }

        public IEnumerable<Assignment> GetAssignmentsOn(DateTime date)
        {
            return _context.Assignments.Where(a => a.TimeStart == date.Date);
        }

        public Assignment GetBy(int id)
        {
            return _context.Assignments.Include(a => a.Employees).Include(a => a.Medicines).FirstOrDefault(a => a.AssignmentId == id);
        }
    }
}
