using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SoUs.CareApp.Views;
using SoUs.Entities;
using SoUs.Services;

namespace SoUs.CareApp.ViewModels
{
    [QueryProperty(nameof(Assignment), "Assignment")]
    public partial class SubTaskPageViewmodel : BaseViewModel
    {
        private readonly IAssignmentService _sousService;

        public SubTaskPageViewmodel(IAssignmentService sousService)
        {
            _sousService = sousService;
        }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsMedTaskNotEmpty))]
        private bool isMedTaskEmpty;

        public bool IsMedTaskNotEmpty => !IsMedTaskEmpty;

        // Received assignment property.
        [ObservableProperty]
        private Assignment assignment;

        partial void OnAssignmentChanged(Assignment? oldValue, Assignment newValue)
        {
            UpdateIsMedTaskEmpty();
        }

        private void UpdateIsMedTaskEmpty()
        {
            if (Assignment is null)
                return; 

            IsMedTaskEmpty = Assignment.MedicineTasks.Count == 0;
        }

        [RelayCommand]
        private async Task SwipeToMedTasks()
        {
            // This should never be true...
            if (IsMedTaskEmpty)
            {
                return;
            }

            var navigationParams = new Dictionary<string, object>
            {
                { "Assignment", Assignment }
            };

            await Shell.Current.GoToAsync(nameof(MedicineTaskPage), true, navigationParams);
        }

        /// <summary>
        /// Submit assignment to database.
        /// </summary>
        /// <returns>Void</returns>
        [RelayCommand]
        private async Task SubmitAssignment()
        {
            try {
                List<MedicineTask> medTasks = Assignment.MedicineTasks;
                // Tjek om alle opgaver er udført.
                if (Assignment.SubTasks.All(e => !e.IsCompleted) || IsMedTaskNotEmpty && Assignment.MedicineTasks.All(e => !e.IsCompleted))
                {
                    InfoAlert("Du har ikke gennemført alle opgaverne.");
                    return; 
                }

                await _sousService.UpdateAssignmentAsync(Assignment);
                await Shell.Current.GoToAsync(nameof(MainPage));
                return;
            } 
            catch(Exception ex)
            {
                ErrorAlert(ex.Message);
            }
        }
    }
}
