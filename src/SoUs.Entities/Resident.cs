using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoUs.Entities
{
    public class Resident
    {
        #region Fields
        private int residentId;
        private string name;
        private DateTime birthDate;
        private string roomNumber;
        private List<Diagnosis> diagnoses;
        private List<Prescription> prescriptions;
        private string notes;
        #endregion

        #region Constructors
        public Resident()
        {
            Diagnoses = new List<Diagnosis>();
            Prescriptions = new List<Prescription>();
        }

        public Resident(int residentId, string name, DateTime birthDate, string roomNumber, List<Diagnosis> diagnoses,
            List<Prescription> prescriptions, string notes)
        {
            ResidentId = residentId;
            Name = name;
            BirthDate = birthDate;
            RoomNumber = roomNumber;
            Diagnoses = diagnoses ?? new List<Diagnosis>();
            Prescriptions = prescriptions ?? new List<Prescription>();
            Notes = notes;
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

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
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
