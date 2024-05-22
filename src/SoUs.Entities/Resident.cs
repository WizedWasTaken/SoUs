using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoUs.Entities
{
    public class Resident
    {
        #region Fields
        private int residentId;
        private string name;
        private string roomNumber;
        private List<Diagnosis> diagnoses;
        private List<Prescription> prescriptions;
        private string notes;
        #endregion

        #region Constructors
        public Resident()
        {
            this.diagnoses = new List<Diagnosis>();  // Initialize to prevent null reference issues
            this.prescriptions = new List<Prescription>();  // Initialize to prevent null reference issues
        }

        public Resident(int residentId, string name, string roomNumber, List<Diagnosis> diagnoses,
            List<Prescription> prescriptions, string notes)
        {
            this.residentId = residentId;
            this.name = name;
            this.roomNumber = roomNumber;
            this.diagnoses = diagnoses ?? new List<Diagnosis>();  // Use null-coalescing to ensure lists are never null
            this.prescriptions = prescriptions ?? new List<Prescription>();
            this.notes = notes;
        }
        #endregion

        #region Properties
        public int ResidentId
        {
            get { return residentId; }
            set { residentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public List<Diagnosis> Diagnoses
        {
            get { return diagnoses; }
            set { diagnoses = value; }
        }

        public List<Prescription> Prescriptions
        {
            get { return prescriptions; }
            set { prescriptions = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        #endregion
    }
}
