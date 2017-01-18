using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProceedSolution.Util;

namespace ProceedSolution.Temp
{
    public static class CustomMethodsSelenium
    {
        public static void SendKeysCustom(this IWebElement element, string text, string controlname)
        {
            element.SendKeys(text);
            if (element.GetAttribute("value").Equals(text))
            {
                LogFiles.WriteLineInFile("Typing - " + text + " in " + controlname + " textbox", "pass");
            }
            else
            {
                LogFiles.WriteLineInFile("Typing - " + text + " in " + controlname + " textbox", "fail");                
            }
        }
        public static void ClickCustom(this IWebElement element, string controlname)
        {
            element.Click();
            LogFiles.WriteLineInFile("Click on " + controlname, "info");
        }
        public static void SelectCustom(this IWebElement element, string value, string controlname)
        {
            SelectElement selector = new SelectElement(element);
            selector.SelectByValue(value);
            LogFiles.WriteLineInFile("Selected : " + controlname, "info");
        }
        public static void SwithWindowByTitle(this IWebDriver browser, string title)
        {
            var windowhandles = browser.WindowHandles;
            for(int i=1;i<windowhandles.Count;i++)
            {
                Thread.Sleep(1000);
                if(browser.Title.Contains(title))
                {
                    LogFiles.WriteLineInFile("Successfully switched to window with title " + browser.Title, "pass");
                    break;
                }
                else
                {
                    LogFiles.WriteLineInFile("No window with title " + browser.Title + " found, retrying " + i.ToString() + " time if anymore available", "info");                    
                    browser.SwitchTo().Window(windowhandles[i]);
                    continue;
                }
            }
        }
    }
}
