using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SoUs.Entities;

namespace SoUs.CareApp.ViewModels
{
    public partial class LogIndPageViewmodel : BaseViewModel
    {
        public LogIndPageViewmodel()
        {
        }

        [ObservableProperty]
        private string userId;

        [RelayCommand]
        private void SubmitUserId()
        {
            if (IsInteger(UserId) && UserId != null)
            {
                NoWorkey("Det virker!");
            }

            NoWorkey("Ugyldigt bruger ID.");
            return;
        }

        private bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
