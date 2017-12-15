using OpenQA.Selenium;

namespace ObjectLibrary.Pages
{
    public partial class PageFactories
    {
        public readonly ProSeedLoginPage LoginPage;
        public readonly ProSeedHomePage HomePage;
        public readonly ProSeedAdminPage AdminPage;

        public PageFactories(IWebDriver driver)
        {
            LoginPage = new ProSeedLoginPage(driver);
            HomePage = new ProSeedHomePage(driver);
            AdminPage = new ProSeedAdminPage(driver);
        }


    }
}
