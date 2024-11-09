using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using ServicesMuoqa.Views;
using DataBaseServicesMuoqa;
using BackendServicesMuoqa;

namespace ServicesMuoqa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            using (var serviceScope = host.Services.CreateScope()) 
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    var mainForm = services.GetRequiredService<Inicio>(); 
                    Application.Run(mainForm);
                }
                catch (Exception ex)
                {   
                    Console.WriteLine(ex);
                    MessageBox.Show($"{ex.Message} |----- Error {ex}");
                }
            }
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureAppConfiguration/*Esto es para a�adir archivos de configuracion*/((context, config) =>
            {
                // Configuraci�n adicional si es necesaria
            }).ConfigureServices((context, services) =>
            {
                string connectionString2 = Environment.GetEnvironmentVariable("MuoqaBD");
                services.AddDbContext<Connection>(options =>
                options.UseMySQL(connectionString2));
                services.AddDbContext<Connection>();
                services.AddTransient<ViewMain>();
                services.AddTransient<Inicio>();
                services.AddScoped<AdministrationServcices>();
            });
        }
    }
}