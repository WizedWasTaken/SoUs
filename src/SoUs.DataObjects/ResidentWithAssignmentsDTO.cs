using SoUs.Entities;

namespace SoUs.DataObjects
{
    public class ResidentWithAssignmentsDTO
    {
        #region Fields
        private Resident resident;
        private List<Assignment> assignments;
        public bool AreAllTasksCompleted => Assignments != null && Assignments.All(a => a.IsCompleted);
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
}
