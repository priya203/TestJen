using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProjectsummary.WebAppBookingSummaryPage
{
   public class BookingSummaryPageValidators
    {
        private readonly IWebDriver browser;
        public BookingSummaryPageValidators(IWebDriver browser)
        {

            this.browser = browser;
        }


        public BookingSummaryPageElements BookingSummaryMap
        {
            get
            {
                return new BookingSummaryPageElements(this.browser);
            }


        }
        public void confirmpopup()
        {
            Assert.IsTrue(this.BookingSummaryMap.PopUPHandlingForVisitors.Enabled);
        }

        public void DisplayAlternteResource()
        {
            Assert.IsTrue(this.BookingSummaryMap.DisplayAlternateResourcePage.Enabled);
        }

        

        }
}
