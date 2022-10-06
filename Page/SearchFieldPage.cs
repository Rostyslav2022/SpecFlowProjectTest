using OpenQA.Selenium;
using SpecFlowProjectTest.Page;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest
{
    internal class SearchFieldPage
    {
        public static SearchFieldPage Instance { get; } = new SearchFieldPage();

        private static string URL => "https://www.asos.com/";

        IWebElement searchMenu => Base.Instance().FindElement(By.XPath("//*[@id='chrome-search']"));
        IWebElement searchBtn => Base.Instance().FindElement(By.XPath("//*[@id='chrome-sticky-header']//form//button[2]"));
        IWebElement searchResult => Base.Instance().FindElement(By.XPath("//*[contains(text(),'NOTHING MATCHES YOUR SEARCH')]"));

        public void OpenHomePage()
        {
           Base.Instance().Navigate().GoToUrl(URL);
        }

        public void SearchMenu()
        {
           searchMenu.SendKeys("с");
           
        }
        public void SearchMenuBtn()
        {
            searchBtn.Click();
           
        }
        public void GetSearchText()
        {
            searchResult.Click();
        }  
    }

}
