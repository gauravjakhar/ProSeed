﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProceedSolution.Temp;
using ProSeed_Test.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProceedSolution
{
    [Binding]
    public class ProSeedLoginPage
    {
        IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'userid_inputtext')]")]
        public IWebElement txtEmail;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'password_inputtext')]")]
        public IWebElement txtPwd;

        [FindsBy(How = How.XPath, Using = "//button[contains(@id,'sign_in_button')]")]
        public IWebElement btnLogin;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Invalid')]")]
        public IWebElement msgInvalidEmail;

        public ProSeedLoginPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String getTitle()
        {
            return _driver.Title;
        }
        public void enterUidPassword(String Email, String Password)
        {
            txtEmail.SendKeysCustom(Email, "Email");
            txtPwd.SendKeysCustom(Password, "Password");
        }

        public void clickLogin()
        {
            btnLogin.ClickCustom("Login");
        }

        public void OpenApplication()
        {
            IWebDriver driver = _driver;
            _driver.Navigate().GoToUrl(DriverInit.URL);
            Thread.Sleep(2000);
            //_driver.SwithWindowByTitle("Sign");
        }

        public String getInvalidEmailMsg()
        {
            return msgInvalidEmail.Text;
        }

    }




}