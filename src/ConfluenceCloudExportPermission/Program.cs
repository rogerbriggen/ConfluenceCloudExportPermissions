using ConfluenceCloudExportPermissionLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace ConfluenceCloudExportPermission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup log with DI
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var logger = serviceProvider.GetService<ILogger<Program>>();
            
            logger.LogDebug("Application started");
            
            var myClass = serviceProvider.GetService<ExportZipFile>();

            myClass.TestMethod();

            logger.LogDebug("Application closing...");
            serviceProvider.Dispose();

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //we will configure logging here
            services.AddLogging(configure => configure.AddConsole(consoleLoggerOptions => consoleLoggerOptions.TimestampFormat = "[dd.MM.yyyy HH:mm:ss.fff]")).Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Debug).AddTransient<ExportZipFile>();
            services.AddLogging(configure => configure.AddDebug()).Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Debug).AddTransient<ExportZipFile>();
        }

        
    }
}
