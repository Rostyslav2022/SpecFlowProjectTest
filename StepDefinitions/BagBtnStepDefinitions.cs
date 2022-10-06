using NUnit.Framework;
using SpecFlowProjectTest;
using SpecFlowProjectTest.Page;
using SpecFlowProjectTest.Page.Main;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class BagBtnStepDefinitions
    {
        [Given(@"I open Asos website")]
        public void GivenIOpenAsosWebsite()
        {
            BagBtnPage.Instance.OpenHomePage();
        }

        [When(@"When I click on the bag button")]
        public void WhenWhenIClickOnTheBagButton()
        {
            BagBtnPage.Instance.ClickBagBtn();
        }

        [Then(@"I get a ""([^""]*)""")]
        public void ThenIGetA(string emptyBagText)
        {
            Assert.IsTrue(MainMenu.Instance.IsBagBtnDisplayed(emptyBagText));
        }
       // [AfterScenario]
       // public static void AfterTestRun()
       // {
       //     Base.QuitDriver();
       // }
    }

}


