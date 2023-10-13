using System.Diagnostics;

namespace AutoStartMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urls = new string[]
            {
                "https://www.pixiv.net/",
                "https://sketch.pixiv.net/",
                "https://twitter.com/home",
                "https://www.facebook.com/",
                "https://www.artstation.com/",
                "https://leetcode.com/",
                "https://www.gamer.com.tw/",
                "https://github.com/",
                "https://www.youtube.com/"
            };

            string? chromePath = GetExecutablePath(@"Google\Chrome\Application\chrome.exe");
            if (chromePath != null)
            {
                foreach (string url in urls)
                {
                    StartProcess(chromePath, url);
                    //Thread.Sleep(1000);  // Wait for 1 second
                }
            }

            string? linePath = GetExecutablePath(@"LINE\bin\LineLauncher.exe");
            if (linePath != null)
            {
                StartProcess(linePath);
            }
        }

        static string? GetExecutablePath(string relativePath)
        {
            string path1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), relativePath);
            string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), relativePath);
            string path3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), relativePath);

            if (File.Exists(path1))
            {
                return path1;
            }
            else if (File.Exists(path2))
            {
                return path2;
            }
            else if (File.Exists(path3))
            {
                return path3;
            }
            else
            {
                Console.WriteLine($"Executable not found: {relativePath}");
                return null;
            }
        }

        static void StartProcess(string executablePath, string? arguments = null)
        {
            try
            {
                if (arguments != null)
                {
                    Process.Start(executablePath, arguments);
                }
                else
                {
                    Process.Start(executablePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to start process: {ex.Message}");
            }
        }
    }
}