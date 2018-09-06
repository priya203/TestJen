using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.WebAppBookingSummaryPage
{
    public class BookingSummaryPageElements
    {
        private readonly IWebDriver browser;
        public BookingSummaryPageElements(IWebDriver browser)
        {
            this.browser = browser;
        }

      

        public IWebElement BookingTitle
        {
            get
            {
                return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$txtTitle"));
               // return this.browser.FindElement(By.XPath("//*[@id=\"ctl00_MainContentPlaceHolder_txtTitle\"])"));

            }
        }

        public IWebElement SummaryHost
        {
            get {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input"));
            }
        }
        public IWebElement FromDate
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_dtFrom_dateInput"));
                

            }
        }
        public IWebElement ToDate
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_dtTo_dateInput"));
                

            }
        }
        public IWebElement ResourceType
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlResourceType"));
          
            }
        }

        public IWebElement ClickOnParticipint
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='lblRoleName1']"));
            }
        }

        public IWebElement Save
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSave1"));

            }
        }
        public IWebElement SaveAndExit
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSaveExit"));

            }
        }
        public IWebElement refresh
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='lbtnRefresh']"));
            }
        }
        public IWebElement GoTODiary
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='diarySpan']"));
                //return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnGoToDiary"));
                                                       
                                                     

            }
        }



        public IWebElement AddonButton
        {
            get
            {
               // return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$grdSummary$ctl00$ctl04$ctl07"));
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSummary_ctl00_ctl04_tblWizardSteps']/tbody/tr[1]/td"));
            }
         }

        public IWebElement SelectingAddonfromCheckbox
        {
            get
            {
                return this.browser.FindElement(By.XPath("(//input[@type='checkbox'])[last()]"));

            }
        }

        public IWebElement AddSelectedAddons
        {
            get
            {
                return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$ctl00$btnAdd"));

            }
        }

         public IWebElement Summaryclick
        {
            get
            {
                return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$btnSaveAndGoToSummary"));
                                                        

            }
        }

         public IWebElement AddPplTab
         {
             get 
             {
                 return this.browser.FindElement(By.XPath("//*[@id=\"ctl00_MainContentPlaceHolder_tabctlSummary\"]/div[1]/ul[1]/li[2]/a[1]/span[1]/span[1]/span[1]"));
             }
         }

         public IWebElement EnterInternalVisitorName
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_txtSearch"));
             }
         }
         public IWebElement InternalVisitorsearchByNameclick
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_btnSearch"));
             }
         }
         public IWebElement AddEnterInternalVisitorcclick
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_grdAttendees_ctl00_ctl04_imgbtnAdd"));
             }
         }

         public IWebElement GoToSummaryPageFromAddon
         {
             get
             {
                 return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$btnGoToSummary"));
             }
         }
         public IWebElement PopUPHandlingForVisitors
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//span[@class='ui-button-text']"));
             }
         }
         public IWebElement ExternalVisitorRadioButton
         {
             get
             { 
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_rdExternal"));
             }
         }
         public IWebElement EnterLastName
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_ddlSearchContacts_Input"));
             }
         }
         public IWebElement EnterFirstName
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_txtFirstVisit"));
             }
         }

         public IWebElement TitleDropedown
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_ddlTitleVisit"));
             }
         }

         public IWebElement CompanyName
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_txtCompVisit"));
             }
         }
         
         public IWebElement Email
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_txtEmailVisit"));
             }
         }

         public IWebElement Telephone
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_txtTelVisit"));
             }
         }


         public IWebElement ClickonSaveExternalVisitors
         {
             get 
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ucBookingAttendee_btnSave"));
             }
         }


         public IWebElement SetUpTime
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_grdSummary_ctl00_ctl04_ddlSetupMinutes"));
             }
         }

         public IWebElement BreakdownTime
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_grdSummary_ctl00_ctl04_ddlBreakdownMinutes"));
             }
         }
 //***FFT200
         public IWebElement VerifyAddedAddonName
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ShTBLNo0']/tbody/tr/td/table[1]/tbody/tr[1]/td[3]/table"));
             }
         }
