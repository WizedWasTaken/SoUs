using System;
using System.Collections.Generic;

namespace SoUs.Entities
{
    public class Assignment
    {
        #region Fields

        private int assignmentId;
        private DateTime timeStart;
        private DateTime timeEnd;
        private Resident resident;
        private List<Employee> employees;
        private List<SubTask> subTasks;
        private List<MedicineTask>? medicineTasks;

        #endregion

        #region Constructors

        public Assignment()
        {
            Employees = new List<Employee>();
            SubTasks = new List<SubTask>();
            MedicineTasks = new List<MedicineTask>();
        }

        public Assignment(int assignmentId, DateTime timeStart, DateTime timeEnd, Resident resident,
                    List<Employee> employees, List<SubTask> SubTasks, List<MedicineTask> medicineTasks)
        {
            AssignmentId = assignmentId;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employees = employees ?? new List<Employee>();
            SubTasks = SubTasks ?? new List<SubTask>();
            MedicineTasks = medicineTasks ?? new List<MedicineTask>();
        }

        #endregion

        #region Properties

        public int AssignmentId
        {
            get { return assignmentId; }
            set { assignmentId = value; }
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

        public List<SubTask> SubTasks
        {
            get { return subTasks; }
            set { subTasks = value; }
        }

        public List<MedicineTask>? MedicineTasks
        {
            get { return medicineTasks; }
            set { medicineTasks = value; }
        }

        #endregion
    }
}
