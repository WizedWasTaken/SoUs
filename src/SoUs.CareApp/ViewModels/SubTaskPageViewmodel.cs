using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SoUs.Entities;
using SoUs.Services;
using System.Collections.ObjectModel;

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

                int subLength = assignment.SubTasks.Count;

                // Tjek om alle opgaver er udført.
                if (Assignment.SubTasks.Any(e => e.IsCompleted))
                {
                    InfoAlert("Du har ikke gennemført alle opgaverne.");
                    return; 
                }

                await _sousService.UpdateAssignmentAsync(Assignment);
                await Shell.Current.GoToAsync("../");
                return;
            } 
            catch(Exception ex)
            {
                ErrorAlert(ex.Message);
            }
        }
    }
}
