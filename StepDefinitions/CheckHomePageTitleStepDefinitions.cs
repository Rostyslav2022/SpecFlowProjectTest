using NUnit.Framework;
using SpecFlowProjectTest.Page;
using SpecFlowProjectTest.Page.Main;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class CheckHomePageTitleStepDefinitions
    {
        [Given(@"I open Asos home page")]
        public void GivenIOpenAsosHomePage()
        {
            HomePage.Instance.OpenHomePage();
        }

        [When(@"Home page is downloaded")]
        public void WhenHomePageIsDownloaded()
        {
           
        }

        [Then(@"I get a ""([^""]*)"" title")]
        public void ThenIGetATitle(string title)
        {
            Assert.IsTrue(MainMenu.Instance.IsHomePageTitleDisplayed(title));
        }
        // [AfterScenario]
        // public static void AfterTestRun()
        // {
        //     Base.QuitDriver();
        // }
    }
}

