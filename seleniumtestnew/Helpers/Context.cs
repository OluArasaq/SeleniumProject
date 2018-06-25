using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumtestnew.Helpers
{
    public class Context
    {
        public IWebDriver Driver;
        // private string BaseUrl= "https://www.valtech.com";
        private string BaseUrl = "https://www.argusmedia.com/";

        public void BrowserSetup()
        {
            var chromeDriverProcesses = Process.GetProcessesByName("ChromeDriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                try
                {
                    chromeDriverProcess.Kill();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(BaseUrl);
            Driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            Driver.Quit();
            Driver.Dispose();
        }


        public void DropDownSelection(IWebElement element, int text)
        {

            SelectElement dropdownText = new SelectElement(element);
            dropdownText.SelectByIndex(text);
        }
    }

}
