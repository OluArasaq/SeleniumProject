using OpenQA.Selenium;
using UITestAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace UITestAutomation.Pages
{
   public class HomePage
      {
       private readonly Context _context;
       public HomePage(Context context)
        {
            _context = context;
        }

       private By MARKETELEMENTClick = By.XPath("//*[@class='text' and text()='1. What is your market?']");
       private By LOOKINGFORCLICK = By.XPath("//*[@class='text' and text()='2. What are you looking for?']");
       private By SELECTTHREE = By.XPath("//*[@class='text' and text()='3. Select']");
       private By CRUDEOIL = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[1]/div/div/div/div[2]");
       private By NEARTERM = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[2]/div/div/div[3]");
       private By ARGUSFUND = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[3]/div/div/div[2]");
       private By GETSTARTEDBTN = By.CssSelector("#main > section.hero-banner.cf > div.quick-dive.form > div > fieldset > div.cta.left > a");
       private By ARGUSFUNDAMT = By.CssSelector("#main > section.cf.wrapper > div > section > div > h2");
       
       public void YourMarket() {
           _context.Driver.FindElement(MARKETELEMENTClick).Click();
           _context.Driver.FindElement(CRUDEOIL).Click();
         
       }

       public void WhatYouLookFor() {
           Thread.Sleep(2000);
           _context.Driver.FindElement(LOOKINGFORCLICK).Click();
           _context.Driver.FindElement(NEARTERM).Click();
       }

       public void SelectionThree()
       {
           Thread.Sleep(2000);
           _context.Driver.FindElement(SELECTTHREE).Click();
           _context.Driver.FindElement(ARGUSFUND).Click();
       }

       public void GetStarted() {

           _context.Driver.FindElement(GETSTARTEDBTN).Click();
       }
       public string VerifyMarketPlace() {

           IWebElement crudeinforPageTitle = _context.Driver.FindElement(ARGUSFUNDAMT);
           return crudeinforPageTitle.Text; 
       }
    }
}
