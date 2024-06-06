using SoUs.CareApp.Views;

namespace SoUs.CareApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SubTaskPage), typeof(SubTaskPage));
        }
    }
}
