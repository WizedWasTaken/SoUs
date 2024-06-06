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
        private bool isCompleted;

        #endregion

        #region Constructors

        public SubTask(int subTaskId, string name, bool isCompleted)
        {
            SubTaskId = subTaskId;
            Name = name;
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

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        #endregion
    }
}
