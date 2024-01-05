using MauiReactor;
using Microsoft.Extensions.Logging;
using LineUp.Pages;
using LineUp.Services;
using Microsoft.Extensions.DependencyInjection;


namespace LineUp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiReactorApp<MainPage>(app =>
            {
                app.AddResource("Resources/Styles/Colors.xaml");
                app.AddResource("Resources/Styles/Styles.xaml");
            })
#if DEBUG
            .EnableMauiReactorHotReload()
#endif
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
            });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<IPlayerService, InMemoryPlayerService>();
        return builder.Build();
    }
}
