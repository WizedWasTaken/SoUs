using Microsoft.EntityFrameworkCore;
using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.DataAccess
{
    public class SubTaskRepository(DataContext _context) :
        Repository<SubTask>(_context), IRepository<SubTask>
    {
        /// <summary>
        /// Method to get all (non medtask) subtasks in database.
        /// </summary>
        /// <returns>List of SubTasks</returns>
        public new IEnumerable<SubTask> GetAll()
        {
            // Makes it return only subtasks.
            var res = _context.SubTasks.OfType<SubTask>().ToList();

            return res;
        }
    }
}
