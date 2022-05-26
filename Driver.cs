using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SamirCourse
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        //Default Constructor
        public static void Initialize()
        {
            Instance = new ChromeDriver();

            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));

            Instance.Manage().Window.Maximize();
        }

        public static void Initialize(int n)
        {

            if (n == 1)
            {
                
            }
            else if (n == 2)
            {
                var downloadDirectory = @"C:\Files";
                ChromeOptions options = new ChromeOptions();

                options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                options.AddUserProfilePreference("download.prompt_for_download", false);
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                options.AddUserProfilePreference("plugins.plugins_disabled", new[] {
                "Adobe Flash Player",
                "Chrome PDF Viewer"
                                                                                   });

                Instance = new ChromeDriver(@"C:\Drivers\", options);
                Instance.Manage().Window.Maximize();

            }

            else if (n == 3)
            {
                

            }

            else if (n == 4)
            {
                


            }
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}
