using OpenQA.Selenium;
using SpecFlowProjectTest.Page;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest
{
    internal class MarketPlacePage
    {

        public static MarketPlacePage Instance { get; } = new MarketPlacePage();

        private static string URL => "https://www.asos.com/";

        IWebElement marketPlaceBtn => Base.Instance().FindElement(By.XPath("//*[@id='chrome-header']/header/div[2]//li[1]/a"));
        IWebElement titleMarketPage => Base.Instance().FindElement(By.XPath("//*[@id='content']/article[2]/div/a/h1"));

                         
        public void OpenAsosPage()
        {
            Base.Instance().Navigate().GoToUrl(URL);
        }

        public void ClickMarketPlBtn()
        {
            marketPlaceBtn.Click();
          
        }
       
        public void GetTitleMP()
        {
            titleMarketPage.Click();
        }
    }
}
