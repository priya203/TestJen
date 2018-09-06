using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
//using MFPOMProject.PageObjects;

namespace UnitTestProjectsummary.AllModules
{
    public class BookingModuleMethods
    {
        private IWebDriver driver;
        public BookingModuleMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected BookingModuleReferences Map
        {
            get
            {
                return new BookingModuleReferences(this.driver);
            }
        }

        public void NavigateToSignIn()
        {
            this.driver.Navigate().GoToUrl("http://localhost/WebAppVV6_3");
            driver.FindElement(By.Id("btnOk")).Click();
            this.Map.UserNameLogin.SendKeys("gg");
            Thread.Sleep(1000);
            this.Map.UserPasswordLogin.SendKeys("gg");
            Thread.Sleep(1000);
            this.Map.SubmitButtonLogin.Click();
        }

        public void ClickBookingsIcon()
        {
            this.Map.BookingModuleIcon.Click();
        }

        public void ClickOnCalendarIcon()
        {
            this.Map.CalendarIcon.Click();

        }

        public void ClickSearchButton()
        {
            driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSearchn")).Click();
        }

        public void ClickOnResource()
        {
            IWebElement element = driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_grdSearchResults_ctl00_ctl06_chkSelect_b8cf78d6-6610-4571-b182-22e574d14970"));

            if (!element.Selected)
            {
                element.Click();
            }
        }

        public void ClickSummaryButton()
        {
            BookingModuleReferences browser = new BookingModuleReferences(this.driver);
            browser.ClickGoToSummaryButton.Click();
        }

        public void BookingTitleText()
        {
            BookingModuleReferences browser = new BookingModuleReferences(this.driver);
            browser.BookingTitle.Click();
            Thread.Sleep(1000);
            browser.BookingTitle.SendKeys("MFTest");
        }

        public void BookingHostField()
        {
            BookingModuleReferences browser = new BookingModuleReferences(this.driver);
            browser.SummaryHost.Clear();
            Thread.Sleep(1000);
            browser.SummaryHost.Click();
            Thread.Sleep(1000);
            browser.SummaryHost.SendKeys("Muhammad");
            Thread.Sleep(1000);
            // for (int i = 0; i < 4; i ++ )
            // {
            //   driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input")).SendKeys(Keys.ArrowDown);

            //  if (i == 3)
            // {
            // driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input")).SendKeys(Keys.Enter);
            // }

            //  }
            browser.SummaryHost.SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);
            browser.SummaryHost.SendKeys(Keys.Enter);
            /*
            IWebElement element = driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input"));
            IList<IWebElement> AllDropDownList = element.FindElements(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input"));
            int DPListCount = AllDropDownList.Count;
            for (int i = 0; i < DPListCount; i++)
            {
                if (AllDropDownList[i].Text == "Faridoon Muhammad - MuhammadF@nfstechgroup.com")
                {
                    AllDropDownList[i].Click();
                }
                */
        }


        public void CreateBookingAtNine()
        {
            Actions action = new Actions(driver);

            IWebElement browser = driver.FindElement(By.Id("Cell021021"));

            action.DoubleClick(browser).Build().Perform();
        }

        public void ContinueBookingFromDiary()
        {
            BookingModuleReferences browser = new BookingModuleReferences(this.driver);
            browser.ContinueWithBooking.Click();


        }

        public void SaveAndExit()
        {
            BookingModuleReferences browser = new BookingModuleReferences(this.driver);
            browser.SummarySaveAndExit.Click();
        }
    }
}