//***FFT46
           public IWebElement DisplayAlternateResourcePage
            {
                get 
                {
                    return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_lblFields']"));
                }
            }
        
   //***FFT49** Client Matter Information
        public IWebElement ClientMatterInformationTable
           {
               get
               {
                   return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_BookingUDF_Panel1']/fieldset/table/tbody/tr/td[1]"));
               }
           }
        public IWebElement AminitiesavailibleYes
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_BookingUDF_ctrlfa15927ba7fe0a4aabaa688adeec4c4538a3_chkBooleanValue']"));
            }
        }
        public IWebElement DeskLampAndRefirgerator
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_BookingUDF_ctrlbbdb7109a7772a47e0aa4dfa7ec2a42ce9cf_txtBoxField']"));
            }
        }
        public IWebElement InvalidUDFContentPopUp
        {
            get
            {
                return this.browser.FindElement(By.XPath("//span[@class='ui-dialog-title']"));
            }
         }
        public IWebElement PopUP_ClearValueFormDepentField
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='btnOk']/span"));
            }
        }

////Addon popUp
        public IWebElement AddonsOutofStockPopup
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='dvSumm']"));
            }
        }
//FFT256_Recurring Booking
        public IWebElement ClickOnRecurBookingButton
        {
            get {

                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnRecurrenceBooking"));
            }
        }
  //FFT256_Daily recur Booking if we create from Booking Summary Page
        public IWebElement RecurBookingFrame_BookingSummaryPage
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='frmPnlRecur']"));
            }
        }
        public IWebElement SelectDailyRecurBooking_BookingSummaryPage
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_rbtDaily']"));
            }
        }

        public IWebElement FromDateForRecurBooking
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_dtFrom_dateInput_wrapper']"));
            }
        }
        public IWebElement ToDateForRecurBooking
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_dtTo_dateInput']"));
            }
        }
        public IWebElement ShowTargetDate
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_btnShowTargetDates']"));
            }
        }
        public IWebElement ContinueWithBooking
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_btRepeats']"));
            }
        }
        public IWebElement ClickOnDateAndTimeOptionOnBookingSummaryPage
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSummary_ctl00_ctl04_lbtnStartTime']"));
            }
        }
//SwitchToframe
        public IWebElement SwitchToFrame
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='frmPnlMove']"));
            }
        }
        public IWebElement ClickOnTimeViewPopUP
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtFrom_timePopupLink']"));
            }
        }

        public IWebElement ClickOnToDate_TimeViewPopUp
        {
            get { 
             return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtTo_timePopupLink']"));
            }
        }

        public IWebElement Select_TOtime2_30pm
        {
            get {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtTo_timeView_tdl']/tbody/tr[9]/td[3]/a"));
            }
        }
        public IWebElement ClickOnTimeViewPopUP_Select2PM
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtFrom_timeView_tdl']/tbody/tr[9]/td[1]/a"));
            }
        }
        public IWebElement ClickOnTimeViewPopUP_Select3PM
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_ftdCopyMove_dtFrom_timeView_tdl']/tbody/tr[9]/td[5]/a"));
            }
        }
        public IWebElement ClickOnConfirmMoveBooking
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='rcRepeat_btRepeats']"));
            }
        }
        public IWebElement NavigateToServiceTrackerPage
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='serviceTrackerSpan']"));
            }
        }

        public IWebElement SelectNextDateOnserviceTracker
        {
            get { 
              return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnRight']"));
            }
        }
        public IWebElement checkCancelledBookingCheckboxonServiceTracker
        {
            get { 
             return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_chkShowCancelled']"));
            }
        }

        public IWebElement BookingStausDropdown
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlStatus"));
            }
        }

        public IWebElement SwitchToMessagFromWebApp
        {
            get {
                return this.browser.FindElement(By.XPath("/html/body/div[2]"));
            }
        }

        public IWebElement Acceptthemessage
        {
            get
            {
                return this.browser.FindElement(By.XPath("/html/body/div[2]/div[11]/div/button/span"));
            }
        }
        public IWebElement getReferenceNumber
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_lblReferenceNumber"));
            }
        }



      




        






       
    }
}
