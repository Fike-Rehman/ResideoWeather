using Microsoft.Extensions.DependencyInjection;

namespace ResideoWeather
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            var resideoWeather = serviceProvider.GetRequiredService<ResideoWeather>();
            Application.Run(resideoWeather);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add services to the container.
            services.AddSingleton<ResideoWeather>();
            services.AddSingleton<IRemoteDataImporter, RemoteDataImporter>();
            services.AddSingleton<IResideoWeatherReportFormatter, ResideoWeatherReportFormatter>();
        }
    }
}