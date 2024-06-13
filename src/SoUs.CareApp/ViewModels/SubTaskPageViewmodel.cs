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

        // Original received assignment property.
        // Used for reverting changes on client if going back.
        private Assignment originalAssignment;

        // Received assignment property.
        [ObservableProperty]
        private Assignment assignment;

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
                if (Assignment.SubTasks.All(e => !e.IsCompleted))
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
