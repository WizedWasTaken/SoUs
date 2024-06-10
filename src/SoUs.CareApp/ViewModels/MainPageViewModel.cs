using CommunityToolkit.Mvvm.Input;
using SoUs.Entities;
using SoUs.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using SoUs.CareApp.Views;

namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly ISoUsService _sousService;
        private readonly IEmployeeService _employeeService;

        [ObservableProperty]
        private Employee employee;

        public ObservableCollection<Assignment> TodaysAssignments { get; } = new ObservableCollection<Assignment>();

        public MainPageViewModel(ISoUsService sousService, IEmployeeService employeeService)
        {
            Title = "DAGENS OPGAVER";
            _sousService = sousService;
            _employeeService = employeeService;
            Employee = employeeService.Employee;
            _ = UpdateAssignmentsAsync(); // Brug af discard, da vi ikke bruger resultatet.
        }

        #region Commands

        [RelayCommand]
        public async Task RefreshAssignments()
        {
            ErrorOccurred = false;
            await UpdateAssignmentsAsync();
        }

        [RelayCommand]
        private async Task GoToSpecificTask(Assignment assignment)
        {
            if (assignment == null)
            {
                ErrorAlert("Denne opgave kunne ikke findes.");
                return;
            }

            var navigationParams = new Dictionary<string, object>
            {
                { "Assignment", assignment }
            };

            await Shell.Current.GoToAsync(nameof(SubTaskPage), true, navigationParams);
        }

        #endregion

        private async Task UpdateAssignmentsAsync()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                var date = DateTime.Now;
                var assignments = await _sousService.GetAssignmentsAsync(date, _employeeService.Employee);

                UpdateTodaysAssignments(assignments);

                if (TodaysAssignments.Count == 0)
                {
                    await Shell.Current.DisplayAlert("INFO", "Der er ingen opgaver for i dag.", "OK");
                }
            }
            catch (Exception ex)
            {
                ErrorAlert(ex.Message);
            }
            finally
            {
                ErrorOccurred = TodaysAssignments.Count == 0;
                IsBusy = false;
            }
        }

        private void UpdateTodaysAssignments(IEnumerable<Assignment> assignments)
        {
            TodaysAssignments.Clear();

            foreach (var assignment in assignments)
            {
                TodaysAssignments.Add(assignment);
            }
        }
    }
}
