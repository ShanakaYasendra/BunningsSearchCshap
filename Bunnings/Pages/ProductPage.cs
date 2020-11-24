using System;

using Bunnings.Util;

using OpenQA.Selenium;

namespace Bunnings.Pages
{
    public class ProductPage
    {
        private IWebDriver driver;
        private ElementHelper elementHelper;
        public ProductPage()
        {
            driver = null;
        }

        public ProductPage(IWebDriver webdriver)
        {
            driver = webdriver;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            elementHelper = new ElementHelper(driver);
        }

        public IWebElement h1 => elementHelper.GetElementByClassName("h2");

        public string GetTitle()
        {
            return driver.Title;
        }

    }
}
