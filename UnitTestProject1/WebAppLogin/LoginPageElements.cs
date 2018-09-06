using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.WebAppLogin
{
   public class LoginPageElements
    {
        private readonly IWebDriver browser;
        public LoginPageElements(IWebDriver browser)
        {
            this.browser = browser;
        }
        public IWebElement LoginPageUsername
        {
            get
            {
                return this.browser.FindElement(By.Id("loginMain_UserName"));
            }
        }
        public IWebElement LoginPagePassword
        {
            get
            {
                return this.browser.FindElement(By.Id("loginMain_Password"));
            }

        }

        public IWebElement SubmitButton
        {
            get
            {
                return this.browser.FindElement(By.Name("loginMain$LoginButton"));
            }

        }

    }
}
