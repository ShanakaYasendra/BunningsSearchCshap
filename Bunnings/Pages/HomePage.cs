using System;

using Bunnings.Util;

using OpenQA.Selenium;

namespace Bunnings.Pages
{
    public class HomePage
    {

        private IWebDriver driver;
        private ElementHelper elementHelper;
        public HomePage()
        {
            driver = null;
        }
        public HomePage(IWebDriver webdriver)
        {
            driver = webdriver;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            elementHelper = new ElementHelper(driver);
        }

        public IWebElement searchInput => elementHelper.GetElementByXPath("//input[contains(@data-page,'/search')]");
        public IWebElement searchButton => elementHelper.GetElementByXPath("//button[contains(@class,'btn-submit')]");
        public IWebElement dropDown => elementHelper.GetElementByID("ui-id-1");
        public void EnterSearchItem(String item)
        {
            searchInput.Clear();
            searchInput.SendKeys(item);
        }
        public void PerformSearch(string item)
        {
            EnterSearchItem(item);
            searchButton.Click();
        }
        public string GetElementAttribute()
        {
            return searchInput.GetAttribute("placeholder");
        }

        public void ClickListItem(string searchItem, string TabName)
        {
            driver.FindElement(By.XPath("(//input[@type='text'])[2]")).Clear();
            driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(searchItem);
            driver.FindElement(By.XPath("(//input[@type='text'])[2]")).Click();
            driver.FindElement(By.XPath("(//span[@class='ui-menu-item_category'][contains(.,'"+TabName+"')])[1]")).Click();


        }
    }
}
