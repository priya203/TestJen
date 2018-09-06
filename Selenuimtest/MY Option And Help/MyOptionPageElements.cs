using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.MY_Option
{
    public class MyOptionPageElements
    {
        
        private readonly IWebDriver browser;
        public MyOptionPageElements(IWebDriver browser)
        {
            this.browser = browser;
        }

        public MyOptionPageElements()
        {}

        public IWebElement MyOptionButton
        {
            get
            {return this.browser.FindElement(By.XPath("//*[@id='myoptionsSpan']"));}
        }

        public IWebElement DisplayName
        {
            get
            { return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtDisplayName")); }
        }

        public IWebElement PrimaryProperty
        { get { return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddlPrimaryProperty']")); } }

        public IWebElement SaveButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnSave']"));
            }
        }

        public IWebElement HelpPageNavigation
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='HelpSpan']"));
            }
        }

        public IWebElement AboutOption
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_lblAbout']"));
            }
        }

        public IWebElement Version
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_lblCurrentVersion']"));
            }
        }

        public IWebElement BuildDate
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_lblBuildDate']"));
            }
        }





    }
}
