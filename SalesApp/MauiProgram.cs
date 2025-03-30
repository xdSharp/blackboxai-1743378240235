using Microsoft.Extensions.Logging;
using SalesApp.ViewModels;
using SalesApp.Views;

namespace SalesApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler(typeof(Shell), typeof(ShellHandler));
            });

        // Регистрация ViewModels
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<RegistrationViewModel>();
        builder.Services.AddSingleton<MainViewModel>();

        // Регистрация Views
        builder.Services.AddSingleton<LoginView>();
        builder.Services.AddSingleton<RegistrationView>();
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}