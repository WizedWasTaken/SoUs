using System;
using System.Collections.Generic;

namespace SoUs.Entities
{
    public class Assignment
    {
        #region Fields

        private int assignmentId;
        private string name;
        private DateTime timeStart;
        private DateTime timeEnd;
        private Resident resident;
        private List<Employee> employees;
        private List<Medicine> medicines;
        private bool isCompleted;

        #endregion

        #region Constructors

        public Assignment()
        {
            Employees = new List<Employee>();
            Medicines = new List<Medicine>();
        }

        public Assignment(int assignmentId, string name, DateTime timeStart, DateTime timeEnd, Resident resident,
                    List<Employee> employees, List<Medicine> medicines, bool completed)
        {
            AssignmentId = assignmentId;
            Name = name;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employees = employees ?? new List<Employee>();
            Medicines = medicines ?? new List<Medicine>();
            IsCompleted = completed;
        }

        #endregion

        #region Properties

        public int AssignmentId
        {
            get { return assignmentId; }
            set { assignmentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }

        public DateTime TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; }
        }

        public Resident Resident
        {
            get { return resident; }
            set { resident = value; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public List<Medicine> Medicines
        {
            get { return medicines; }
            set { medicines = value; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        #endregion
    }
}
