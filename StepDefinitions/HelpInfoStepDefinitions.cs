using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectTest;
using SpecFlowProjectTest.Page;
using SpecFlowProjectTest.Page.Main;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class HelpInfoStepDefinitions
    {
        [Given(@"I open  Asos website")]
        public void GivenIOpenAsosWebsite()
        {
            HelpInfoBtnPage.Instance.OpenAsosPage();
        }

        [When(@"When I click on the HelpInfo btn")]
        public void WhenWhenIClickOnTheHelpInfoBtn()
        {
            HelpInfoBtnPage.Instance.ClickHelpBtn();
        }

        [Then(@"I am redirected to ""([^""]*)"" menu")]
        public void ThenIAmRedirectedToMenu(string textHelpBtn)
        {

            Assert.IsTrue(MainMenu.Instance.IsHelpInfoTitleDisplayed(textHelpBtn));
        }
        // [AfterScenario]
        // public static void AfterTestRun()
        // {
        //     Base.QuitDriver();
        // }
    }
}

