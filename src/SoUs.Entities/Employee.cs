using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class Employee
    {
        #region Fields
        private int employeeId;
        private List<Task> tasks;
        private List<Role> role;
        private string name;
        private CareCenter careCenter;

        #endregion

        #region Constructors

        public Employee(int employeeId, List<Task> tasks, List<Role> role, string name, CareCenter careCenter)
        {
            EmployeeId = employeeId;
            Tasks = tasks;
            Role = role;
            Name = name;
            CareCenter = careCenter;
        }

        #endregion

        #region Properties

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

        public List<Role> Role
        {
            get { return role; }
            set { role = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public CareCenter CareCenter
        {
            get { return careCenter; }
            set { careCenter = value; }
        }

        #endregion
    }
}
