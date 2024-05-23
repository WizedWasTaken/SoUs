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
        public new IEnumerable<Employee> GetAll()
        {
            var res = _context.Employees
                .Include(e => e.Roles)
                .ToList();
            return res;
        }

        public IEnumerable<Employee> GetEmployeesByRole(Role role)
        {
            return _context.Employees.Where(e => e.Roles.Contains(role));
        }

        public IEnumerable<Employee> GetEmployeesByCareCenter(CareCenter careCenter)
        {
            return _context.Employees.Where(e => e.CareCenter == careCenter);
        }
    }
}
