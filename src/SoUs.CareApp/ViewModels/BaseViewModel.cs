using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SoUs.CareApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        #region Fields

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(NoError))]
        private bool errorOccurred;

        [ObservableProperty]
        private string title = string.Empty;

        #endregion

        #region Constructors

        public BaseViewModel() { }

        #endregion

        #region Commands

        [RelayCommand]
        protected static void ErrorAlert(string message)
        {
            Shell.Current.DisplayAlert("FEJL", message, "OK");
        }

        [RelayCommand]
        protected static void SuccessAlert(string message)
        {
            Shell.Current.DisplayAlert("Succes", message, "OK");
        }

        [RelayCommand]
        protected static void InfoAlert(string message)
        {
            Shell.Current.DisplayAlert("Information", message, "OK");
        }

        #endregion

        #region Properties

        public bool IsNotBusy => !IsBusy;
        public bool NoError => !ErrorOccurred;

        #endregion
    }
}
