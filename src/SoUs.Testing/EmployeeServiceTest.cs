using SoUs.Services;
using SoUs.Entities;

namespace SoUs.Testing
{
    public class EmployeeServiceTest
    {
        [Fact]
        public async Task EmployeeReceived()
        {
            EmployeeService employeeService = new("https://localhost:7093/api/");

            Employee employee = await employeeService.GetEmployeeFromIdAsync(2);

            Assert.NotNull(employee);

            Assert.Equal(2, employee.EmployeeId);
        }
    }
}