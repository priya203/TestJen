using OpenQA.Selenium;
using UnitTestProjectsummary.WebAppCreateBookingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitTestProjectsummary.WebAppBookingSummaryPage;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using OpenQA.Selenium.Interactions;


namespace UnitTestProjectsummary.BookingSearchAndUpdateBooking
{
    public class BookingSearchMainPage
    {
        private readonly string HostForCreateBooking = ConfigurationSettings.AppSettings["HostName_CreateBooking"];
        private readonly string RequesterName_CreateBooking = ConfigurationSettings.AppSettings["RequesterName_CreateBooking"];


        private readonly string ExistingBookingTitle = ConfigurationSettings.AppSettings["SearchBooking_Title"];
        private readonly string ExistingBookingRefNumber = ConfigurationSettings.AppSettings["SearchBooking_RefNumber"];
        private readonly string ExistingBookingFromDate = ConfigurationSettings.AppSettings["SearchBooking_FromDate"];
        private readonly string ExistingBookingToDate = ConfigurationSettings.AppSettings["SearchBooking_ToDate"];
        private readonly string ExistingBookingHost = ConfigurationSettings.AppSettings["SearchBooking_Host"];

        private readonly string ExistingBookingType = ConfigurationSettings.AppSettings["BookingType"];
        private readonly string ExistingBookingProperty = ConfigurationSettings.AppSettings["Property"];
        private readonly string ExistingBookingStatus = ConfigurationSettings.AppSettings["BookingSTatus"];


        private readonly string New_Title = ConfigurationSettings.AppSettings["New_Title"];
        private readonly string New_Host = ConfigurationSettings.AppSettings["New_Host"];
        private readonly string New_Requester = ConfigurationSettings.AppSettings["New_Requester"];
        private readonly string Notes = ConfigurationSettings.AppSettings["Notes"];
        private readonly string SpecialRequest = ConfigurationSettings.AppSettings["SpecialRequest"];
        private readonly string participants_Count = ConfigurationSettings.AppSettings["participants_Count"];
        private readonly string SearchPageBookingTitle = ConfigurationSettings.AppSettings["BookingTitle"];

        public BookingSearchMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        public BookingSearchMainPage()
        {

        }

        public BookingSearchPageElements SearchMap
        {
            get
            {
                return new BookingSearchPageElements(this.browser);
            }


        }

        public BookingSearchPageValidators SearchValidate()
        {
            return new BookingSearchPageValidators(this.browser);
        }

        public void NavigateBookingSearch()
        {
            this.SearchMap.NavigatetoBookingSearch.Click();

        }
        public void bookingsearchnavigationscratch()
        {
            this.SearchMap.NavigatetoBookingtab.Click();
            this.SearchMap.NavigatetoBookingSearch.Click();}

        public void EnterSearcCriteria()
        {
            
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnAdd']")));
            this.SearchMap.BookingTitle.SendKeys(ExistingBookingTitle);
            Thread.Sleep(2000);
            this.SearchMap.BookingReference.SendKeys(ExistingBookingRefNumber);
            Thread.Sleep(2000);
            this.SearchMap.StartDate.Clear();
            Thread.Sleep(2000);
            this.SearchMap.StartDate.SendKeys(ExistingBookingFromDate);
            Thread.Sleep(2000);
            this.SearchMap.EndDate.SendKeys(ExistingBookingToDate);
            Thread.Sleep(2000);
            this.SearchMap.BookingHost.SendKeys(ExistingBookingHost);
        }

       
        public void selectBookingTypedrop()
        {
            var dropedown1 = this.SearchMap.BookingType;
            var SelectElement = new SelectElement(dropedown1);
            Thread.Sleep(2000);
            //SelectElement.SelectByIndex(2);
            SelectElement.SelectByText(ExistingBookingType);
            Thread.Sleep(3000);
        }

        public void selectpropertyDroperdown()
        {
            var dropedown2 = this.SearchMap.BookingProperty;
            var SelectElement = new SelectElement(dropedown2);
            Thread.Sleep(2000);
            //SelectElement.SelectByIndex(4);
            SelectElement.SelectByText(ExistingBookingProperty);
            Thread.Sleep(3000);
        }

