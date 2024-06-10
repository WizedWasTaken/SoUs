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

        [ObservableProperty]
        private string userId;

        [RelayCommand]
        private async Task SubmitUserId()
        {
            try { 
                if (IsInteger(UserId) && UserId != null)
                {
                    // Hent bruger fra databasen.
                    Employee employee = await employeeService.GetEmployeeFromIdAsync(int.Parse(UserId));

                    if (employee != null)
                    {
                        InfoAlert("Korrekt log ind.\nDu bliver sendt videre om et øjeblik.");
                        employeeService.Employee = employee;

                        // Hvis brugeren er en medarbejder, så vises hovedopgaverne.
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

        private static bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
