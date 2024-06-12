using Microsoft.Extensions.Logging;
using SoUs.CareApp.ViewModels;
using SoUs.CareApp.Views;
using SoUs.Services;

namespace SoUs.CareApp
{
    public static class MauiProgram
    {
        private const string baseUri = "https://10.0.2.2:7093/api/";

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            Uri uri = new(baseUri);


            builder.Services.AddScoped<IAssignmentService>(x => new AssignmentService(uri));
            builder.Services.AddScoped<IEmployeeService>(x => new EmployeeService(uri));

            builder.Services.AddSingleton<LogIndPageViewmodel>();
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<SubTaskPageViewmodel>();

            builder.Services.AddSingleton<LogIndPage>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<SubTaskPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
#if ANDROID
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#endif
            });

            return builder.Build();
        }
    }
}
