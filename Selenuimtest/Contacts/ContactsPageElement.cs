using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Contacts
{
    public class ContactsPageElement
    {
       
        private readonly IWebDriver browser;

        public ContactsPageElement(IWebDriver browser)
        {
            this.browser = browser;
        }

        public IWebElement Contacts
        {
            get
            { 
            return this.browser.FindElement(By.XPath("//*[@id='hostSpan']"));
            }
        }

        public IWebElement Compamy
        {
            get
            {
                return this.browser.FindElement(By.XPath(" //*[@id='ctl00_lblCompany']"));
            }
        }

    //    public IWebElement Contactp
    //    {
    //        get
    //        {
    //            return this.browser.FindElement(By.XPath("//*[@id='ctl00_lblContactList']"));
    //        }
    //    }


    }
}
