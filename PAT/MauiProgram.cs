using Microsoft.Extensions.Logging;
using PAT.Models;
using PAT.Models.Repositories;
using PAT.Views;

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
        
        builder.Services.AddScoped<IMessageRepository, MessageRepository>();
        builder.Services.AddScoped<IStudentRepository, StudentRepository>();
        builder.Services.AddScoped<IAvailabilityRepository, AvailabilityRepository>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<AvailabilityView>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
