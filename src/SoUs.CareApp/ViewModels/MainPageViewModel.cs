using SoUs.Entities;
using SoUs.Services;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly ISoUsService sosuService;

        public ObservableCollection<Assignment> TodaysAssignments { get; } = new();

        public MainPageViewModel(ISoUsService sosuService)
        {
            Title = "DAGENS OPGAVER";
            this.sosuService = sosuService;
            UpdateAssignmentsAsync();
        }

        private async Task UpdateAssignmentsAsync()
        {
            TodaysAssignments.Clear();

            var assignments = await sosuService.GetAssignmentsForAsync(DateTime.Now, new Employee() { EmployeeId = 1 });

            foreach (var assignment in assignments)
            {
                TodaysAssignments.Add(assignment);
            }
        }
    }
}
