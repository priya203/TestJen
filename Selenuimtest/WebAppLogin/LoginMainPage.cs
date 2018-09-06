using OpenQA.Selenium;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using UnitTestProjectsummary.WebAppLogin;
using OpenQA.Selenium.Support.UI;
using System.IO;
using UnitTestProjectsummary.MY_Option;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;
using excel = Microsoft.Office.Interop.Excel;

namespace UnitTestProjectsummary.PageElements
{
    public class LoginMainPage
    {
        private readonly IWebDriver browser;
        private readonly string url = ConfigurationSettings.AppSettings["WebApppUrl"];//"http://localhost/WebAppV6_3/Pages/";// @"searchEngineUrl";
        private readonly string Username = ConfigurationSettings.AppSettings["ValidUsername"];
        private readonly string Password = ConfigurationSettings.AppSettings["ValidPassword"];
        private readonly string InvalidUsername = ConfigurationSettings.AppSettings["InvalidUsername"];
        private readonly string InvalidPassword = ConfigurationSettings.AppSettings["InvalidPassword"];




        public LoginMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }

        public LoginMainPage()
        {
            // TODO: Complete member initialization
        }

        protected LoginPageElements Map
        {
            get
            {

                return new LoginPageElements(this.browser);
            }


        }
        public UnitTestProjectsummary.MY_Option.MyOptionMainPage map2
        {
            get { return new UnitTestProjectsummary.MY_Option.MyOptionMainPage(this.browser); 
            }
        }
        public LoginPageValidators Validate()
        {
            return new LoginPageValidators(this.browser);
        }
        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(this.url);
           
        }
        public void Login()
        {
            this.Map.LoginPageUsername.SendKeys(Username);
            Thread.Sleep(1000);
            this.Map.LoginPagePassword.SendKeys(Password);
            Thread.Sleep(2000);
            this.Map.SubmitButton.Click();
            Thread.Sleep(3000);
         }
    //*****************************

       
public void BookingNavigationsAndLogin()
   {
       Navigate();
       Login();
       WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(15));
       wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='Cell0179711']")));
  }


        public void LoginInvalidCredientials()
        {
            this.Map.LoginPageUsername.SendKeys(InvalidUsername);
            Thread.Sleep(1000);
            this.Map.LoginPagePassword.SendKeys(InvalidPassword);
            Thread.Sleep(3000);
            this.Map.SubmitButton.Click();
        }

        public void logoutTest()
        {
            this.Map.LogoutButton.Click();
 
           
        }

     
    }
    }

