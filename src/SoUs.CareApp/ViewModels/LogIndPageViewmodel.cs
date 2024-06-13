using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SoUs.CareApp.Views;
using SoUs.Entities;
using SoUs.Services;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.ViewModels
{
    public partial class LogIndPageViewmodel : BaseViewModel
    {
        private readonly IEmployeeService employeeService;

        public LogIndPageViewmodel(IEmployeeService employeeService)
        {
            userId = "0";
            Title = "INDTAST BRUGER ID";
            this.employeeService = employeeService;
        }

        // User ID property.
        [ObservableProperty]
        private string userId;

        /// <summary>
        /// Command to submit user id.
        /// </summary>
        /// <returns>Nothing</returns>
        /// <exception cref="InvalidDataException">Employee wasn't found.</exception>
        [RelayCommand]
        private async Task SubmitUserId()
        {
            try { 
                if (IsInteger(UserId) && UserId != null)
                {
                    Employee employee = await employeeService.GetEmployeeFromIdAsync(int.Parse(UserId));

                    if (employee != null)
                    {
                        employeeService.Employee = employee;

                        if (employee.EmployeeId != 0)
                        {
                            await Shell.Current.GoToAsync(nameof(MainPage));
                        }

                        return;
                    }
                }

                throw new InvalidDataException("Medarbejderen kunne ikke findes.");
            } catch (Exception e)
            {
                ErrorAlert(e.Message);
            }
        }

        /// <summary>
        /// Helper method to check if a string is an integer.
        /// </summary>
        /// <param name="value">String value containing only numbers</param>
        /// <returns>Boolean</returns>
        private static bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
