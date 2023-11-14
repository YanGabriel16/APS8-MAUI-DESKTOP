using APS8_MAUI_DESKTOP.Services;
using Microsoft.Extensions.Logging;
using Radzen;

namespace APS8_MAUI_DESKTOP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddRadzenComponents();
            builder.Services.AddScoped<HttpClient>();

            builder.Services.AddBlazorWebViewDeveloperTools();
#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddScoped<LocalService>();

            return builder.Build();
        }
    }
}