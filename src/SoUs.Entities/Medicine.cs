using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class Medicine
    {
        #region Fields
        private int medicineId;
        private string name;
        private int amount;
        private string unit;
        private bool administered;

        public Medicine()
        {
        }
        #endregion

        #region Constructors

        public Medicine(int medicineId, string name, int amount, string unit, bool administered)
        {
            MedicineId = medicineId;
            Name = name;
            Unit = unit;
            Amount = amount;
            Administered = administered;
        }
        #endregion

        #region Properties

        public int MedicineId
        {
            get { return medicineId; }
            set { medicineId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public bool Administered
        {
            get { return administered; }
            set { administered = value; }
        }

        #endregion
    }
}
