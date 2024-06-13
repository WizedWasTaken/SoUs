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

        /// <summary>
        /// Get all assignments for a specific employee on a specific date.
        /// </summary>
        /// <param name="date">The date to get all assignments for</param>
        /// <param name="employeeId">The employee Id to get all assignments for</param>
        /// <returns>All tasks for the specific employee, on the specific date.</returns>
        public IEnumerable<Assignment> GetAssignmentsForEmployee(DateTime date, int employeeId)
        {
            return _context.Assignments
                .Where(a => a.Employees.Any(e => e.EmployeeId == employeeId))
                .Include(a => a.Resident)
                .Include(a => a.SubTasks)
                .Include(a => a.MedicineTasks);
        }

        /// <summary>
        /// Get assignment by id
        /// </summary>
        /// <param name="id">ID to get from.</param>
        /// <returns>Assignment</returns>
        public Assignment GetBy(int id)
        {
            var res = _context.Assignments
                .Include(a => a.Employees)
                .Include(a => a.Resident)
                .Include(a => a.SubTasks)
                .Include(a => a.MedicineTasks)
                .FirstOrDefault(a => a.AssignmentId == id);

            return res;
        }
    }
}
