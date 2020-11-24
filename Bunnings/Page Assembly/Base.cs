using System;
using System.IO;
using System.Reflection;

using NUnit.Framework;

using OpenQA.Selenium;

namespace Bunnings.PageAssembly
{
    public class Base
    {

        public IWebDriver driver;
    
        protected Browser browser;
        protected Page pages;
        [SetUp]
        public void initialize()
        {
            browser = new Browser();
            pages = new Page(browser);
          //  string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Driver");
            browser.Init();
       
        }


        [TearDown]
        public void AfterTest()
        {
          
            browser.Close();
        }
     
    }
}
