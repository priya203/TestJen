
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProjectsummary.Login
{
    public class LoginReferences
    {
        private readonly IWebDriver driver;

        public LoginReferences(IWebDriver driver)
        {
            this.driver = driver;

        }
        public IWebElement UserNameTextbox
        {
            get
            {
                return this.driver.FindElement(By.Id("loginMain_UserName"));
            }

        }
        public IWebElement PasswordTextBox
        {
            get
            {
                return this.driver.FindElement(By.Id("loginMain_Password"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return this.driver.FindElement(By.Id("loginMain_LoginButton"));
            }

        }

        public IWebElement LogoutButton
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_lblLogout"));
            }
        }

        public IWebElement ReloginButton
        {
            get
            {
                return this.driver.FindElement(By.Id("btRelogin"));
            }
        }

    }
}

