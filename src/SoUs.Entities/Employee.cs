using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoUs.Entities
{
    public class Employee
    {
        #region Fields
        private int employeeId;
        private List<Task> tasks;
        private List<Role> roles;
        private string name;
        private CareCenter careCenter;
        #endregion

        #region Constructors
        public Employee()
        {
            this.tasks = new List<Task>();  // Initialize to prevent null reference issues
            this.roles = new List<Role>();  // Initialize to prevent null reference issues
        }

        public Employee(int employeeId, List<Task> tasks, List<Role> roles, string name, CareCenter careCenter)
        {
            this.employeeId = employeeId;
            this.tasks = tasks ?? new List<Task>();  // Use null-coalescing to ensure lists are never null
            this.roles = roles ?? new List<Role>();
            this.name = name;
            this.careCenter = careCenter;
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

        public List<Role> Roles
        {
            get { return roles; }
            set { roles = value; }
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
