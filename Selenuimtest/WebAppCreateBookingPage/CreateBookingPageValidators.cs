using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProjectsummary.WebAppCreateBookingPage
{
    public class CreateBookingPageValidators
    {
        private readonly IWebDriver browser;

        public CreateBookingPageValidators(IWebDriver browser)
        {

            this.browser = browser;
        }

        public CreateBookingPageValidators()
        {
            // TODO: Complete member initialization
        }

        
         public CreateBookingPageElements CreateBookingMap
        {
            get
            {
                return new CreateBookingPageElements(this.browser);
            }


        }

         public void TestResourceCheckbox()
         {
             Assert.IsTrue(this.CreateBookingMap.SelctResource.Enabled);
         }


        // public IWebDriver browser { get; set; }
    }
}
