using CommunityToolkit.Mvvm.Input;
using SoUs.Entities;
using SoUs.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

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

        [RelayCommand]
        private async Task UpdateAssignmentsAsync()
        {
            IsBusy = false;
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                // Sæt placeholder data... (Det bliver ikke brugt lol)
                DateTime date = DateTime.Now;
                Employee employee = new() { EmployeeId = 2 };
                // Kald service for at hente opgaver
                var assignments = await sousService.GetAssignmentsAsync(date, employee);

                // Tjek om der er opgaver i dag, hvis der er, så fjern dem
                if (TodaysAssignments.Count != 0)
                {
                    TodaysAssignments.Clear();
                }

                // Tilføj de nye opgaver til 'TodaysAssignments
                // Det her er fint, fordi vi ikke rigtigt har 1000 opgaver om dagen, pr. bruger. - ellers kig på at oprette ny ObservableCollection...
                foreach (var assignment in assignments)
                {
                    TodaysAssignments.Add(assignment);
                }

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
