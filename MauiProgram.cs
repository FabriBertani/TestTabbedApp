using Microsoft.Extensions.Logging;
using TestTabbedApp.ViewModels;
using TestTabbedApp.Views;

namespace TestTabbedApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .RegisterViewModels()
            .RegisterViews()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<LoginPage>();
        mauiAppBuilder.Services.AddSingleton<MainPage>();
        mauiAppBuilder.Services.AddSingleton<DetailsPage>();
        mauiAppBuilder.Services.AddSingleton<FirstTabPage>();
        mauiAppBuilder.Services.AddSingleton<SecondTabPage>();
        mauiAppBuilder.Services.AddSingleton<ThirdTabPage>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<LoginViewModel>();
        mauiAppBuilder.Services.AddSingleton<MainViewModel>();
        mauiAppBuilder.Services.AddSingleton<DetailsViewModel>();
        mauiAppBuilder.Services.AddSingleton<RootTabsViewModel>();

        return mauiAppBuilder;
    }
}