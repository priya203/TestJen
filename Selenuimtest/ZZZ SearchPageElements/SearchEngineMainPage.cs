using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.PageElements
{
    public class SearchEngineMainPage
    {
        private readonly IWebDriver browser;
        private readonly string url = "https://www.bing.com/";// @"searchEngineUrl";

        public SearchEngineMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected SearchEngineMainPageElementMap Map
        {
            get
            {
                return new SearchEngineMainPageElementMap(this.browser);
            }
        }

        public SearchEngineMainPageValidator Validate()
        {
            return new SearchEngineMainPageValidator(this.browser);
        }

        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(this.url);
        }

        public void Search(string textToType)
        {
            this.Map.SearchBox.Clear();
            this.Map.SearchBox.SendKeys(textToType);
            this.Map.GoButton.Click();
        }
    }
}
