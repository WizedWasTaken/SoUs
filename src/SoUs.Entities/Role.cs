using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class Role
    {
        #region Fields
        private int roleId;
        private string roleName;
        private List<Employee> employees;

        public Role()
        {
        }
        #endregion

        #region Constructor
        public Role(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }

        public Role(int roleId, string roleName, List<Employee> employees)
        {
            RoleId = roleId;
            RoleName = roleName;
            Employees = employees;
        }
        #endregion

        #region Properties
        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        #endregion
    }
}