        public void SelectStatusDroperdown()
        {
            var dropedown2 = this.SearchMap.Bookingstatus;
            var SelectElement = new SelectElement(dropedown2);
            Thread.Sleep(2000);
            //SelectElement.SelectByIndex(3);
            SelectElement.SelectByText(ExistingBookingStatus);
            Thread.Sleep(3000);
        }

        public void CLickOnBookingSearchandSelectTheRecord()
        {
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickonExistingBooking.Click();
            Thread.Sleep(2000);
        }
        public void ClickOnBookAnatherResourceForUpdateBooking()
        {
            this.SearchMap.clickonBookAnathrResorceForUpdate.Click();
        }
        public void UpdateHost()
        {
            Thread.Sleep(5000);
            this.SearchMap.clickOnHostSearchIcon.Click();
            Thread.Sleep(2000);
            IWebElement Frame1 = this.SearchMap.LocatingFrameForHostPopUP;
            browser.SwitchTo().Frame(Frame1);
            this.SearchMap.UpdateTheNewHostName.Click();
            Thread.Sleep(2000);
            this.SearchMap.UpdateTheNewHostName.SendKeys(New_Host);
            Thread.Sleep(2000);
            this.SearchMap.ClickOnSearchButtonOnHostPopUP.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickOnAddnewHostWhichMatchesSearchCriteria.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().DefaultContent();
        }

        public void ENterHost()
        {
            Thread.Sleep(5000);

            this.SearchMap.clickOnHostSearchIcon.Click();
            Thread.Sleep(2000);
            IWebElement Frame1 = this.SearchMap.LocatingFrameForHostPopUP;
            browser.SwitchTo().Frame(Frame1);
            this.SearchMap.UpdateTheNewHostName.Click();
            Thread.Sleep(4000);
            this.SearchMap.UpdateTheNewHostName.SendKeys(HostForCreateBooking);
            Thread.Sleep(2000);
            this.SearchMap.ClickOnSearchButtonOnHostPopUP.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickOnAddnewHostWhichMatchesSearchCriteria.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().DefaultContent();
        }
        public void EnterNotesForCreateBooking()
        {
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[2]"));
            Thread.Sleep(3000);
            this.SearchMap.ClickOnNotes.Click();
            Thread.Sleep(2000);
            this.SearchMap.ENterNotes.SendKeys("TestBookingwithAllParams");
            Thread.Sleep(2000);
            this.SearchMap.ClickonSaveNotes.Click();
            this.SearchMap.ClickonRegion.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickonRegion.Click();
            browser.SwitchTo().DefaultContent();
        }
        public void Update_Notes()
        {
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[2]"));
            Thread.Sleep(3000);
            this.SearchMap.ClickOnNotes.Click();
            Thread.Sleep(2000);
            this.SearchMap.ENterNotes.SendKeys("Notes");
            Thread.Sleep(2000);
            this.SearchMap.ClickonSaveNotes.Click();
            this.SearchMap.ClickonRegion.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickonRegion.Click();
            browser.SwitchTo().DefaultContent();
        }
        public void UpdateSpecialRequest_bookingStatus()
        {
            browser.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[3]"));
            Thread.Sleep(1000);
            this.SearchMap.ClickOnSpecialRequest.Click();
            Thread.Sleep(1000);
            this.SearchMap.EnterSpecialRequest.SendKeys(SpecialRequest);
            Thread.Sleep(2000);
            this.SearchMap.ClickonSaveNotes.Click();
            Thread.Sleep(2000);
            this.SearchMap.BookingStausDropdown.Click();
            var statusdropdown = this.SearchMap.BookingStausDropdown;
            SelectElement drop = new SelectElement(statusdropdown);
            drop.SelectByIndex(3);
            Thread.Sleep(1000);
            this.SearchMap.BookingStausDropdown.Click();
            browser.SwitchTo().DefaultContent();
        }

