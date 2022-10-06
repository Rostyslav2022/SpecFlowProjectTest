using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest
{
    internal class ChooseItemInWomanMenuPage
    {

        public static ChooseItemInWomanMenuPage Instance { get; } = new ChooseItemInWomanMenuPage();
        private static string URL => "https://www.asos.com/";

        IWebElement womanPage => Base.Instance().FindElement(By.XPath("//*[@id='women-floor']"));
        IWebElement saleList => Base.Instance().FindElement(By.XPath("//*[@id='chrome-sticky-header']/div[2]//button[1]/span"));
        IWebElement itemField => Base.Instance().FindElement(By.XPath("//*[contains(text(),'SALE Dresses')]"));
        IWebElement itemTitleTextW => Base.Instance().FindElement(By.XPath("//*[@id='category-banner-wrapper']/div/h1"));

        public void OpenHomePage()
        {
            Base.Instance().Navigate().GoToUrl(URL);
        }
                
        public void WomanPage()
        {
            womanPage.Click();
           
        }
    
        public void SaleList()
        {
            saleList.Click();
          
        }
        
        public void ItemField()
        {
            itemField.Click();
          
        }
       
        public void GetItemTitleTextW()
        {
           itemTitleTextW.Click();
            
        }
    }
}
