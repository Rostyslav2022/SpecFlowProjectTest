using OpenQA.Selenium;

namespace SpecFlowProjectTest
{
    internal class DeliveryFunctionPage
    {
     
        public static DeliveryFunctionPage Instance { get; } = new DeliveryFunctionPage();

       
        private static string URL => "https://www.asos.com/";

        IWebElement countryBtn => Base.Instance().FindElement(By.XPath("//*[@id='chrome-header']/header//ul/li[3]//button"));
        IWebElement selectCountryBtn => Base.Instance().FindElement(By.XPath("//*[@id='country']"));
        IWebElement idCountry => Base.Instance().FindElement(By.XPath("//*[@id='country']/option[1]"));
        IWebElement newCountry => Base.Instance().FindElement(By.XPath("//*[@id='country']/option[1]"));
        

        public void OpenHomePage()
        {
            Base.Instance().Navigate().GoToUrl(URL);
        }

        public void ClickDeliveryBtn()
        {
            Thread.Sleep(1000);
            countryBtn.Click();
        }
               
        public void ClickSelectCountryBtn()
        {
            Thread.Sleep(1000);
            selectCountryBtn.Click();
        }
      
        public void ClickChooseCountry()
        {
            
            idCountry.Click();
        }
    
        public void GetCountryName()
        {
           
            newCountry.Click();
        }
     
    }
}
