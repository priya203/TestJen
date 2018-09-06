using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.PageElements
{
    public class SearchEngineMainPageValidator
    {
        private readonly IWebDriver browser;

        public SearchEngineMainPageValidator(IWebDriver browser)
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

        public void ResultsCount(string expectedCount)
        {
            Assert.IsTrue(this.Map.ResultsCountDiv.Text.Contains(expectedCount), "The results DIV doesn't contains the specified text.");
        }

        //public void ResultsInvalidPassword(string expectedCount)
        //{
        //    Assert.IsTrue(this.Map.ResultsCountDiv.Text.Contains(expectedCount), "Your login attempt was not successful. Please try again.");
        //}

        public void ForgotpasswordLINK()
        {
            throw new NotImplementedException();
        }
    }
}
