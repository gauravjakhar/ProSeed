using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;

namespace ProceedSolution.Temp
{
    public static class CustomMethodsSelenium
    {
        public static void SendKeysCustom(this IWebElement element, string text, string controlname)
        {
            element.SendKeys(text);
            if (element.GetAttribute("value").Equals(text))
            {
                Console.WriteLine("PASS typing - " + text + " in " + controlname +" textbox");
            }
            else
            {
                Console.WriteLine("FAIL typing - " + text + " in " + controlname + " textbox");
            }
        }
        public static void ClickCustom(this IWebElement element, string controlname)
        {
            element.Click();
            Console.WriteLine("Click on " + controlname);
        }
        public static void SelectCustom(this IWebElement element, string value, string controlname)
        {
            SelectElement selector = new SelectElement(element);
            selector.SelectByValue(value);
            Console.WriteLine("Selected : " + controlname);
        }
        public static void SwithWindowByTitle(this IWebDriver browser, string title)
        {
            var windowhandles = browser.WindowHandles;
            for(int i=1;i<windowhandles.Count;i++)
            {
                Thread.Sleep(1000);
                if(browser.Title.Contains(title))
                {
                    Console.WriteLine("PASS - Successfully switched to window with title " +browser.Title);
                    break;
                }
                else
                {
                    Console.WriteLine("INFO - No window with title " + browser.Title +" found, retrying " + i.ToString() + " time if anymore available");
                    browser.SwitchTo().Window(windowhandles[i]);
                    continue;
                }
            }
        }
    }
}
