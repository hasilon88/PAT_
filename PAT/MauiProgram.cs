using Microsoft.Extensions.Logging;
using PAT.Models;
using PAT.Models.Repositories;

namespace PAT;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        SQLitePCL.Batteries.Init();
        builder.Services.AddDbContext<PatDbContext>();
        
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddTransient<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}