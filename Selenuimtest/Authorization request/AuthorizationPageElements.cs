using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Authorization_request
{
    public class AuthorizationPageElements
    {

        public AuthorizationPageElements(IWebDriver browser)
        {
            this.browser = browser;
         }

        public IWebElement BookingsTab
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='bookingsSpan']"));
            }
        }
        public IWebElement AuthrizationRequest
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_spanAuthorizationrequest']"));
            }
        }

        public IWebElement StartDate
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtTime_dateInput']"));
            }
        }
        public IWebElement SearchButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnSearchIn']"));
            }
        }
        public IWebElement RefNumber
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00_ctl02_ctl02_FilterTextBox_BookingReferenceNumberAuth_SP']"));
            }
        }


        //*[@id="ctl00_MainContentPlaceHolder_grdList_ctl00_ctl05_lnkGoToSummary"]

        //*[@id='ctl00_MainContentPlaceHolder_btnSearchIn']

        //*[@id="ctl00_MainContentPlaceHolder_dtTime_dateInput"]





        


        public IWebDriver browser { get; set; }
    }
}
