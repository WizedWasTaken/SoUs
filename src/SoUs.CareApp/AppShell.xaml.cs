using SoUs.CareApp.Views;

namespace SoUs.CareApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes in .NET MAUI
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(SubTaskPage), typeof(SubTaskPage));
        }
    }
}
