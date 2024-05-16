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
        [Key]
        public int ResidentId
        {
            get { return residentId; }
            set { residentId = value; }
        }

        [Required]
        [MaxLength(100)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        [MaxLength(10)]
        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public virtual List<Diagnosis> Diagnoses
        {
            get { return diagnoses; }
            set { diagnoses = value; }
        }

        public virtual List<Prescription> Prescriptions
        {
            get { return prescriptions; }
            set { prescriptions = value; }
        }

        [MaxLength(1000)] // Assuming there is a reasonable limit to the length of notes
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        #endregion
    }
}
