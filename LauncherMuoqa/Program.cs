using System.Diagnostics;
using System.Xml.Linq;
using System.IO;

internal static class Program
{
    static void Main(String[] args)
    {
        try
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Para obtener la direcion del "Escritorio"
            string developmentEnvironment = "C:\\Users\\Joaquin\\Desktop\\Proyectos\\Trabajo\\AppServiceMuoqa\\ServicesMuoqa\\LauncherMuoqa\\bin\\Debug\\net8.0\\";
            if (developmentEnvironment != executablePath)
            {
                if (!Directory.Exists($"{executablePath}\\ArchivosMuoqa"))
                {
                    Directory.CreateDirectory($"{executablePath}\\ArchivosMuoqa");
                }
                double currentVersion = ReadXml(executablePath);
                if (CheckVersion(currentVersion))
                    UpdateVersion(executablePath);
                string exe = $"{executablePath}\\ArchivosMuoqa\\ServicesMuoqa.exe";
                if (File.Exists(exe))
                {
                    Process.Start(exe);
                    Environment.Exit(0);
                }
            }
            else
            {
                if (!Directory.Exists($"{desktopPath}\\ArchivosMuoqa"))
                {
                    Directory.CreateDirectory($"{desktopPath}\\ArchivosMuoqa");
                }
                double currentVersion = ReadXml(executablePath);
                if (CheckVersion(currentVersion))
                    UpdateVersion(desktopPath);
                string exe = $"{desktopPath}\\ArchivosMuoqa\\ServicesMuoqa.exe";
                if (File.Exists(exe))
                {
                    Process.Start(exe);
                    Environment.Exit(0);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());   
        }
    }
    static void UpdateVersion(string executablePath)
    {
        string command = $"curl -o {executablePath}\\ArchivosMuoqa\\AppMuoqa.zip https://muoqa.com/UpdateVersion/AppEjemplo.zip";
        string commandTwo = $"powershell -command \"Expand-Archive -Path '{executablePath}\\ArchivosMuoqa\\AppMuoqa.zip' -DestinationPath '{executablePath}\\ArchivosMuoqa' -Force \"";
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
            using (Process process = new Process { StartInfo = psi })
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
            Console.WriteLine($"{ex.Message} |----- Error {ex}");
            throw;
        }
    }

    static double ReadXml(string executablePath)
    {
        try
        {
            double versionF = 0.1;
            string directoryPath = $"{executablePath}\\ArchivosMuoqa";
            // Combinar la ruta del directorio con el nombre del archivo
            string xmlPath = Path.Combine(directoryPath, "Version", "Version.xml");
            XDocument xmlDoc = new XDocument();
            // Leer el archivo XML
            if (Directory.Exists(xmlPath))
            {
                xmlDoc = XDocument.Load(xmlPath);
                //Para mostrar algun valor especifico de un elemento del xml
                string version = xmlDoc.Descendants("AppInfo")
                    .Select(p => p.Element("Version").Value)
                    .FirstOrDefault() ?? throw new Exception("No se puede encontrar la version actual, cargaremos la version mas reciente");
                versionF = double.Parse(version);
            }
            return versionF;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un problema al leer la version del archivo xml. \n" + ex.Message + " SE INTENTARA CONTINUAR CON LOS ARCHIVOS EXISTENTES");
            return 0.0;
        }
    }
}