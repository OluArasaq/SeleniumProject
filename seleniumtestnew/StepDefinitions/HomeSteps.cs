using Microsoft.VisualStudio.TestTools.UnitTesting;
using UITestAutomation.Helpers;
using UITestAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UITestAutomation.StepDefinitions
    {
    [Binding]
   public  class HomeSteps
    {
        private readonly Context context;
        private readonly HomePage homepageObj;

        public HomeSteps(Context contex, HomePage homepag)
        {

            context = contex;
            homepageObj = homepag;
        }

        [Given(@"i am on argus home page")]
        public void GivenIAmOnArgusHomePage()
        {
            context.BrowserSetup();
        }

        [When(@"i select what market i am looking for")]
        public void WhenISelectWhatMarketIAmLookingFor()
        {
            homepageObj.YourMarket();
            homepageObj.WhatYouLookFor();
            homepageObj.SelectionThree();
            homepageObj.GetStarted();
        }

        [Then(@"i should be able to land on crude oil information page successfully")]
        public void ThenIShouldBeAbleToLandOnCrudeOilInformationPageSuccessfully()
        {
            Assert.AreEqual("ARGUS Fundamentals", homepageObj.VerifyMarketPlace());
        }

    }
}
