using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.Page
{
    public class HelpInfoBtnPage
    {
        public static HelpInfoBtnPage Instance { get; } = new HelpInfoBtnPage();
            
        private static string URL => "https://www.asos.com/";

        IWebElement helpBtn => Base.Instance().FindElement(By.XPath("//*[@id='chrome-header']/header/div[2]//ul/li[2]"));
        IWebElement textHelpBtn => Base.Instance().FindElement(By.XPath("//*[@id='chrome-footer']/footer//section[1]/h4"));
                       
              
        public void OpenAsosPage()
        {
            Base.Instance().Navigate().GoToUrl(URL);
        }

       
        public void ClickHelpBtn()
        {
            helpBtn.Click();
            
        }
      
        public void GetHelpInfoText()
        {
           
            textHelpBtn.Click();
         
        }

      
    }
}
