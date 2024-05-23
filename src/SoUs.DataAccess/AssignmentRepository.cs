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
                .ThenInclude(r => r.Diagnoses)
                .ToList();
            return res;
        }

        public new Assignment GetById(int id)
        {
            var res = _context.Assignments
                    .Include(a => a.Resident)
                    .ThenInclude(r => r.Diagnoses)
                .FirstOrDefault(a => a.AssignmentId == id);

            if (res == null)
            {
                throw new ArgumentException("Assignment not found");
            }

            return res;
        }

        public IEnumerable<Assignment> GetAssignmentsOn(DateTime date)
        {
            return _context.Assignments.Where(a => a.TimeStart == date.Date);
        }

        public IEnumerable<Assignment> GetAssignmentsForEmployee(Employee employee)
        {
            return _context.Assignments.Where(a => a.Employees.Contains(employee));
        }
    }
}
