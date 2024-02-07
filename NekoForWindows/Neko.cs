using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace NekoForWindows
{
    internal class Neko
    {
        public static string CrtTime = DateTime.Now.ToString("HH:mm:ss");

        public static string MyDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string CorePath = MyDir + @"\\neko\\core";
        public static string MihomoAmd64 = "NekoForWindows.Core.mihomo-windows-amd64.zip";
        public static string MihomoArm64 = "NekoForWindows.Core.mihomo-windows-arm64.zip";

        public static List<string> NekoLogs = new List<string>();
        public static List<string> CoreLogs = new List<string>();
        public static void CheckDefaultFile()
        {
            NekoLogs.Add($"[ {CrtTime} ] Checking directories"); // Checking Directory
            if (!Directory.Exists(MyDir + @"\\neko"))
            {
                Directory.CreateDirectory(MyDir + @"\\neko");
            }
            if (!Directory.Exists(MyDir + @"\\neko\\config"))
            {
                Directory.CreateDirectory(MyDir + @"\\neko\\config");
            }
            if (!Directory.Exists(MyDir + @"\\neko\\core"))
            {
                Directory.CreateDirectory(MyDir + @"\\neko\\core");
            }
            if (!Directory.Exists(MyDir + @"\\neko\\proxy_provider"))
            {
                Directory.CreateDirectory(MyDir + @"\\neko\\proxy_provider");
            }
            if (!Directory.Exists(MyDir + @"\\neko\\rule_provider"))
            {
                Directory.CreateDirectory(MyDir + @"\\neko\\rule_provider");
            }
            if (!Directory.Exists(MyDir + @"\\neko\\ui"))
            {
                Directory.CreateDirectory(MyDir + @"\\neko\\ui");
            }
            NekoLogs.Add($"[ {CrtTime} ] Checking Arch");
            if (Module.CheckArchitecture() == Architecture.Arm64.ToString())
            {
                NekoLogs.Add($"[ {CrtTime} ] Detected Arch {Module.CheckArchitecture()}");
            }
            else if (Module.CheckArchitecture() == Architecture.X64.ToString())
            {
                NekoLogs.Add($"[ {CrtTime} ] Detected Arch {Module.CheckArchitecture()}");
            }
            else if (Module.CheckArchitecture() == Architecture.X86.ToString())
            {
                NekoLogs.Add($"[ {CrtTime} ] Detected Arch {Module.CheckArchitecture()}");
            }
            else
            {
                NekoLogs.Add($"[ {CrtTime} ] Arch Not Supported For Mihomo Core");
            }
            NekoLogs.Add($"[ {CrtTime} ] Checking Core Mihomo");
            if (!File.Exists(MyDir + @"\\neko\\core\\mihomo.exe"))
            {
                NekoLogs.Add($"[ {CrtTime} ] Core Not Found..");
                NekoLogs.Add($"[ {CrtTime} ] Copy Default Core...");

                if (Module.CheckArchitecture() == Architecture.Arm64.ToString())
                {
                    string targetFilePath = Path.Combine(CorePath, Path.GetFileName(MihomoArm64));
                    Module.CopyResourceToFile(MihomoArm64, targetFilePath);
                    Module.Unzip(targetFilePath, CorePath);
                    Module.RenameFileEx(CorePath, "mihomo-windows-*.exe", "mihomo.exe");
                    File.Delete(targetFilePath);

                }
                else if (Module.CheckArchitecture() == Architecture.X64.ToString())
                {
                    string targetFilePath = Path.Combine(CorePath, Path.GetFileName(MihomoAmd64));
                    Module.CopyResourceToFile(MihomoAmd64, targetFilePath);
                    Module.Unzip(targetFilePath, CorePath);
                    Module.RenameFileEx(CorePath, "mihomo-windows-*.exe", "mihomo.exe");
                    File.Delete(targetFilePath);
                }
                else if (Module.CheckArchitecture() == Architecture.X86.ToString())
                {
                    string targetFilePath = Path.Combine(CorePath, Path.GetFileName(MihomoAmd64));
                    Module.CopyResourceToFile(MihomoAmd64, targetFilePath);
                    Module.Unzip(targetFilePath, CorePath);
                    Module.RenameFileEx(CorePath, "mihomo-windows-*.exe", "mihomo.exe");
                    File.Delete(targetFilePath);
                }
            }
            NekoLogs.Add($"[ {CrtTime} ] Installing Default Config");
            NekoLogs.Add($"[ {CrtTime} ] All Secure");
        }


    }
}