        public void EnterSpecialRequest_bookingStatus()
        {
            browser.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[3]"));
            Thread.Sleep(1000);
            this.SearchMap.ClickOnSpecialRequest.Click();
            Thread.Sleep(1000);
            this.SearchMap.EnterSpecialRequest.SendKeys("RoomSHouldHaveGardenView");
            Thread.Sleep(2000);
            this.SearchMap.ClickonSaveNotes.Click();
            Thread.Sleep(2000);
            this.SearchMap.BookingStausDropdown.Click();
            var statusdropdown = this.SearchMap.BookingStausDropdown;
            SelectElement drop = new SelectElement(statusdropdown);
            drop.SelectByIndex(6);
            Thread.Sleep(1000);
            this.SearchMap.BookingStausDropdown.Click();
            browser.SwitchTo().DefaultContent();
        }
        public void UpdateParticipants_BookingType()
        {

            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id=\'ctl00_MainContentPlaceHolder_pvSummary\']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[1]"));
            Thread.Sleep(3000);
            this.SearchMap.participants.Click();
            Thread.Sleep(3000);
            this.SearchMap.participants.SendKeys(participants_Count);
            Thread.Sleep(3000);
            var dropedown11 = this.SearchMap.BookingTypedrop;
            SelectElement sel = new SelectElement(dropedown11);
            sel.SelectByIndex(5);
            this.SearchMap.PrimaryLocation.Click();
            Thread.Sleep(3000);
            this.SearchMap.PrimaryLocation.Click();
            browser.SwitchTo().DefaultContent();
        }



