using SoUs.DataObjects;
using SoUs.Entities;

namespace SoUs.Services
{
    public interface ISoUsService
    {
        Task<List<ResidentWithAssignmentsDTO>> GetAssignmentsAsync(DateTime date, Employee employee);
    }
}
