using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekoForWindows
{
    internal class ReadWriteConfig
    {
        // EXAMPLE
        // Read configuration
        // Dictionary<string, string> config = ReadConfigFile(configFile);

        // Display values
        // foreach (var kvp in config)
        // {
        //    Console.WriteLine($"{kvp.Key} = {kvp.Value}");
        // }

        // Modify a value
        // config["Port"] = "8080";

        // Write configuration
        // WriteConfigFile(configFile, config);

        static string Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "rtaserver");
        public static string Temp = Path.Combine(Folder, "Temp.txt");
        public static Dictionary<string, string> ReadConfigFile(string filePath)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        config[key] = value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading config file: {ex.Message}");
            }

            return config;
        }

        public static string GetValueForKey(Dictionary<string, string> config, string key)
        {
            if (config.ContainsKey(key))
            {
                return config[key];
            }
            else
            {
                Console.WriteLine($"Key '{key}' not found in the configuration file.");
                return null; // or throw an exception, depending on your error-handling strategy
            }
        }

        public static void ADDUPDATE(Dictionary<string, string> config, string key, string value)
        {
            if (config.ContainsKey(key))
            {
                // Update existing option
                config[key] = value;
            }
            else
            {
                // Add new option
                config.Add(key, value);
            }
        }

        public static void WriteConfigFile(string filePath, Dictionary<string, string> config)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var kvp in config)
                    {
                        writer.WriteLine($"{kvp.Key} = {kvp.Value}");
                    }
                }

                Console.WriteLine("Config file updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing config file: {ex.Message}");
            }
        }
    }
}
