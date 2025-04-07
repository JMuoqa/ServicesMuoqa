using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using ServicesMuoqa.Views;
using DataBaseServicesMuoqa;
using BackendServicesMuoqa;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;
using Renci.SshNet;
using MySqlX.XDevAPI;
using Renci.SshNet.Common;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Policy;
using System.Collections.Generic;

namespace ServicesMuoqa
{
    internal static class Program
    {
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
                services.AddTransient<StatisticsView>();
                services.AddTransient<UploadJob>();
                services.AddTransient<MainView>();
                services.AddTransient<Inicio>();
                services.AddScoped<ManageServices>();
                services.AddScoped<Jobs>();
            });
        }
    }
}