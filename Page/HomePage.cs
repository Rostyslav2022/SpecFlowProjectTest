using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTest.Page
{
    public class HomePage
    {
        public static HomePage Instance { get; } = new HomePage();
        private static string URL => "https://www.asos.com/";

        IWebElement title => Base.Instance().FindElement(By.XPath("//*[@id='chrome-footer']/footer/div[1]/div[3]/div/section[2]/h4"));
        public void OpenHomePage()
        {
            Base.Instance().Navigate().GoToUrl(URL);
        }

        public void GetTitle()
        {
            title.Click();

        }

    }
}
