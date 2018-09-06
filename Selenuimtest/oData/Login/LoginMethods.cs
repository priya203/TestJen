using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;



namespace UnitTestProjectsummary.Login
{
    public class LoginMethods
    {

        private IWebDriver driver;


        public LoginMethods(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void NavigateTo()
        {
            this.driver.Navigate().GoToUrl("http://localhost/WebAppVV6_3/");
        }

        //mapping references from Login References
        protected LoginReferences Map
        {
            get
            {
                return new LoginReferences(this.driver);
            }

        }
        //Successful login with username and password
        public void SucessfulLogin()
        {
            this.Map.UserNameTextbox.SendKeys("OB1");
            Thread.Sleep(1000);
            this.Map.PasswordTextBox.SendKeys("OB1");
            Thread.Sleep(1000);
            this.Map.LoginButton.Click();

        }
        //Unsuccessful login using correct username and incorrect password

        public void UnsuccessfulLogin()
        {
            this.Map.UserNameTextbox.SendKeys("OB1");
            Thread.Sleep(1000);
            this.Map.PasswordTextBox.SendKeys("OB2");
            Thread.Sleep(1000);
            this.Map.LoginButton.Click();

        }
        //Unsuccessful login using incorrect username and correct password

        public void UnsuccessfulLogin1()
        {
            this.Map.UserNameTextbox.SendKeys("OB2");
            Thread.Sleep(1000);
            this.Map.PasswordTextBox.SendKeys("OB1");
            Thread.Sleep(1000);
            this.Map.LoginButton.Click();
        }
        //Successful Logout
        public void LogoutSuccess()
        {
            Thread.Sleep(5000);
            this.Map.LogoutButton.Click();

        }

        //Check Relogin Button
        public void ReloginNavigation()
        {

            Thread.Sleep(5000);
            this.Map.ReloginButton.Click();
        }


    }

}



