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
        protected static void NoWorkey(string message)
        {
            Shell.Current.DisplayAlert("Fejl", message, "OK");
        }

        #endregion

        #region Properties

        public bool IsNotBusy => !IsBusy;
        public bool NoError => !ErrorOccurred;

        #endregion
    }
}
