using SoUs.Entities;

namespace SoUs.DataObjects
{
    public class ResidentWithAssignmentsDTO
    {
        #region Fields
        private Resident resident;
        private List<Assignment> assignments;
        #endregion

        #region Constructors
        public ResidentWithAssignmentsDTO()
        {
            Assignments = new List<Assignment>();
        }

        public ResidentWithAssignmentsDTO(Resident resident, List<Assignment> assignments)
        {
            Resident = resident;
            Assignments = assignments ?? new List<Assignment>();
        }

        #endregion

        #region Properties

        public Resident Resident
        {
            get { return resident; }
            set { resident = value; }
        }

        public List<Assignment> Assignments
        {
            get { return assignments; }
            set { assignments = value; }
        }

        #endregion
    }

    public class AssignmentDTO
    {
        public int Id { get; set; }
        public int ResidentId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime TimeStart { get; set; }
        // Other properties
    }

    public class ResidentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string RoomNumber { get; set; }
        public string Notes { get; set; }
        // Other properties
    }
}
