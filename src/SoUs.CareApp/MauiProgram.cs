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
            // Er Singleton det korrekte, eller skal det være Scoped?
            // Singleton fordi der er fejl i alt andet...
            builder.Services.AddScoped<ISoUsService>(x => new SoUsService(uri));
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<SubTaskPageViewmodel>();
            builder.Services.AddSingleton<SubTaskPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
