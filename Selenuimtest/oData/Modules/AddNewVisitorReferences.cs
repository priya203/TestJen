using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace WorkspaceProject.Modules
{
    public class AddNewVisitorReferences
    {
        private readonly IWebDriver driver;

        public AddNewVisitorReferences(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AddNewVisitorbuttn
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnAddvisitor"));
            }
        }

        public IWebElement ExternalOption
        {
            get

            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdExternal"));

            }
        }
        public IWebElement LastNameTextbox
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchContacts_Input")); 

                
            }
        }
        public IWebElement FirstName
        {
            get {
                return this.driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtFirstName']"));
            }
        }

        public IWebElement clickonInternalVisitor
        {
            get { 
            return this.driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_rdInternal']"));
            }
        }
        public IWebElement LastName2
        {
            get
            {
        
                return this.driver.FindElement(By.XPath("//[@id=ctl00_MainContentPlaceHolder_ddlSearchContacts_Input]")); 
            }
        }
        public IWebElement Title
        {
            get

            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlTitle")); 
            }
        }
        public IWebElement DisplayName
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtDisplayName']"));
            }
        }
        public IWebElement HostName
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdHostName_Input")); 
            }
        }
        //public IWebElement DisplayName
        //{
        //    get {
        //        return this.driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtDisplayName']"));
        //    }
        //}

         public IWebElement ArrivalTime
         {
        get 
        {
            return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_chkArrivalTime")); 
    }
    }

        public IWebElement SaveButtn
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSave")); 
            }
        }
       public IWebElement PrintBadgeBttn
        {
           get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnPrint")); 
            }
        }
        //clicking on the OKbutton
        public IWebElement ClickOnOK
       {
           get
          
           {
               return this.driver.FindElement(By.ClassName("ui-button-text")); 
           }
       }
       //clicking on the HostNotfound
        public IWebElement HostNotFound
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnhostnotfound")); 
            }
        }
        //clicking on the last name field from the  HostNotfound
        public IWebElement LastNameHstntFound
        {
            get
            {
                return this.driver.FindElement(By.Id("ddlSearchContacts1_Input"));
            }
        }
        //HOST nOT found pop up 
        public IWebElement HostNotFoundPop
        {
            get
            {
                return this.driver.FindElement(By.Id("RadWindowWrapper_ctl00_MainContentPlaceHolder_radWndAddBookingPeople")); 
            }
        }

        public IWebElement Company
        {
            get
            {
                return this.driver.FindElement(By.Id("ddlHost")); 
            }
        }

        public IWebElement Savebttn1
        {
            get
            {
                return this.driver.FindElement(By.Id("btnSave")); 
            }
        }

    }


}