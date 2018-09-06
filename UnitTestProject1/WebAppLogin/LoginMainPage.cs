using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.WebAppLogin
{
    public class LoginMainPage
    {
        private readonly IWebDriver browser;
        private readonly string url = "http://localhost/WebAppV6_3/Pages/";// @"searchEngineUrl";


        public LoginMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected LoginPageElements Map
        {
            get
            {
               return new LoginPageElements(this.browser);
            }
            
            
        }
        public void NavigatetoLoginpage()
        {
            this.browser.Navigate().GoToUrl(this.url);
        }

        public void Login()
        {
            this.Map.LoginPageUsername.SendKeys("gg");
            this.Map.LoginPagePassword.SendKeys("gg");
            this.Map.SubmitButton.Click();
        }
    }
}
