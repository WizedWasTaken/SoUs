using Microsoft.Extensions.Logging;
using SoUs.CareApp.ViewModels;
using SoUs.CareApp.Views;
using SoUs.Services;

namespace SoUs.CareApp
{
    public static class MauiProgram
    {
        private const string baseUri = "https://localhost:7093/api/";

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
            builder.Services.AddScoped<ISoUsService>(x => new SoUsService(uri));
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
