using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class SubTask
    {
        #region Fields

        private int subTaskId;
        private string name;
        private List<Medicine>? medicines;
        private Assignment assignment;
        private bool isCompleted;

        #endregion

        #region Constructors

        public SubTask()
        {
            Medicines = new List<Medicine>();
        }

        public SubTask(int subTaskId, string name, List<Medicine>? medicines, Assignment assignment, bool isCompleted)
        {
            SubTaskId = subTaskId;
            Name = name;
            Medicines = medicines ?? new List<Medicine>();
            Assignment = assignment;
            IsCompleted = isCompleted;
        }

        #endregion

        #region Properties

        public int SubTaskId
        {
            get { return subTaskId; }
            set { subTaskId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Medicine>? Medicines
        {
            get { return medicines; }
            set { medicines = value; }
        }

        public Assignment Assignment
        {
            get { return assignment; }
            set { assignment = value; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        #endregion
    }
}
