using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.WebAppLogin
{
    public class LoginPageValidators
    {
        private readonly IWebDriver browser;

        public LoginPageValidators(IWebDriver browser)
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

    }
}
