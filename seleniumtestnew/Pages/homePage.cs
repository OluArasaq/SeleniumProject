using OpenQA.Selenium;
using seleniumtestnew.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace seleniumtestnew.Pages
{
   public class homePage
      {
       private readonly Context _context;
       public homePage(Context context)
        {
            _context = context;
        }

       private By MARKETELEMENTClick = By.XPath("//*[@class='text' and text()='1. What is your market?']");
       private By LOOKINGFORCLICK = By.XPath("//*[@class='text' and text()='2. What are you looking for?']");
       private By SelectThreeClick = By.XPath("//*[@class='text' and text()='3. Select']");

   
       private By MARKETELEMENT = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[1]/div/div/div/div[2]");
       private By LOOKINGFOR = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[2]/div/div/div[3]");
       private By SelectThree = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[3]/div/div/div[2]");
       //testing
       
       public void YourMarket() {
           _context.Driver.FindElement(MARKETELEMENTClick).Click();
           _context.Driver.FindElement(MARKETELEMENT).Click();
         
       }

       public void WhatYouLookFor() {
           Thread.Sleep(2000);
           _context.Driver.FindElement(LOOKINGFORCLICK).Click();
           _context.Driver.FindElement(LOOKINGFOR).Click();
       }

       public void SelectionThree()
       {
           Thread.Sleep(2000);
           _context.Driver.FindElement(SelectThreeClick).Click();
           _context.Driver.FindElement(SelectThree).Click();
       }
    }
}
