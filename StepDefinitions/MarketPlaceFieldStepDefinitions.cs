using NUnit.Framework;
using SpecFlowProjectTest;
using SpecFlowProjectTest.Page.Main;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class MarketPlaceFieldStepDefinitions
    {
        [Given(@"I open Asos  website")]
        public void GivenIOpenAsosWebsite()
        {
            MarketPlacePage.Instance.OpenAsosPage();
        }

        [When(@"When I click on the MarketPlace btn")]
        public void WhenWhenIClickOnTheMarketPlaceBtn()
        {
            MarketPlacePage.Instance.ClickMarketPlBtn();
        }

        [Then(@"I am redirected to ""([^""]*)"" page")]
        public void ThenIAmRedirectedToPage(string titleMarketPage)
        {
            Assert.IsTrue(MainMenu.Instance.IsMarketPlaceDisplayed(titleMarketPage));
        }
        // [AfterScenario]
        // public static void AfterTestRun()
        // {
        //     Base.QuitDriver();
        // }
    }
}



