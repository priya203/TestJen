using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Authorization_request
{
    public class AuthrizationMainPage
    {



            public AuthrizationMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
            public AuthrizationMainPage()
             {
    
             }

            public AuthorizationPageElements PageMap
           {
             get
                 {
                return new AuthorizationPageElements(this.browser);
                 }
            }


            public void NavigatetoAuth()
            {
                this.PageMap.BookingsTab.Click();
                this.PageMap.AuthrizationRequest.Click();
            }

            public void checkElementsEnabled()
            {
                Assert.IsTrue(this.PageMap.SearchButton.Enabled,"Assert False as element has not shows");
                Assert.IsTrue(this.PageMap.StartDate.Enabled, "Assert fails as start date is not enabled");
            }
            public void StartDateCHeck()
            {
                IWebElement start = this.PageMap.StartDate;
                var str = start.GetAttribute("Value");
                Console.WriteLine(str);
                var today = DateTime.Now.ToString("dd/MM/yyyy");
                Console.WriteLine(today);
               // Assert.Equals(str.Equals(today), "Assert fails due to mismatch in dates");
                Assert.IsTrue(str.Equals(today));
            }


            public IWebDriver browser { get; set; }
    }
}
