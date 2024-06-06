using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class MedicineTask : SubTask
    {
        #region Fields

        private Medicine medicine;
        private string unit;
        private int amount;

        #endregion

        #region Constructors

        public MedicineTask() : base(0, "Intet navn", false)
        {
        }

        public MedicineTask(int subTaskId, string name, bool isCompleted, Medicine medicine, string unit, int amount)
            : base(subTaskId, name, isCompleted)
        {
            Medicine = medicine;
            Unit = unit;
            Amount = amount;
        }

        #endregion

        #region Properties

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
