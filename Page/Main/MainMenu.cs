using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V102.Network;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace SpecFlowProjectTest.Page.Main
{
    internal class MainMenu
    {
        public static MainMenu Instance { get; } = new MainMenu();

        public static IWebElement FindElement(By locator)
        {
            return Base.Instance().FindElement(locator);
        }

        //public ReadOnlyCollection<IWebElement> FindElements(By locator)
        //{
        //  return Base.Instance().FindElements(locator);
        //}
        public bool IsDisplayed(By locator, int timeout = 30)
        {
            var wait = new WebDriverWait(Base.Instance(), TimeSpan.FromSeconds(timeout));
            return wait.Until(d => Base.Instance().FindElement(locator).Displayed);
        }
        
        public bool IsHelpInfoTitleDisplayed(string helpInfoText)
        {
            return IsDisplayed(By.XPath("//*[@id='chrome-footer']/footer//section[1]/h4"));
        }
        public bool IsBagBtnDisplayed(string emptyBagText)
        {

            return IsDisplayed(By.XPath("//*[@id='bagApp']/div[1]//h1"));
        }
        public bool IsMarketPlaceDisplayed(string titleMarketPage)
        {

            return IsDisplayed(By.XPath("//*[@id='content']/article[2]/div/a/h1"));
        }
        public bool IsDeliveryCoutryDisplayed(string newCountry)
        {
            return IsDisplayed(By.XPath("//*[@id='country']/option[1]"));

        }
        public bool IsSearchResultDisplayed(string searchResult)
        {
            return IsDisplayed(By.XPath("//*[contains(text(),'NOTHING MATCHES YOUR SEARCH')]"));

        }
        public bool IsItemTitleTextDisplayed(string itemTitleTextM)
        {
            return IsDisplayed(By.XPath("//*[@id='category-banner-wrapper']/div/h1"));

        }
        public bool IsItemTitleTextWDisplayed(string itemTitleTextW)
        {
            return IsDisplayed(By.XPath("//*[@id='category-banner-wrapper']/div/h1"));

        }
        public bool IsHomePageTitleDisplayed(string title)
        {
            return IsDisplayed(By.XPath("//*[@id='chrome-footer']/footer/div[1]/div[3]/div/section[2]/h4"));

        }
        public bool IsInValidLoginTextDisplayed(string text)
        {
            return IsDisplayed(By.XPath("//*[@id='loginErrorMessage']"));

        }
    }

}
