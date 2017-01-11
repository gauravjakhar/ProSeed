using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using ProSeed_Test.Data_Handling;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace ProSeed_Test.Utilities
{
    public class DriverInit
    {
        public static string URL;
        public static IWebDriver Init()
        {
            string[] xmldata = Xmll.ReadXML();
            URL = xmldata[0];
            string browser = xmldata[1];
            IWebDriver driver;
            string path = @"C:\Testing\Drivers\";
            if (browser.ToLower().Equals("chrome"))
            {
                driver = new ChromeDriver(path);
            }
            else
            if (browser.ToLower().Equals("ie"))
            {
                DesiredCapabilities capabilities = DesiredCapabilities.InternetExplorer();
                capabilities.SetCapability(CapabilityType.AcceptSslCertificates, true);
                capabilities.SetCapability(CapabilityType.HasNativeEvents, false);
                driver = new InternetExplorerDriver(path);
            }
            else
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(path);
                driver = new FirefoxDriver(service);
            }
            return driver;
        }

    }
}