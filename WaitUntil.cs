using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProjectTest
{
    public static class WaitUntil
    {
        
        public static void ShouldLocate(IWebDriver Instance, string location)
        {
            try
            {
                new WebDriverWait(Instance, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(location));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find:{location} ex");
            }
        }
        public static void WaitSomeInterval(int seconds = 10)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }
        public static void WaitElement(IWebDriver Instance,By locator, int seconds = 20)
        {
            new WebDriverWait(Instance, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(Instance, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
        public static IWebElement WaitAndFindElement(IWebDriver Instance, By locator, int seconds = 20)
        {
          return new WebDriverWait(Instance, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists(locator));
        }

    }

}
// 1.private const int WAIT_FOR_ELEMENT_TIMEOUT = 30;
//WebDriverWait = new WebDriverWait(Instance, TimeSpan.FromSeconds(WAIT_FOR_ELEMENT_TIMEOUT));

//2.public IWebElement WaitAndFindElement(By locator)
//{
//  return WebDriverWait.Until(ExpectedConditions.ElementExists(locator);
//}

//3.private IWebElement WaitAndFindElement(By by)
//{
//  var webDriverWait=new WebDriverWait(Instance, TimeSpan.FromSeconds(30));
//  return WebDriverWait.Until(ExpectedConditions.ElementExists(by));
//}

//4. private void WaitForAjax()
// var js = (IJavaScriptExecutor)Instance
// _webDriverWait.Until(wd =>js.ExecutScript('').ToString()==0);