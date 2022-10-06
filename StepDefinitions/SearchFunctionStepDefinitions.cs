using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectTest.Page.Main;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class SearchFunctionStepDefinitions
    {
                
        [Given(@"I open Asos   website")]
        public void GivenIOpenAsosWebsite()
        {
            SearchFieldPage.Instance.OpenHomePage();
        }

        [Given(@"I create a ""([^""]*)""request")]
        public void GivenICreateARequest(string с)
        {
            SearchFieldPage.Instance.SearchMenu();
        }

        [When(@"When I click search btn")]
        public void WhenWhenIClickSearchBtn()
        {
            SearchFieldPage.Instance.SearchMenuBtn();
        }

        [Then(@"I get a search ""([^""]*)""")]
        public void ThenIGetASearch(string searchResult)
        {
        
           Assert.IsTrue(MainMenu.Instance.IsSearchResultDisplayed(searchResult));
        }
        // [AfterScenario]
        // public static void AfterTestRun()
        // {
        //     Base.QuitDriver();
        // }
    }
}
