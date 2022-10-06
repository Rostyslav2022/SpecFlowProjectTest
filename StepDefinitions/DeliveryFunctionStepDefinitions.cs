using NUnit.Framework;
using SpecFlowProjectTest.Page;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class DeliveryFunctionStepDefinitions
    {
        [Given(@"I open Asos site")]
        public void GivenIOpenAsosSite()
        {
            DeliveryFunctionPage.Instance.OpenHomePage();
        }

        [Given(@"I click on the delivery button")]
        public void GivenIClickOnTheDeliveryButton()
        {
            DeliveryFunctionPage.Instance.ClickDeliveryBtn();
        }

        [When(@"I select a country")]
        public void WhenISelectACountry()
        {
            DeliveryFunctionPage.Instance.ClickSelectCountryBtn();
        }

        [Then(@"I click a ""([^""]*)""")]
        public void ThenIClickA(string newCountry)
        {
            DeliveryFunctionPage.Instance.GetCountryName();
        }
        // [AfterScenario]
        // public static void AfterTestRun()
        // {
        //     Base.QuitDriver();
        // }
    }
}
