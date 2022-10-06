using NUnit.Framework;
using SpecFlowProjectTest.Page.Main;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class ChooseItemInMenMenuPageStepDefinitions
    {
        [Given(@"I click Man page buttonon on the Main page")]
        public void GivenIClickManPageButtononOnTheMainPage()
        {
            ChooseItemInMenMenuPage.Instance.ManPage();
        }

        [Given(@"I click  Sale list")]
        public void GivenIClickSaleList()
        {
            ChooseItemInMenMenuPage.Instance.SaleListM();
        }

        [When(@"I select an item")]
        public void WhenISelectAnItem()
        {
            ChooseItemInMenMenuPage.Instance.ItemFieldM();
        }

        [Then(@"I get a ""([^""]*)"" title item name")]
        public void ThenIGetATitleItemName(string itemTitleTextM)
        {
            Assert.IsTrue(MainMenu.Instance.IsItemTitleTextDisplayed(itemTitleTextM));
        }
        // [AfterScenario]
        // public static void AfterTestRun()
        // {
        //     Base.QuitDriver();
        // }
    }
}
