using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Bunnings.PageAssembly
{
    public class Browser

    {
        private IWebDriver webDriver;
        private string baseURL1= "https://www.bunnings.com.au";
        private string browser="Chrome";
        public Browser()
        {
         
        }



        public void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }


            Goto(baseURL1);


        }



        public IWebDriver GetDriver()
        {
            return webDriver;
        }



        public string Title
        {
            get { return webDriver.Title; }
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }

        }
        public void Goto(string url)
        {
            webDriver.Url = "https://www.bunnings.com.au";
        }
        public void Close()
        {
            webDriver.Quit();
        }
    }
}
