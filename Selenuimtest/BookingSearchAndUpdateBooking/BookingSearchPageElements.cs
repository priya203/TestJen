using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.BookingSearchAndUpdateBooking
{
    public class BookingSearchPageElements
    {

        private readonly string ExistingBookingTitle = ConfigurationSettings.AppSettings["ExistingBooking_Title"];

         private readonly IWebDriver browser;
         public BookingSearchPageElements(IWebDriver browser)
        {
            this.browser = browser;
         }
         public IWebElement NavigatetoBookingtab
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='bookingsSpan']"));
             }
         }
         public IWebElement NavigatetoBookingSearch
         {
             get {
                 return this.browser.FindElement(By.XPath("//span[@id='ctl00_lblBookingsearch']"));
             }
         }
         public IWebElement NewBookingLinkEnabled
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnAdd']"));
             }
         }
         public IWebElement CopyBooking
         {
             get {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkCopy']"));
             }
         }
         public IWebElement DateChangeforCopyBooking
         {
             get {
                 return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtFrom_dateInput']"));
             }
         }
         public IWebElement ClickonconfirmCopyBooking
         {
             get {
                 return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_btRepeats']"));
             }
         }
         public IWebElement MoveBooking
         {
             get
             {
                // return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl19_lnkMove']"));
                 return this.browser.FindElement(By.LinkText("Move"));
             }
         }

         public IWebElement timepopup
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtFrom_timePopupLink']"));
             }
         }
        public IWebElement SelectTime1Pm
        {
        get{
            return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtFrom_timeView_tdl']/tbody/tr[8]/td[5]/a"));
        }
      }
        public IWebElement clickonconfirmMiveBooking
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_btRepeats']"));
            }
        }
        public IWebElement gettimeofMovedBooking
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00__0']/td[13]"));
                                                          //*[@id="ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00__0"]/td[13]
            }
        }

        public IWebElement clickonRecurBooking
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkRepeat']"));
            }
        }
        public IWebElement SelectDailyRecurring
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_rbtDaily']"));
            }
        }
        public IWebElement ClickOnShowTargetDates
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_btnShowTargetDates']"));
            }
        }
        public IWebElement CLickOnRecurBooking
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_btRepeats']"));
            }
        }
         public IWebElement BookingTitle_Hyperlink
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkGoToSummary']"));
             }
         }
     

       
         public IWebElement BookingTitle
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtBookingTitle"));
             }
         }
         public IWebElement BookingReference
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtRefNumber"));
             }
         }
         public IWebElement StartDate
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdpStartDate_dateInput"));
             }
         }
         public IWebElement EndDate
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdpEndDate_dateInput"));
             }
         }
         public IWebElement BookingType
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlBookingType"));
             }
         }
         public IWebElement BookingProperty
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlProperty"));
             }
         }
         public IWebElement Bookingstatus
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlStatus"));
             }
         }
        public IWebElement BookingHost
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtHost"));
             }
         }

   

         public IWebElement BookingSearcButton
         {
             get
             {
                 return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$btnSearch"));
             }
         }
         public IWebElement ClickonExistingBooking
         {
             get
             {
                 return this.browser.FindElement(By.LinkText(ExistingBookingTitle));
             }
         }

         public IWebElement clickonBookAnathrResorceForUpdate
         {
             get { 
             
              return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnBookAnotherResource1"));
             }
         }
         public IWebElement clickOnHostSearchIcon
         {
             get {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ibtnMagnify"));

             }
         }
         public IWebElement LocatingFrameForHostPopUP
         {
             get {
                 return this.browser.FindElement(By.XPath("//iframe[@name='radWndChangeHost']"));

             }
         }
         public IWebElement UpdateTheNewHostName
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//input[@name='txtSearch']"));

             }
         }

         public IWebElement ClickOnSearchButtonOnHostPopUP
         {
             get
             {
                 return this.browser.FindElement(By.Id("btnSeach"));

             }
         }
         public IWebElement ClickOnAddnewHostWhichMatchesSearchCriteria
         {
             get
             {
                 return this.browser.FindElement(By.Name("grdAttendees$ctl00$ctl04$imgbtnAdd"));

             }
         }
         public IWebElement NotesTable
         {
             get 
             {
                 return this.browser.FindElement(By.XPath("//*[@id=\"ctl00_MainContentPlaceHolder_pvSummary\"]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[2]"));
             }
         }
         public IWebElement ClickOnNotes

         {
             get
             {
                 return this.browser.FindElement(By.XPath("//textarea[@id='ctl00_MainContentPlaceHolder_txtNotes']"));
             }
         }
         public IWebElement ENterNotes
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//textarea[@id='txtArea']"));
             }
         }
         public IWebElement ClickonSaveNotes
         {
             get
             { 
             return this.browser.FindElement(By.XPath("//span[@class='ui-button-text']"));
             }
         }
         public IWebElement ClickonRegion
         {
             get
             {
                 return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$ddlRegion"));
             }
         }
         public IWebElement ClickOnSpecialRequest
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//textarea[@id='ctl00_MainContentPlaceHolder_txtSpecialRequest']"));
             }
         }
         public IWebElement EnterSpecialRequest
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//textarea[@id='txtArea']"));
             }
         }
         public IWebElement BookingStausDropdown
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlStatus"));
             }
         }

         public IWebElement clickonblnkArea
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//html"));
             }
         }
         public IWebElement participants
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtBookingCovers"));
             }
         }
         public IWebElement BookingTypedrop
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlBookingType"));
             }
         }
         public IWebElement PrimaryLocation
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlPrimaryLocation"));
             }
         }

         public IWebElement Requester
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ibtnBookedBy"));
             }
         }
         public IWebElement EnterUpdatedTitle
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtTitle"));
                  
             }
         }
         public IWebElement ClickOnSAveandExitUpdatedRecord
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSaveExit"));


             }
         }
//FFT_273_1_SelectFirstOccurance
         public IWebElement SelectFirstOccurance
         {
             get {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkGoToSummary']"));
             }
         }
//FFT256_Select Second Occurance
         public IWebElement FFT256_SelectSecondOccurance
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl07_lnkGoToSummary']"));


             }
         }
//FFT_SelectThird Occurance
         public IWebElement FFT256_SelectThirdOccurance
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl09_lnkGoToSummary']"));


             }
         }

         public IWebElement FFT256_OpenENtireSeries
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_rbtnEntireSeries']"));


             }
         }
         public IWebElement FFT256_ClickOnOkbuttonFor_openrecurringBooking
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnOkay']"));


             }
         }
         public IWebElement Temp
         {
             get
             {
                 return this.browser.FindElement(By.LinkText("Block32"));


             }
         }




    }
}
