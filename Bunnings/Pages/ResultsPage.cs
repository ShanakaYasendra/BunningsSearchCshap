using System;

using Bunnings.Util;

using OpenQA.Selenium;

namespace Bunnings.Pages
{
    public class ResultsPage
    {
        private IWebDriver driver;
        private ElementHelper elementHelper;

        public ResultsPage()
        {
            driver = null;
        }
        public ResultsPage(IWebDriver webdriver)
        {
            driver = webdriver;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            elementHelper = new ElementHelper(driver);
        }

        public IWebElement h1 => elementHelper.GetElementByClassName("responsive-search-title");

        public string GetTab(string tab)
        {
            IWebElement parent = elementHelper.GetElementByXPath("//span[@class='responsive-search-tabs_list-item-title'][contains(.,'"+tab+"')]/following-sibling::span[3]");
            return parent.Text;
    
         }

        public bool ActiveLink(string tab)
        {
            IWebElement parent = elementHelper.GetElementByXPath("//li[@class='responsive-search-tabs_list-item is-active ']/child::*[position()=1]");
            if(parent.Text.Contains(tab))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
