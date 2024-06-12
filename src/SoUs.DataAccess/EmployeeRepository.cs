using Microsoft.EntityFrameworkCore;
using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.DataAccess
{
    public class EmployeeRepository(DataContext _context) :
        Repository<Employee>(_context), IEmployeeRepository
    {
        /// <summary>
        /// Method to get all employees in database.
        /// </summary>
        /// <returns>All employees</returns>
        public new IEnumerable<Employee> GetAll()
        {
            var res = _context.Employees
                .Include(e => e.Roles)
                .ToList();

            return res;
        }

        /// <summary>
        /// Method to get a employees with a specific role.
        /// </summary>
        /// <param name="role">Role to get all employees from.</param>
        /// <returns>All employees with XX role.</returns>
        public IEnumerable<Employee> GetEmployeesByRole(Role role)
        {
            return _context.Employees.Where(e => e.Roles.Contains(role));
        }

        /// <summary>
        /// Method to get all employees by care center.
        /// </summary>
        /// <param name="careCenter">Care center to get all employees from.</param>
        /// <returns>All employees connected to XX care center.</returns>
        public IEnumerable<Employee> GetEmployeesByCareCenter(CareCenter careCenter)
        {
            return _context.Employees.Where(e => e.CareCenter == careCenter);
        }
    }
}
