using CommunityToolkit.Mvvm.ComponentModel;
using SoUs.Entities;

namespace SoUs.CareApp.ViewModels
{
    [QueryProperty(nameof(Assignment), "Assignment")]
    public partial class SubTaskPageViewmodel : BaseViewModel
    {
        public SubTaskPageViewmodel()
        {
        }

        [ObservableProperty]
        Assignment assignment; // Hoved opgaven.
    }
}
