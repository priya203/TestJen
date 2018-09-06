using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.AllModules
{
    public class BookingModuleReferences
    {
        private readonly IWebDriver driver;

        public BookingModuleReferences(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement UserNameLogin
        {
            get
            {
                return this.driver.FindElement(By.Id("loginMain_UserName"));
            }
        }

      public IWebElement UserPasswordLogin
        {
          get
            {
                return this.driver.FindElement(By.Id("loginMain_Password"));
            }
        }
     public IWebElement SubmitButtonLogin
      {
         get
          {
              return this.driver.FindElement(By.Id("loginMain_LoginButton"));
          }
      }

    public IWebElement BookingModuleIcon
     {
         get
         {
             return this.driver.FindElement(By.Id("ctl00_bookingsTextSpan"));
         }
     }

    public IWebElement CalendarIcon
    {
        get
        {
            return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_dtFrom_popupButton"));
        }
    }

     public IWebElement ClickSearchButton
    {
         get
        {
            return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSearchn"));
        }
    }

    public IWebElement ClickGoToSummaryButton
     {
         get
         {
             return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSaveNGoToSummary"));
         }
     }

        public IWebElement BookingTitle
    {
            get
        {
            return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtTitle"));
        }
    }

        public IWebElement SummaryHost
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input"));
            }
        }

        public IWebElement ContinueWithBooking
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnCreate"));
            }
        }

        public IWebElement SummarySaveAndExit
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSaveAndExit"));
            }
        }

       

    }
}