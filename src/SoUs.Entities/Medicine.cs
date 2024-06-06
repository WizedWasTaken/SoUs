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

        #endregion

        #region Constructors

        public Medicine()
        {
        }

        public Medicine(int medicineId, string name)
        {
            MedicineId = medicineId;
            Name = name;
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

        #endregion
    }
}
