using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace WebdriverAndLogging
{
    public class DriverInit
    {
        public static string URL;
        public static IWebDriver Init()
        {
            string[] xmldata = Xmll.PickBrowserAndURLFromXmlFile();
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