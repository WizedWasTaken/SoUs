using SoUs.Entities;

namespace SoUs.Services
{
    public interface ISoUsService
    {
        Task<List<Assignment>> GetAssignmentsAsync(DateTime date, Employee employee);
    }
}
