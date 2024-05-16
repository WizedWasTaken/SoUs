﻿namespace SoUs.Entities
{
    public class Task
    {
        #region Fields

        private int taskId;
        private string name;
        private DateTime timeStart;
        private DateTime timeEnd;
        private Resident resident;
        private List<Employee> employees;
        private List<Medicine>? medicines;
        private bool completed;

        #endregion

        #region Constructors

        public Task(int taskId, string name, DateTime timeStart, DateTime timeEnd, Resident resident,
            List<Employee> employees, List<Medicine>? medicines, bool completed)
        {
            TaskId = taskId;
            Name = name;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employees = employees;
            Medicines = medicines;
            Completed = completed;
        }

        #endregion

        #region Properties

        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
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

        public List<Medicine>? Medicines
        {
            get { return medicines; }
            set { medicines = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        #endregion
    }
}