using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.WebAppCreateBookingPage
{
   public class CreateBookingPageElements
    {
       private IWebDriver webDriver;


       private readonly IWebDriver browser;
       public CreateBookingPageElements(IWebDriver browser)
       {
           this.browser = browser;
       }

        public CreateBookingPageElements()
        {
            // TODO: Complete member initialization
        }

        //public CreateBookingPageElements(IWebDriver webDriver)
        //{
        //    // TODO: Complete member initialization
        //    this.webDriver = webDriver;
        //}

       public IWebElement SearchButton
        {
            get
            {
                return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$btnSearchn"));
            }   
        }

       public IWebElement SelctResource
       {
           get
           {
               return this.browser.FindElement(By.XPath("(//input[@type='checkbox'])[last()]"));
           }
       }


       public IWebElement SummaryPage
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSaveNGoToSummary"));
           }
       }
       public IWebElement ResourceType
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddlResourceType']"));
           }
       }
       public IWebElement SelectProperties
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_cmbProperties_cmbList_Input']"));
                                                         
           }
       }
       public IWebElement SelectTimePopUP_FromTime
       {
           get {
               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_timeView_selectedCell']/a"));
           }
       }
//Update Time while creating new Booking
       public IWebElement ClickOn_FromDateTimePopUP
       {
           get
           {

               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_timePopupLink']"));
           }
       }
       public IWebElement SelectDate_1PMTimePopUP
       {
           get
           {

               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_timeView_tdl']/tbody/tr[10]/td[5]/a"));
           }
       }
       public IWebElement SelectDate_3PMTimePopUP
       {
           get
           {

               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_timeView_tdl']/tbody/tr[12]/td[1]/a"));
           }
       }

       public IWebElement SelectTime_3AMTimePopUP
       {
           get
           {

               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_timeView_selectedCell']"));
           }
       }
//Update From and To Date
       public IWebElement FromDate
       {
           get
           {

               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_dateInput']"));
           }
       }
       public IWebElement ToDate
       {
           get
           {

               return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtTo_dateInput']"));
           }
       }
      
      
     





       //public IWebDriver browser { get; set; }
    }
}
