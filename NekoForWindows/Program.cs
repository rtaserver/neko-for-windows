using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace NekoForWindows
{
    internal static class Program
    {
        static string Version = "v1.1.1-beta";
        static string CoreVersion = "v1.18.0";
        static internal string AppVersion()
        {
            return Version;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Module.CheckAppRunning();

            const string _json = @"NekoForWindows.Newtonsoft.Json.dll";
            const string _Siticone = @"NekoForWindows.Siticone.Desktop.UI.dll";
            const string _Buffers = @"NekoForWindows.System.Buffers.dll";
            const string _Vectors = @"NekoForWindows.System.Numerics.Vectors.dll";
            const string _Yaml = @"NekoForWindows.YamlDotNet.dll";
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            EmbeddedAssembly.Load(_json, _json.Replace("NekoForWindows.", string.Empty));
            EmbeddedAssembly.Load(_Siticone, _Siticone.Replace("NekoForWindows.", string.Empty));
            EmbeddedAssembly.Load(_Buffers, _Buffers.Replace("NekoForWindows.", string.Empty));
            EmbeddedAssembly.Load(_Vectors, _Vectors.Replace("NekoForWindows.", string.Empty));
            EmbeddedAssembly.Load(_Yaml, _Yaml.Replace("NekoForWindows.", string.Empty));

            Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);

            if (!File.Exists(ReadWriteConfig.Temp))
            {
                Module.CopyResourceToFile("NekoForWindows.Config.temp.txt", ReadWriteConfig.Temp);
                ReadWriteConfig.ADDUPDATE(config, "FirstRun", "true");
                ReadWriteConfig.ADDUPDATE(config, "ClientVersion", Version);
                ReadWriteConfig.ADDUPDATE(config, "CoreVersion", CoreVersion);
                ReadWriteConfig.WriteConfigFile(ReadWriteConfig.Temp, config);
            }

            ReadWriteConfig.WriteConfigFile(ReadWriteConfig.Temp, config);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());


        }
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception error = (Exception)e.ExceptionObject;
            MessageBox.Show($"Program.Main-UnhandledException, {error.Message}, {error.StackTrace}");
        }


    }
}
