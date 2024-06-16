using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class MedicineTask
    {
        #region Fields

        private int medicineTaskId;
        private string name;
        private bool isCompleted;
        private Medicine medicine;
        private string unit;
        private int amount;

        #endregion 

        #region Constructors

        public MedicineTask()
        { }

        public MedicineTask(int medicineTaskId, string name, bool isCompleted, Medicine medicine, string unit, int amount)
        {
            MedicineTaskId = medicineTaskId;
            Name = name;
            IsCompleted = isCompleted;
            Medicine = medicine;
            Unit = unit;
            Amount = amount;
        }

        #endregion

        #region Properties

        public int MedicineTaskId
        {
            get { return medicineTaskId; }
            set { medicineTaskId = value; }
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

        public Medicine Medicine
        {
            get { return medicine; }
            set { medicine = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        #endregion
    }
}
