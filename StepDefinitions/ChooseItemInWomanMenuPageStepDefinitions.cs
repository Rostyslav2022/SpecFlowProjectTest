using NUnit.Framework;
using SpecFlowProjectTest.Page.Main;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class ChooseItemInWomanMenuPageStepDefinitions
    {
        [Given(@"I click Woman page button on the Main page")]
        public void GivenIClickWomanPageButtonOnTheMainPage()
        {
            ChooseItemInWomanMenuPage.Instance.WomanPage();
        }

        [Given(@"I click Sale list")]
        public void GivenIClickSaleList()
        {
            ChooseItemInWomanMenuPage.Instance.SaleList();
        }

        [When(@"I select a item")]
        public void WhenISelectAItem()
        {
            ChooseItemInWomanMenuPage.Instance.ItemField();
        }

        [Then(@"I get a ""([^""]*)""  title item name")]
        public void ThenIGetATitleItemName(string itemTitleTextW)
        {
            Assert.IsTrue(MainMenu.Instance.IsItemTitleTextWDisplayed(itemTitleTextW));
        }
        // [AfterScenario]
        // public static void AfterTestRun()
        // {
        //     Base.QuitDriver();
        // }
    }
}
