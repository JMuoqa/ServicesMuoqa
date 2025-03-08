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

            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string developmentEnvironment = "C:\\Users\\Joaquin\\Desktop\\Proyectos\\Trabajo\\AppServiceMuoqa\\ServicesMuoqa\\ServicesMuoqa\\bin\\Debug\\net8.0-windows\\";
            if (developmentEnvironment != executablePath)
            {
                double currentVersion = ReadXml(executablePath);
                if (CheckVersion(currentVersion))
                    UpdateVersion(executablePath);
            }
            else
            {
                double currentVersion = ReadXml(executablePath);
                if (CheckVersion(currentVersion))
                    UpdateVersion("C:\\Users\\Joaquin\\Desktop");
            }

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
        static void UpdateVersion(string executablePath)
        {
            string command = $"curl -o {executablePath}\\AppMuoqa.zip https://muoqa.com/UpdateVersion/AppEjemplo.zip";
            string commandTwo = $"powershell -command \"Expand-Archive -Path '{executablePath}\\AppMuoqa.zip' -DestinationPath 'C:\\Users\\Joaquin\\Desktop\\CarpetaDescomprimida\\' -Force \"";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = psi}) 
                {
                    process.Start();
                    using (var sw = process.StandardInput)
                    {
                        sw.WriteLine(command);
                        sw.WriteLine(commandTwo);
                        sw.WriteLine("exit");
                    }
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"{ex.Message} |----- Error {ex}");
            }
        }

        static bool CheckVersion(double currentVersion)
        {
            try
            {
                double latestVersion = 0;
                string url = "https://muoqa.com/CheckVersion/Version.xml";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "curl",
                    Arguments = url,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = psi })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    XDocument xmlDoc = XDocument.Parse(output);
                    string version = xmlDoc.Descendants("AppInfo")
                        .Select(p => p.Element("Version").Value)
                        .FirstOrDefault() ?? throw new Exception("No se puede encontrar la version actual, cargaremos la version mas reciente");
                    latestVersion = double.Parse(version);
                }
                if (currentVersion >= latestVersion) 
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} |----- Error {ex}");
                throw;
            }
        }

        static double ReadXml(string executablePath)
        {
            try
            {
                string directoryPath = executablePath;
                // Combinar la ruta del directorio con el nombre del archivo
                string xmlPath = Path.Combine(directoryPath, "Version", "Version.xml");
                // Leer el archivo XML
                XDocument xmlDoc = XDocument.Load(xmlPath);

                //Para mostrar algun valor especifico de un elemento del xml
                double versionF = 0.1;
                string version = xmlDoc.Descendants("AppInfo")
                    .Select(p => p.Element("Version").Value)
                    .FirstOrDefault() ?? throw new Exception("No se puede encontrar la version actual, cargaremos la version mas reciente");

                versionF = double.Parse(version);

                return versionF;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al leer la version del archivo xml. \n" +ex.Message + " SE INTENTARA CONTINUAR CON LOS ARCHIVOS EXISTENTES");
                return 0.0;
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