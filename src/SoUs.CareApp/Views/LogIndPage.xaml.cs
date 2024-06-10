using SoUs.CareApp.ViewModels;

namespace SoUs.CareApp.Views;

public partial class LogIndPage : ContentPage
{
    public LogIndPage(LogIndPageViewmodel viewmodel)
    {
        InitializeComponent();
        BindingContext = viewmodel;
    }
}