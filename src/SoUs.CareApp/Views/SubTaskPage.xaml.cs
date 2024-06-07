using SoUs.CareApp.ViewModels;

namespace SoUs.CareApp.Views
{
    public partial class SubTaskPage : ContentPage
    {
        public SubTaskPage(SubTaskPageViewmodel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected void OnAppearing()
        {
            base.OnAppearing();
        }
    }

}
