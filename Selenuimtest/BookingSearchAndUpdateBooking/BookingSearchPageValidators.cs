using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.BookingSearchAndUpdateBooking
{
    public class BookingSearchPageValidators
    {
        
        private readonly IWebDriver browser;
        public BookingSearchPageValidators(IWebDriver browser)
        {

            this.browser = browser;
        }


        public BookingSearchPageElements SearchMap
        {
            get
            {
                return new BookingSearchPageElements(this.browser);
            }


        }
    }
}
