using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Users
{
   public class UsersPageElement
    {
        private readonly IWebDriver browser;
        public UsersPageElement(IWebDriver browser)
        {
            this.browser = browser;
        }

        public IWebElement Administration
        {
            get
            { 
            return this.browser.FindElement(By.XPath("//*[@id='adminSpan']"));
            }
        }
        public IWebElement UserSecurity
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_lblUserSecurity']"));
            }
        }
        public IWebElement User
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_subLblContactUser']"));
            }
        }
        public IWebElement AddUserButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnAdd']"));
            }
        }

        public IWebElement SelectCompany1
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddlHost']"));
            }
        }

        public IWebElement SelectTitle
        {
            get
            {
                return this.browser.FindElement(By.XPath(" //*[@id='ctl00_MainContentPlaceHolder_ddlTitle']"));
            }
        }

        //*[@id='ctl00_MainContentPlaceHolder_ddlTitle']




        

     




        





    }
}
