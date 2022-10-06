using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SpecFlowProjectTest
{
    public class Base
    {
           
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        private static string URL => "https://www.asos.com/";

        public static IWebDriver Instance()
        {
            if (driver.Value == null)
            {
                driver.Value = new ChromeDriver();
                driver.Value.Manage().Window.Maximize();
                driver.Value.Navigate().GoToUrl("https://www.asos.com/");
               // driver.Value.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
               
            }
               return  driver.Value;
        }
      

        public static void QuitDriver()
        {
           
            Instance().Quit();
            driver.Value = null;
        }

    }
}