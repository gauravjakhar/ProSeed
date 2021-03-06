﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using CustomizedExtendedMethods;
using TechTalk.SpecFlow;
using WebdriverAndLogging;

namespace ObjectLibrary.Pages
{
    [Binding]
    public class ProSeedLoginPage
    {
        IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'userid_inputtext')]")]
        public IWebElement txtEmail;

        //http://g.kumar:Jan@12345@172.20.1.116

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'password_inputtext')]")]
        public IWebElement txtPwd;

        [FindsBy(How = How.XPath, Using = "//button[contains(@id,'sign_in_button')]")]
        public IWebElement btnLogin;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Invalid')]")]
        public IWebElement msgInvalidEmail;

        [FindsBy(How = How.XPath, Using = "//li[contains(@id,'login_user_chooser')]")]
        public IWebElement storedUser;

        [FindsBy(How = How.XPath, Using = "//table[contains(@id,'use_another_account')]")]
        public IWebElement useAnother;
        
        public ProSeedLoginPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String getTitle()
        {
            return _driver.Title;
        }
        public void EnterUidandPwd(String Email, String Password)
        {
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));           
            if (storedUser.Displayed)
            {
                useAnother.ClickCustom("Another Account");
            }
            txtEmail.SendKeysCustom(Email, "Email");
            txtPwd.SendKeysCustom(Password, "Password");
            Thread.Sleep(5000);
        }

        public void clickLogin()
        {
            btnLogin.ClickCustom("Login");
        }

        public void OpenApplication()
        {
            IWebDriver driver = _driver;
            _driver.Navigate().GoToUrl(DriverInit.URL);
            Logger.WriteLineInFile("URL Open", "pass");
            Thread.Sleep(2000);
            //_driver.SwithWindowByTitle("Sign");
        }

        public String getInvalidEmailMsg()
        {
            return msgInvalidEmail.Text;
        }
    }
}