using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoUs.Entities
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
        private List<Medicine> medicines; // Remove nullable for better EF compatibility
        private bool completed;

        #endregion

        #region Constructors

        public Task()
        {
            this.employees = new List<Employee>(); // Initialize to prevent null reference issues
            this.medicines = new List<Medicine>(); // Initialize to prevent null reference issues
        }

        public Task(int taskId, string name, DateTime timeStart, DateTime timeEnd, Resident resident,
                    List<Employee> employees, List<Medicine> medicines, bool completed)
        {
            this.taskId = taskId;
            this.name = name;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
            this.resident = resident;
            this.employees = employees ?? new List<Employee>(); // Use null-coalescing to ensure lists are never null
            this.medicines = medicines ?? new List<Medicine>();
            this.completed = completed;
        }

        #endregion

        #region Properties

        [Key]
        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        [Required]
        [MaxLength(255)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        public DateTime TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }

        [Required]
        public DateTime TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; }
        }

        [ForeignKey("ResidentId")]
        public virtual Resident Resident
        {
            get { return resident; }
            set { resident = value; }
        }

        // Optional: Define a foreign key if you're explicitly defining foreign keys
        public int ResidentId { get; set; }

        public virtual List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public virtual List<Medicine> Medicines
        {
            get { return medicines; }
            set { medicines = value; }
        }

        [Required]
        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        #endregion
    }
}