        public void UpdateRequester()
        {
            Thread.Sleep(3000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id=\'ctl00_MainContentPlaceHolder_tblBookingRole\']/tbody[1]/tr[1]/td[1]/fieldset[1]/div[2]/table[1]/tbody[1]/tr[1]/td[5]"));
                                                                     //*[@id="ctl00_MainContentPlaceHolder_tblBookingRole"]/tbody[1]/tr[1]/td[1]/fieldset[1]/div[2]/table[1]/tbody[1]/tr[1]/td[5]
            Thread.Sleep(2000);
            this.SearchMap.Requester.Click();
            IWebElement Frame1 = this.SearchMap.LocatingFrameForHostPopUP;
            browser.SwitchTo().Frame(Frame1);
            Thread.Sleep(3000);
            this.SearchMap.UpdateTheNewHostName.Click();
            Thread.Sleep(2000);
            this.SearchMap.UpdateTheNewHostName.SendKeys(New_Requester);
            Thread.Sleep(2000);
            this.SearchMap.ClickOnSearchButtonOnHostPopUP.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickOnAddnewHostWhichMatchesSearchCriteria.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().DefaultContent();
        }

        public void ENterRequester()
        {
            Thread.Sleep(2000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id=\'ctl00_MainContentPlaceHolder_tblBookingRole\']/tbody[1]/tr[1]/td[1]/fieldset[1]/div[2]/table[1]/tbody[1]/tr[1]/td[5]"));
            //*[@id="ctl00_MainContentPlaceHolder_tblBookingRole"]/tbody[1]/tr[1]/td[1]/fieldset[1]/div[2]/table[1]/tbody[1]/tr[1]/td[5]
            Thread.Sleep(2000);
            this.SearchMap.Requester.Click();
            IWebElement Frame1 = this.SearchMap.LocatingFrameForHostPopUP;
            browser.SwitchTo().Frame(Frame1);
            Thread.Sleep(3000);
            this.SearchMap.UpdateTheNewHostName.Click();
            Thread.Sleep(2000);
            this.SearchMap.UpdateTheNewHostName.SendKeys(RequesterName_CreateBooking);
            Thread.Sleep(2000);
            this.SearchMap.ClickOnSearchButtonOnHostPopUP.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickOnAddnewHostWhichMatchesSearchCriteria.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().DefaultContent();
        }

        public void EnterNewTitle()
        {
            this.SearchMap.EnterUpdatedTitle.Clear();
            Thread.Sleep(2000);
            this.SearchMap.EnterUpdatedTitle.SendKeys(New_Title);
            Thread.Sleep(2000);
        }
        public void ClickonSaveEditedrecord()
        {
            this.SearchMap.ClickOnSAveandExitUpdatedRecord.Click();
        }
//FFT_256_Booking Search
        public void FFT_256_BookingSearch_SelectSecondOccurance()
        {
            this.SearchMap.BookingTitle.SendKeys("FFT266RecurringBooking105");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_SelectSecondOccurance.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_ClickOnOkbuttonFor_openrecurringBooking.Click();
        }
        public void FFT_256_BookingSearch_SelectThirdOccurance()
        {
            this.SearchMap.BookingTitle.SendKeys("FFT266RecurringBooking105");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_SelectThirdOccurance.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_OpenENtireSeries.Click();
            this.SearchMap.FFT256_ClickOnOkbuttonFor_openrecurringBooking.Click();
        }
  //FFT_273_1_BookingSeach
        public void FFT_273_1_BookingSearch()
        {
            NavigateBookingSearch();
            Thread.Sleep(2000);
            this.SearchMap.BookingTitle.SendKeys("FFT_273_1");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.SelectFirstOccurance.Click();
            Thread.Sleep(2000);}

 //FFT_274_BookingSearch
        public void FFT_274_BookingSearch()
        {
            NavigateBookingSearch();
            Thread.Sleep(2000);
            this.SearchMap.BookingTitle.SendKeys("FFT_274");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.SelectFirstOccurance.Click();
            Thread.Sleep(2000);
        }

        public void check_bookingsearchpageEnabled()
        {  
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnAdd']")));
            Assert.IsTrue(this.SearchMap.NewBookingLinkEnabled.Enabled,"Assert Fail due to link is not enabled");
            Assert.IsTrue(this.SearchMap.BookingSearcButton.Enabled,"Assert Fail due to search button is not enabled");
         }

        public void NewBookingPageLink()
        {
            this.SearchMap.NewBookingLinkEnabled.Click();
            Thread.Sleep(3000);
            string elemnt = browser.Title;
            Console.WriteLine(elemnt);
            Assert.IsTrue(elemnt.Equals("New Booking"));
        }

        public void CreateBookingSearchNewBookingPage()
        {
            this.SearchMap.NewBookingLinkEnabled.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_dateInput']")));

        }
        public void searchBookingwith_TitleandDate()
        { 
            this.SearchMap.BookingTitle.SendKeys(SearchPageBookingTitle);
            Thread.Sleep(2000);
            this.SearchMap.StartDate.Clear();

            var today = DateTime.Today;
            var tomorrow = today.AddDays(2);
            string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy");
            this.SearchMap.StartDate.SendKeys(tomorrowFrom);
            this.SearchMap.BookingSearcButton.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkGoToSummary']")));
            String name=this.SearchMap.SelectFirstOccurance.GetAttribute("title");
            Console.WriteLine(name);
            Assert.IsTrue(name.Equals(SearchPageBookingTitle));}

        public void SerachForCopiedBooking()
        { 
         this.SearchMap.BookingTitle.SendKeys(SearchPageBookingTitle);
            Thread.Sleep(2000);
            this.SearchMap.StartDate.Clear();

            var today = DateTime.Today;
            var tomorrow = today.AddDays(3);
            string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy");
            this.SearchMap.StartDate.SendKeys(tomorrowFrom);
            this.SearchMap.BookingSearcButton.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkGoToSummary']")));
            String name=this.SearchMap.SelectFirstOccurance.GetAttribute("title");
            Console.WriteLine(name);
            Assert.IsTrue(name.Equals(SearchPageBookingTitle));
        }

        public void verifyBookingHyperlink_InBookingTitle()
        {
            this.SearchMap.BookingTitle_Hyperlink.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtTitle']")));
            IWebElement Title = browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtTitle"));
            String tt = Title.GetAttribute("value");
            Console.WriteLine(tt);
            Assert.IsTrue(tt.Equals(SearchPageBookingTitle));
        }

        public void CopyBooking()
        {
            this.SearchMap.CopyBooking.Click();
            Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmPnlCopy']")));
            IWebElement frame1=browser.FindElement(By.XPath("//*[@id='frmPnlCopy']"));
            browser.SwitchTo().Frame(frame1);
            this.SearchMap.DateChangeforCopyBooking.Clear();
            var today = DateTime.Today;
            var tomorrow = today.AddDays(3);
            string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.SearchMap.DateChangeforCopyBooking.SendKeys(tomorrowFrom);
            this.SearchMap.DateChangeforCopyBooking.SendKeys(Keys.Enter);
            this.SearchMap.ClickonconfirmCopyBooking.Click();
            //this.SearchMap.DateChangeforCopyBooking.Click();
            //browser.FindElement(By.XPath("//html")).Click();
 
             
                // this.SearchMap.timepopup.Click();//clicking on timepop
            }
        public void MoveBooking()
        {
            Thread.Sleep(3000);
            this.SearchMap.MoveBooking.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmPnlMove']")));
            IWebElement frame2 = browser.FindElement(By.XPath("//*[@id='frmPnlMove']"));
            browser.SwitchTo().Frame(frame2);
            Thread.Sleep(2000);
            this.SearchMap.timepopup.Click();//clicking on timepop
            Thread.Sleep(2000);
            this.SearchMap.SelectTime1Pm.Click();
            Thread.Sleep(2000);
            this.SearchMap.clickonconfirmMiveBooking.Click();
            browser.Navigate().Refresh();
           
        }
        public void VerifyMovedBookingTime()
        { 
          Thread.Sleep(3000);
          String time = this.SearchMap.gettimeofMovedBooking.Text;
          Console.Write(time);
          var today = DateTime.Today;
          var tomorrow = today.AddDays(2);
          string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
          String abc = tomorrowFrom + " 13:00";
          Console.WriteLine(abc);
          Assert.IsTrue(time.Equals(abc),"Assert failure due to mismatch in time prvided");
          }

      public void RecurBookings()
        {   Thread.Sleep(3000);
            this.SearchMap.clickonRecurBooking.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmPnlRecur']")));
            IWebElement frame2 = browser.FindElement(By.XPath("//*[@id='frmPnlRecur']"));
            browser.SwitchTo().Frame(frame2);
            Thread.Sleep(2000);
            this.SearchMap.SelectDailyRecurring.Click();

            var today = DateTime.Today;
            var tomorrow = today.AddDays(4);
            string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            IWebElement ToDate = browser.FindElement(By.XPath("//*[@id='rcRepeat_dtTo_dateInput']"));
            Actions action = new Actions(browser);
            action.MoveToElement(ToDate).Click().SendKeys(tomorrowFrom).Build().Perform();
            action.MoveToElement(ToDate).Click().SendKeys(Keys.Enter);
            this.SearchMap.ClickOnShowTargetDates.Click();
            this.SearchMap.CLickOnRecurBooking.Click();
            Thread.Sleep(4000);}

      public void SerachForRecurringBooking()
      {
          this.SearchMap.BookingTitle.SendKeys(SearchPageBookingTitle);
          Thread.Sleep(2000);
          this.SearchMap.StartDate.Clear();

          var today = DateTime.Today;
          var tomorrow = today.AddDays(4);
          string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy");
          this.SearchMap.StartDate.SendKeys(tomorrowFrom);
          this.SearchMap.BookingSearcButton.Click();
          WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
          wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkGoToSummary']")));
          String name = this.SearchMap.SelectFirstOccurance.GetAttribute("title");
          Console.WriteLine(name);
          Assert.IsTrue(name.Equals(SearchPageBookingTitle));
      }


        public void bookingsearch_MultipleInput()
        {
            this.SearchMap.BookingSearcButton.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSearchedBookingItems_ctl00_ctl05_lnkGoToSummary']")));
            String name = this.SearchMap.SelectFirstOccurance.GetAttribute("title");
            Console.WriteLine(name);
            Assert.IsTrue(name.Equals(ExistingBookingTitle));
         }


             public void temp1()
        { 
            bool breakLoop = false;
            while (!breakLoop)
            {
             Thread.Sleep(3000);
              try
                {
                   Assert.IsTrue(this.SearchMap.Temp.Enabled,"Assert fails");
                   this.SearchMap.Temp.Click();
                   breakLoop = true;
                }
              catch
              {
                  browser.FindElement(By.XPath("//*[@id='RadSliderIncrease_ctl00_MainContentPlaceHolder_grdList_ctl00_ctl03_ctl01_GridSliderPager']/span")).Click();
               } 
        }

        
        }

    

       

        public IWebDriver browser { get; set; }
    }
}

        
        




    


