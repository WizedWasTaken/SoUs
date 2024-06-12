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
        private readonly IAssignmentService _sousService;
        private readonly IEmployeeService _employeeService;


        [ObservableProperty]
        private Employee employee;

        // All assignments from the database.
        public ObservableCollection<Assignment> TodaysAssignments { get; } = new ObservableCollection<Assignment>();

        public MainPageViewModel(IAssignmentService sousService, IEmployeeService employeeService)
        {
            Title = "DAGENS OPGAVER";
            _sousService = sousService;
            _employeeService = employeeService;
            Employee = employeeService.Employee;
            UpdateAssignmentsAsync();
        }

        #region Commands

        /// <summary>
        /// Command to refresh the assignments if error occured.
        /// </summary>
        /// <returns>Nothing</returns>
        [RelayCommand]
        public async Task RefreshAssignments()
        {
            ErrorOccurred = false;
            await UpdateAssignmentsAsync();
        }

        /// <summary>
        /// Method to go the specific task.
        /// </summary>
        /// <param name="assignment">The specific task.</param>
        /// <returns>Nothing</returns>
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

        /// <summary>
        /// Helper method to update assignments.
        /// </summary>
        /// <returns>Nothing</returns>
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

        /// <summary>
        /// Helper method to update the assignments.
        /// </summary>
        /// <returns>Nothing</returns>
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
