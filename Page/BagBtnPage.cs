using OpenQA.Selenium;

namespace SpecFlowProjectTest.Page
{

    public class BagBtnPage
    {
        public static BagBtnPage Instance { get; } = new BagBtnPage();
        private static string URL => "https://www.asos.com/";

        IWebElement bagBtn => Base.Instance().FindElement(By.XPath("//*[@id='chrome-sticky-header']/div[1]//ul/li[3]//span"));
        IWebElement emptyBagText => Base.Instance().FindElement(By.XPath("//*[@id='bagApp']/div[1]//h1"));
        
        public void OpenHomePage()
        {
            Base.Instance().Navigate().GoToUrl(URL);
        }
               

        public void ClickBagBtn()
        { 
             bagBtn.Click();
        }


        public void GetEmptyBagText()
        {
           
            emptyBagText.Click();

        }
    }
}
