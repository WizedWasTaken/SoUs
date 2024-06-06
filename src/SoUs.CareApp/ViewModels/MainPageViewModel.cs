using CommunityToolkit.Mvvm.Input;
using SoUs.Entities;
using SoUs.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using SoUs.DataObjects;
using CommunityToolkit.Mvvm.ComponentModel;
using SoUs.CareApp.Views;

namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly ISoUsService sousService;

        public ObservableCollection<Assignment> TodaysAssignments { get; } = [];

        public MainPageViewModel(ISoUsService sousService)
        {
            Title = "DAGENS OPGAVER";
            this.sousService = sousService;
            UpdateAssignmentsAsync();
        }

        #region Commands
        [RelayCommand]
        public async Task RefreshAssignments()
        {
            ErrorOccurred = false;
            await UpdateAssignmentsAsync();
        }

        [RelayCommand]
        private async void GoToSpecificTask(Assignment ass)
        {
            if (ass is null)
            {
                NoWorkey("Denne opgave kunne ikke findes.");
                return;
            }

            await Shell.Current.GoToAsync($"{nameof(SubTaskPage)}", true,
                new Dictionary<string, object>
                {
                    {"Assignment", ass }
                });
        }

        #endregion

        private async Task UpdateAssignmentsAsync()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                // Sæt placeholder data... (Det bliver ikke brugt, lol.)
                DateTime date = DateTime.Now;
                Employee employee = new() { EmployeeId = 2 };
                // Kald service for at hente opgaver
                var assignments = await sousService.GetAssignmentsAsync(date, employee);

                if (TodaysAssignments.Count != 0)
                {
                    TodaysAssignments.Clear();
                }

                // Tilføj de nye opgaver til 'TodaysAssignments'
                // Det her er fint, fordi vi ikke rigtigt har 1000 opgaver om dagen, pr. bruger. - ellers kig på at oprette ny ObservableCollection...
                foreach (var assignment in assignments)
                {
                    TodaysAssignments.Add(assignment);
                }

                if (TodaysAssignments.Count == 0)
                {
                    Shell.Current.DisplayAlert("INFO", "Der er ingen opgaver for i dag.", "OK");
                }
            }
            catch
            {
                Shell.Current.DisplayAlert("FEJL", "Der skete en fejl under hentning af opgaver.", "OK");
            }
            finally
            {
                if (TodaysAssignments.Count == 0)
                {
                    ErrorOccurred = true;
                }
                IsBusy = false;
            }
        }
    }
}
