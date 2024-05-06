using MauiSqlite;
using Microsoft.Extensions.Logging;
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
            SQLitePCL.Batteries.Init();
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<IAdminRepository, AdminRepository>();
            builder.Services.AddTransient<IAvailabilityRepository, AvailabilityRepository>();
            builder.Services.AddTransient<ICourseRepository, CourseRepository>();
            builder.Services.AddTransient<IMessageRepository, MessageRepository>();
            builder.Services.AddTransient<IPairTutoringArrangementRepository, PairTutoringArrangementRepository>();
            builder.Services.AddTransient<IProgramRepository, ProgramRepository>();
            builder.Services.AddTransient<ISessionRepository, SessionRepository>();
            builder.Services.AddTransient<IStudentCoursePerformanceRepository, StudentCoursePerformanceRepository>();
            builder.Services.AddTransient<IStudentRepository, StudentRepository>();
            builder.Services.AddTransient<IStudentTypeRepository, StudentTypeRepository>();
            builder.Services.AddTransient<IStudentPairMatchRepository, StudentPairMatchRepository>();
            builder.Services.AddTransient<ITeacherRepository, TeacherRepository>();
            builder.Services.AddScoped<AppDbContext, AppDbContext>();
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

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