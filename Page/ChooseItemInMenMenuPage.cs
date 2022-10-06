using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowProjectTest.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest
{
    internal class ChooseItemInMenMenuPage
    {
        public static ChooseItemInMenMenuPage Instance { get; } = new ChooseItemInMenMenuPage();
        private static string URL => "https://www.asos.com/";

        IWebElement manPage => Base.Instance().FindElement(By.XPath("//*[@id='men-floor']"));
        IWebElement saleListM => Base.Instance().FindElement(By.XPath("//*[@id='chrome-sticky-header']//div[2]/nav//button[1]"));
        IWebElement itemFieldM => Base.Instance().FindElement(By.XPath("//*[contains(text(),'SALE Shirts')]"));
        IWebElement itemTitleTextM => Base.Instance().FindElement(By.XPath("//*[@id='category-banner-wrapper']/div/h1"));

        public void OpenHomePage()
        {
            Base.Instance().Navigate().GoToUrl(URL);
        }

        public void ManPage()
        {
            manPage.Click();

        }

        public void SaleListM()
        {
            saleListM.Click();

        }

        public void ItemFieldM()
        {

            itemFieldM.Click();

        }

        public void GetItemTitleTextM()
        {
            itemTitleTextM.Click();

        }

    }
}

