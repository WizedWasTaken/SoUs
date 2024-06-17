using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SoUs.CareApp.Views;

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

        /// <summary>
        /// Method to go to previous page.
        /// </summary>
        /// <returns>Nothing</returns>
        [RelayCommand]
        protected static async Task GoToPrevPage()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }

        /// <summary>
        /// Method to display an information alert.
        /// </summary>
        /// <param name="message">Message content</param>
        /// <returns>Alert box.</returns>
        [RelayCommand]
        protected static async Task InfoAlert(string message)
        {
            await Shell.Current.DisplayAlert("Information", message, "OK");
            return;
        }

        /// <summary>
        /// Method to display an error alert.
        /// </summary>
        /// <param name="message">Message content</param>
        /// <returns>Alert box.</returns>
        [RelayCommand]
        protected static async Task ErrorAlert(string message)
        {
            await Shell.Current.DisplayAlert("FEJL", message, "OK");
            return;
        }

        /// <summary>
        /// Method to display an success alert.
        /// </summary>
        /// <param name="message">Message content</param>
        /// <returns>Alert box.</returns>
        [RelayCommand]
        protected static async Task SuccessAlert(string message)
        {
            await Shell.Current.DisplayAlert("Succes", message, "OK");
            return;
        }


        #endregion

        #region Properties

        public bool IsNotBusy => !IsBusy;
        public bool NoError => !ErrorOccurred;

        #endregion
    }
}
