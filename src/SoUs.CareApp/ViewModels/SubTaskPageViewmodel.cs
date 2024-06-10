using CommunityToolkit.Mvvm.ComponentModel;
using SoUs.Entities;
using System.Collections.ObjectModel;
using System.Linq;

namespace SoUs.CareApp.ViewModels
{
    [QueryProperty(nameof(Assignment), "Assignment")]
    public partial class SubTaskPageViewModel : BaseViewModel
    {
        public SubTaskPageViewModel()
        {
            SubTasks = new ObservableCollection<SubTask>();
        }

        [ObservableProperty]
        private Assignment assignment;

        [ObservableProperty]
        private ObservableCollection<SubTask> subTasks;

        partial void OnAssignmentChanged(Assignment value)
        {
            // Update SubTasks collection based on the new Assignment
            // ChatGPT coming in clutch, once again.
            SubTasks.Clear();
            if (value?.SubTasks != null)
            {
                foreach (var subTask in value.SubTasks)
                {
                    SubTasks.Add(subTask);
                }
            }
        }
    }
}
