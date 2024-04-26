using Microsoft.Extensions.Logging;
using PAT.Models;
using PAT.Models.Repositories;
using PAT.Models.Repositories.Interfaces;
using PAT.ViewModels;
using PAT.Views;

namespace PAT
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            SQLitePCL.Batteries.Init();
            builder.Services.AddDbContext<PatDbContext>();

            builder.Services.AddSingleton<IMessageRepository, MessageRepository>();
            builder.Services.AddSingleton<IAdminRepository, AdminRepository>();
            builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
            builder.Services.AddSingleton<ITeacherRepository, TeacherRepository>();

            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MesServicesTutoratPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}