using System;

using Bunnings.Pages;

namespace Bunnings.PageAssembly
{
    public class Page
    {
        public Page(Browser browsers)
        {
            _browser = browsers;
        }
        Browser _browser
        {
            get;
        }
        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.getDriver);

            return page;
        }
        public HomePage homePage => GetPages<HomePage>();
        public ResultsPage resultsPage => GetPages<ResultsPage>();
        public ProductPage productPage => GetPages<ProductPage>();
    }
}
