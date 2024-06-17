using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SoUs.CareApp.Views;
using SoUs.Entities;
using SoUs.Services;

namespace SoUs.CareApp.ViewModels
{
    [QueryProperty(nameof(Assignment), "Assignment")]
    public partial class MedicineTaskPageViewmodel : BaseViewModel
    {
        private readonly IAssignmentService _sousService;

        public MedicineTaskPageViewmodel(IAssignmentService sousService)
        {
            _sousService = sousService;
        }

        // Received assignment property.
        [ObservableProperty]
        private Assignment assignment;

        [ObservableProperty]
        private List<MedicineTask> medTasks;

        partial void OnAssignmentChanged(Assignment value)
        {
            MedTasks = Assignment.MedicineTasks;
        }

        [RelayCommand]
        private void SwipeToSubTask()
        {
            var navigationParams = new Dictionary<string, object>
            {
                { "Assignment", Assignment }
            };

            Shell.Current.GoToAsync(nameof(SubTaskPage), true, navigationParams);
        }
    }
}
