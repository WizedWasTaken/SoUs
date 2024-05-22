using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class Prescription
    {
        #region Fields

        private int prescriptionId;
        private string name;
        private int amount;
        private string unit;

        #endregion

        #region Constructors

        public Prescription(int prescriptionId, string name, int amount, string unit)
        {
            PrescriptionId = prescriptionId;
            Name = name;
            Unit = unit;
            Amount = amount;
        }

        #endregion

        #region Properties

        public int PrescriptionId
        {
            get { return prescriptionId; }
            set { prescriptionId = value; }
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

        #endregion
    }
}
