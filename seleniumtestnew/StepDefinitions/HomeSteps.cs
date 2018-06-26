using Microsoft.VisualStudio.TestTools.UnitTesting;
using seleniumtestnew.Helpers;
using seleniumtestnew.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace seleniumtestnew.StepDefinitions
    {
    [Binding]
   public  class HomeSteps
    {
        private readonly Context context;
        private readonly homePage homepg;

        public HomeSteps(Context contex, homePage homepag)
        {

            context = contex;
            homepg = homepag;
        }

        [Given(@"i am on argus home page")]
        public void GivenIAmOnArgusHomePage()
        {
            context.BrowserSetup();
        }

        [When(@"i select what market i am looking for")]
        public void WhenISelectWhatMarketIAmLookingFor()
        {
            homepg.YourMarket();
            homepg.WhatYouLookFor();
            homepg.SelectionThree();
            homepg.GetStarted();
        }

        [Then(@"i should be able to land on crude oil information page successfully")]
        public void ThenIShouldBeAbleToLandOnCrudeOilInformationPageSuccessfully()
        {
            Assert.AreEqual("ARGUS Fundamentals", homepg.VerifyMarketPlace());
        }

    }
}
