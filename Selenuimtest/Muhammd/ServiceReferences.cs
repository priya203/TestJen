using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.AllModules
{
    public class ServiceReferences
    {
        private readonly IWebDriver driver;

        public ServiceReferences(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement UserNameInfo2
        {
            get
            {
                return this.driver.FindElement(By.Id("loginMain_UserName"));
            }
        }

        public IWebElement PasswordInfo2
        {
            get
            {
                return this.driver.FindElement(By.Id("loginMain_Password"));
            }
        }

        public IWebElement SubmitButton2
        {
            get
            {
                return this.driver.FindElement(By.Id("loginMain_LoginButton"));
            }
        }



        public IWebElement ServiceModuleIcon
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_serviceTrackerTextSpan"));
            }
        }

        public IWebElement FindAddonsByReferenceNumber
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtRefNo"));
            }
        }

        public IWebElement FindAddonsByBookingTitle
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtTitle"));
            }
        }

        public IWebElement ClickSearchButton
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSearch"));
            }
        }

        public IWebElement ApproveService
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_grdService_ctl00_ctl04_imgbtnAccept"));
            }
        }

        public IWebElement PropertyDropDown
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_cmbProperties_cmbList_Input"));
            }
        }

        public IWebElement ServiceNotes
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_grdService_ctl00_ctl04_imgbtnNotes"));
            }
        }
        public IWebElement NotesTextArea
        {
            get {

                return this.driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdService_ctl00_ctl04_txtNotes']"));
            }
        }
        public IWebElement Quantity
        { 
            get{
                return this.driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdService_ctl00__0']/td[9]"));
            }
        }

        public IWebElement ServiceNotesSaveButton
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_grdService_ctl00_ctl04_imgbtnSave"));
            }
        }

        public IWebElement ClickOnNextDayArrow
        {
            get 
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnRight"));
            }

        }

        public IWebElement ClickOnTodayDate
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_lnkToday"));
            }
        }

        public IWebElement DepartmentDropDown
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlServiceProvider"));
            }
        }
            

    }


    }