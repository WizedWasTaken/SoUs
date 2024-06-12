using SoUs.Entities;

namespace SoUs.Services
{
    public interface IAssignmentService
    {
        Task<List<Assignment>> GetAssignmentsAsync(DateTime date, Employee employee);
        Task<Assignment> UpdateAssignmentAsync(Assignment assignment);
    }
}
