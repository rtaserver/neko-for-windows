using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;

namespace NekoForWindows
{
    internal class Module
    {
        public static void Unzip(string zipFilePath, string extractFolder)
        {
            try
            {
                // Create the target extraction folder if it doesn't exist
                if (!Directory.Exists(extractFolder))
                {
                    Directory.CreateDirectory(extractFolder);
                }

                // Extract the contents of the ZIP file
                ZipFile.ExtractToDirectory(zipFilePath, extractFolder);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void RenameFile(string currentFilePath, string newFileName)
        {
            try
            {
                // Combine the directory and new file name to get the full new file path
                string newFilePath = Path.Combine(Path.GetDirectoryName(currentFilePath), newFileName);

                // Rename the file
                File.Move(currentFilePath, newFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void RenameFileEx(string directoryPath, string pattern, string newFileName)
        {
            try
            {
                // Get files in the directory that match the pattern
                string[] matchingFiles = Directory.GetFiles(directoryPath, pattern);

                // Check if there is exactly one matching file
                if (matchingFiles.Length == 1)
                {
                    string oldFilePath = matchingFiles.First();

                    // Extract the file name from the old file path
                    string oldFileName = Path.GetFileName(oldFilePath);

                    // Use regex to replace the part of the file name that matches the pattern
                    string newFileNameWithPattern = Regex.Replace(oldFileName, "mihomo-windows-.*\\.exe", newFileName);

                    // Create the new file path
                    string newFilePath = Path.Combine(directoryPath, newFileNameWithPattern);

                    // Rename the file
                    File.Move(oldFilePath, newFilePath);
                }
                else
                {
                    Console.WriteLine("Error: No matching file found or multiple matching files.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static async Task<string> GetMyIPAddress()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Use a service like httpbin to get your public IP address
                    HttpResponseMessage response = await client.GetAsync("https://httpbin.org/ip");

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a JSON string
                        string jsonContent = await response.Content.ReadAsStringAsync();

                        // Parse the JSON string to get the "origin" field, which contains the IP address
                        int startIndex = jsonContent.IndexOf('"');
                        int endIndex = jsonContent.LastIndexOf('"');
                        string ipAddress = jsonContent.Substring(startIndex, endIndex - startIndex);

                        return ipAddress;
                    }
                    else
                    {
                        return "Failed to retrieve IP address. Status code: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
        }

        public static string CheckArchitecture()
        {
            return RuntimeInformation.ProcessArchitecture.ToString();
        }

        public static void CopyResourceToFile(string resourceName, string targetFilePath)
        {
            // Get the assembly containing the embedded resource
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Create a temporary file to extract the embedded resource
            string tempFilePath = Path.GetTempFileName();

            // Open the embedded resource stream and copy it to the temporary file
            using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
            using (FileStream tempFileStream = File.Create(tempFilePath))
            {
                resourceStream.CopyTo(tempFileStream);
            }

            // Copy the temporary file to the target destination
            File.Copy(tempFilePath, targetFilePath, true);

            // Delete the temporary file
            File.Delete(tempFilePath);
        }

        public static string InterFaceName()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            if (interfaces.Length > 0)
            {
                NetworkInterface networkInterface = interfaces[0];
                {
                    return (networkInterface.Name);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<string> GetLatestTagBodyGithub(string owner, string repo,bool getbody = false) // If True Get String Body
        {
            try
            {
                string latestReleaseUrl = $"https://api.github.com/repos/{owner}/{repo}/releases/latest";

                string sTag = string.Empty ;
                string sBody = string.Empty ;

                using (HttpClient client = new HttpClient())
                {
                    // Set up headers to mimic a request from a browser
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                    // Send the GET request to the GitHub API
                    HttpResponseMessage response = await client.GetAsync(latestReleaseUrl);

                    // Check if the request was successful (status code 200 OK)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content as a string
                        string jsonContent = await response.Content.ReadAsStringAsync();
                      

                        sTag = Newtonsoft.Json.JsonConvert.DeserializeObject<GitHubRelease>(jsonContent).tag_name; // Tag
                        sBody = Newtonsoft.Json.JsonConvert.DeserializeObject<GitHubRelease>(jsonContent).body; // Readme
                        // Parse JSON
                        if (!getbody)
                        {
                            return sTag;
                        }
                        else
                        {
                            return sBody;
                        }

                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }

        public class GitHubRelease
        {
            public string tag_name { get; set; }
            public string body { get; set; }
        }

        public static string port;
        public static string redirPort;
        public static string socksPort;
        public static string mixedPort;
        public static string tproxyPort;
        public static string mode;
        public static string enhancedMode;
        public static string secret;
        public static string externalController;
        public static void ReadConfig(string path)
        {
            string yamlContent = File.ReadAllText(path);

            // Parse YAML
            var yamlStream = new YamlStream();
            yamlStream.Load(new StringReader(yamlContent));

            // Get the root node
            var rootNode = yamlStream.Documents[0].RootNode as YamlMappingNode;
            if (rootNode != null)
            {
                // Get values
                 port = GetNodeValue(rootNode, "port");
                 socksPort = GetNodeValue(rootNode, "socks-port");
                 redirPort = GetNodeValue(rootNode, "redir-port");
                 mixedPort = GetNodeValue(rootNode, "mixed-port");
                 tproxyPort = GetNodeValue(rootNode, "tproxy-port");
                 mode = GetNodeValue(rootNode, "mode");
                 secret = GetNodeValue(rootNode, "secret");
                 externalController = GetNodeValue(rootNode, "external-controller");

                 enhancedMode = string.Empty;
                // Get the DNS node
                var dnsNode = rootNode.Children[new YamlScalarNode("dns")] as YamlMappingNode;
                if (dnsNode != null)
                {
                    enhancedMode = GetNodeValue(dnsNode, "enhanced-mode");
                }
            }

        }


        static string GetNodeValue(YamlMappingNode rootNode, string key)
        {
            var node = rootNode.Children[new YamlScalarNode(key)];
            return node?.ToString();
        }

        public static string CekOSWindows()
        {
            // Get the version of the operating system
            System.Version osVersion = Environment.OSVersion.Version;

            // Check Windows version
            if (osVersion.Major == 10 && osVersion.Minor == 0)
            {
                return ("Windows 10 / 11");
            }
            else if (osVersion.Major == 6 && osVersion.Minor == 3)
            {
                return ("Windows 8.1");
            }
            else if (osVersion.Major == 6 && osVersion.Minor == 2)
            {
               return ("Windows 11 / 8");
            }
            else if (osVersion.Major == 6 && osVersion.Minor == 1)
            {
                return ("Windows 7");
            }
            else if (osVersion.Major == 6 && osVersion.Minor == 0)
            {
                return ("Windows Vista");
            }
            else
            {
                return ($"Unknown Windows version: {osVersion}");
            }
        }

        public string ParseChangelog(string log)
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            List<string> changelogText = new List<string>();

            try
            {
                changelogText = log.Trim().Split(
                    new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Neko For Windows", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }

            if (changelogText.Count == 0) return string.Empty;

            int markVersion = 0;
            for (int d = 0; d < changelogText.Count; d++)
            {
                if (changelogText[d].Contains($"## NEKO [{Program.AppVersion()}]"))
                {
                    markVersion = d;
                    break;
                }
                else continue;
            }

            changelogText.RemoveRange(markVersion, changelogText.Count - markVersion);

            if (changelogText.Count <= 0)
            {
                MessageBox.Show("You already have the latest version!", "Neko For Windows", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }

            return string.Join(Environment.NewLine, changelogText).Replace("##", "➤");
        }

        static int colorIndex = 0;
        public static void RaibowText(Label label)
        {
            
            Color[] rainbowColors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
            label.ForeColor = rainbowColors[colorIndex];
            colorIndex = (colorIndex + 1) % rainbowColors.Length;
        }

        public static void CheckAppRunning()
        {
            // Define a unique name for the mutex
            string mutexName = "NekoForWindows";

            // Attempt to create a named mutex
            using (Mutex mutex = new Mutex(true, mutexName, out bool createdNew))
            {
                // Check if the mutex was successfully created
                if (!createdNew)
                {
                    // Another instance is already running, so exit
                    MessageBox.Show("Another instance of the program is already running.","Neko For Windows",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }

        public static Color GetFormBackColor(string argb)
        {
            // Split the string by commas
            string[] parts = argb.Split(',');

            // Ensure we have exactly 3 parts
            if (parts.Length != 3)
            {
                throw new ArgumentException("Invalid ARGB format. It should be three comma-separated integers.");
            }

            // Parse each part as integer
            int alpha = 255; // default alpha value
            int red = int.Parse(parts[0].Trim());
            int green = int.Parse(parts[1].Trim());
            int blue = int.Parse(parts[2].Trim());

            // Create a color object
            Color color = Color.FromArgb(alpha, red, green, blue);

            // Set the back color of the form
            return color;
        }
        public static void SetFormBackColor(Form frm,string argb)
        {
            // Split the string by commas
            string[] parts = argb.Split(',');

            // Ensure we have exactly 3 parts
            if (parts.Length != 3)
            {
                throw new ArgumentException("Invalid ARGB format. It should be three comma-separated integers.");
            }

            // Parse each part as integer
            int alpha = 255; // default alpha value
            int red = int.Parse(parts[0].Trim());
            int green = int.Parse(parts[1].Trim());
            int blue = int.Parse(parts[2].Trim());

            // Create a color object
            Color color = Color.FromArgb(alpha, red, green, blue);

            // Set the back color of the form
            frm.BackColor = color;
        }

        public static string GetRGBString(Color color)
        {
            return $"{color.R}, {color.G}, {color.B}";
        }

    }
}
