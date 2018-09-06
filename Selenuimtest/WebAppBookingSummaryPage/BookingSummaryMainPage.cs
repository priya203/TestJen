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
using OpenQA.Selenium.Interactions;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;


namespace UnitTestProjectsummary.PageElements
{
    public class BookingSummaryMainPage : LoginMainPage
    {
        private readonly string Title = ConfigurationSettings.AppSettings["Title"];
        private readonly string FromDate = ConfigurationSettings.AppSettings["FromDate"];
        private readonly string ToDate = ConfigurationSettings.AppSettings["ToDate"];
       // private readonly string InternalVisitorName = ConfigurationSettings.AppSettings["InternalVisitorName"];

        private readonly string InternalVisitorName = ConfigurationSettings.AppSettings["InternalVisitorname"];
        private readonly string diaryPageurl = ConfigurationSettings.AppSettings["diaryPage"];
        private readonly string SearchPageBookingTitle = ConfigurationSettings.AppSettings["BookingTitle"];
        private readonly string AuthrizationBookingTitle = ConfigurationSettings.AppSettings["BookingTitleForAuthrization"];

        public BookingSummaryMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        public BookingSummaryMainPage()
        {

        }

        public BookingSummaryPageElements BookingSummaryMap
        {
            get
            {
                return new BookingSummaryPageElements(this.browser);
            }


        }

        public BookingSummaryPageValidators BookingSummaryValidate()
        {
            return new BookingSummaryPageValidators(this.browser);
        }


        public void EnterTitle()
        {this.BookingSummaryMap.BookingTitle.SendKeys(Title);}

        public void EnterTitleSanity_NewBooking()
        { this.BookingSummaryMap.BookingTitle.SendKeys("TestBooking"); }

        public void EnterTitleSanity_DiaryBooking()
        { this.BookingSummaryMap.BookingTitle.SendKeys("BookingFromDiary"); }

        public void EnterTitleForPastBooking()
        { this.BookingSummaryMap.BookingTitle.SendKeys("PastBooking"); }

        public void EnterUpdatedTitleForPastBooking()
        {
            this.BookingSummaryMap.BookingTitle.Clear();
            this.BookingSummaryMap.BookingTitle.SendKeys("UpdatedPastBooking"); }

        public void EnterTitleForFutureBooking()
        { this.BookingSummaryMap.BookingTitle.SendKeys("FutureBooking"); }

        public void EnterupdatedTitleForFutureBooking()
        {
            this.BookingSummaryMap.BookingTitle.Clear();
            this.BookingSummaryMap.BookingTitle.SendKeys("UpdatedFutureBooking"); }

        public void EnterTitleFFT_46Case1()
        { this.BookingSummaryMap.BookingTitle.SendKeys("FFT46_Case1"); }

        public void EnterTitleFFT_46Case2()
        { this.BookingSummaryMap.BookingTitle.SendKeys("FFT46_Case2"); }

        public void EnterTitleFFT_200()
        { this.BookingSummaryMap.BookingTitle.SendKeys("FFT200DragAndDrop"); }
        public void EnterTitleFFT_202()
        { this.BookingSummaryMap.BookingTitle.SendKeys("FFT202DragAndDrop"); }
        public void EnterTitleSanityAddonVCheck()
        { this.BookingSummaryMap.BookingTitle.SendKeys("AddonVisitorCheck"); }
        public void EnterTitle_NewBookingFromSearchPage()
        { this.BookingSummaryMap.BookingTitle.SendKeys(SearchPageBookingTitle); }
        public void EnterTitle_AuthrizationRequestBooking()
        { this.BookingSummaryMap.BookingTitle.SendKeys(AuthrizationBookingTitle); }


      
        public void clickonsave()
        {
            this.BookingSummaryMap.Save.Click();

        }


        public void Status_Request()
        {
            Thread.Sleep(3000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[3]"));
            Thread.Sleep(1000);
            IWebElement web= browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlStatus"));
            SelectElement drop = new SelectElement(web);
            drop.SelectByText("Request / Demande");
            Thread.Sleep(1000);
            web.Click();
            browser.SwitchTo().DefaultContent();

        }


        public void AcceptSaveBookingPopUP()
        {
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_MainContentPlaceHolder_lblReferenceNumber")));
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]"));
            Thread.Sleep(2000);
            this.BookingSummaryMap.Acceptthemessage.Click();
            Thread.Sleep(4000);
            //GetReferenceNumber();
        }

        public void GetReferenceNumber()
        {
             IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.Id("ctl00_MainContentPlaceHolder_lblReferenceNumber"));
            IList<IWebElement> all = new List<IWebElement>(ec);
            foreach (var item in all)
            {   
                Console.WriteLine(item.Text);
                Console.WriteLine("\n");    
            }
         }

   
        public void Get_TitileForexistingBooking()
        {

            IWebElement Title = browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtTitle"));
            String tt = Title.GetAttribute("value");
            Console.WriteLine("Title:-      " +tt);
            Console.WriteLine("\n");

        //    //IReadOnlyCollection<IWebElement> ec = browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtTitle"));
        //    IList<IWebElement> all = new List<IWebElement>(ec);
        //    foreach (var item in all)
        //    {
        //        Console.WriteLine("Title is:- "+item.Text);
        //        Console.WriteLine("\n");
        //    }
        }
        public void Get_HostForexistingBooking()
        {
            IWebElement Host = browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input"));
           String HostC= Host.GetAttribute("value");
           Console.WriteLine("Host:-      " + HostC);
           Console.WriteLine("\n");



            //IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.Id("ctl00_MainContentPlaceHolder_ddlSearchHost_Input"));
            //IList<IWebElement> all = new List<IWebElement>(ec);
            //foreach (var item in all)
            //{ 
              
            //    Console.WriteLine("\n");
            //}
        }
        public void Get_RequesterForexistingBooking()
        {
            IWebElement Req = browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlBookedBy_Input"));
            String Requester = Req.GetAttribute("value");
            Console.WriteLine("Requester:-       " + Requester);
            Console.WriteLine("\n");

            //IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.Id("ctl00_MainContentPlaceHolder_ddlBookedBy_Input"));
            //IList<IWebElement> all = new List<IWebElement>(ec);
            //foreach (var item in all)
            //{
            //    Console.WriteLine("Requester:- "+item.Text);
            //    Console.WriteLine("\n");
            //}
        }
        public void Get_StatusForexistingBooking()
        {
            IWebElement Sttus = browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlStatus"));
            String sst = Sttus.Text;
            Console.WriteLine("Status:-   " + sst);

            //IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.Id("ctl00_MainContentPlaceHolder_ddlStatus"));
            //IList<IWebElement> all = new List<IWebElement>(ec);
            //foreach (var item in all)
            //{
            //    Console.WriteLine("Status:- "+item.Text);
            //    Console.WriteLine("\n");
            //}
        }
        public void GetAllDetails()
        {
            Get_TitileForexistingBooking();
            Get_HostForexistingBooking();
            Get_RequesterForexistingBooking();
            //Get_StatusForexistingBooking();
            GetReferenceNumber();

        }
        
        public void clickOnParticipant()
        {
            this.BookingSummaryMap.ClickOnParticipint.Click();
            Thread.Sleep(2000);
            IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.XPath("//*[@id='ShTBLNo1']/td[1]"));
            IList<IWebElement> all = new List<IWebElement>(ec);
            foreach (var item in all)
            {
                Console.WriteLine("Participants are:- "+item.Text);
                Console.WriteLine("\n");
            }
        }


        public void clickonsaveAndExit()
        {
            this.BookingSummaryMap.SaveAndExit.Click();

        }

        public void clickonGoToDIary()
        {
            this.browser.Navigate().GoToUrl(diaryPageurl);
            //this.BookingSummaryMap.GoTODiary.Click();
        }

        public void clickonGoToRefresh()
        {
            this.BookingSummaryMap.refresh.Click(); 
            //this.BookingSummaryMap.GoTODiary.Click();
        }



     
        public void clickonAddPplTab()
        {
            this.BookingSummaryMap.AddPplTab.Click();

        }

        
        public void ENterFromDate()
        {
            this.BookingSummaryMap.FromDate.Click();
            this.BookingSummaryMap.FromDate.Clear();
            Thread.Sleep(3000);
            this.BookingSummaryMap.FromDate.SendKeys(FromDate);
            Thread.Sleep(3000);
        }

        public void EnterToDate()
        {
            this.BookingSummaryMap.ToDate.Click();
            Thread.Sleep(4000);
            this.BookingSummaryMap.ToDate.Clear();
            Thread.Sleep(6000);
            this.BookingSummaryMap.ToDate.SendKeys(ToDate);
            Thread.Sleep(3000);
        }
        public void enterresourceType()
        {
            var dropedown1 = this.BookingSummaryMap.ResourceType;
            
            var SelectElement = new SelectElement(dropedown1);
            Thread.Sleep(2000);
            SelectElement.SelectByIndex(1);
            Thread.Sleep(3000);
        }


        public void ENterSetUPtime()
        { 
          var dropedown2 = this.BookingSummaryMap.SetUpTime;
          var SelectElement = new SelectElement(dropedown2);
          Thread.Sleep(2000);
          SelectElement.SelectByIndex(2);
          Thread.Sleep(3000);
        }

        public void ENterBreakdowntime()
        {
            var dropedown3 = this.BookingSummaryMap.BreakdownTime;
            var SelectElement = new SelectElement(dropedown3);
            Thread.Sleep(2000);
            SelectElement.SelectByIndex(2);
            Thread.Sleep(3000);
        }
        public void VerifySetUpBreakdownTime_ForMovedBooking()
        { 
            var dropedown4 = this.BookingSummaryMap.SetUpTime;
            var SelectElement = new SelectElement(dropedown4);
            string ssg = SelectElement.SelectedOption.Text;
            //return.BookingSummaryMap.SetUpTime.Click();
            Assert.IsTrue(ssg.Equals("30"), "Your Test Failed due to mismatch in assertion Value");
            Console.WriteLine("Test Passed with the same set up and breakdown time " +ssg);
         
        }





        public void clickOnAddAddon()
        {
            this.BookingSummaryMap.AddonButton.Click();
            Thread.Sleep(4000);
            this.BookingSummaryMap.SelectingAddonfromCheckbox.Click();
            Thread.Sleep(4000);
            this.BookingSummaryMap.AddSelectedAddons.Click();
            Thread.Sleep(4000);
            this.BookingSummaryMap.Summaryclick.Click();
            Thread.Sleep(4000);
        }

        public void FFT200_clickonAddAdon_Button_Verify_AddedAddon()
        {
            this.BookingSummaryMap.AddonButton.Click();
            Thread.Sleep(4000);
            String AddonName = this.BookingSummaryMap.VerifyAddedAddonName.Text;
            Console.WriteLine(AddonName);

        }

       
        public void AddInternalVisitors()
        {
            this.BookingSummaryMap.EnterInternalVisitorName.SendKeys(InternalVisitorName);
            Thread.Sleep(3000);
            this.BookingSummaryMap.InternalVisitorsearchByNameclick.Click();
            Thread.Sleep(2000);
            this.BookingSummaryMap.AddEnterInternalVisitorcclick.Click();
            Thread.Sleep(5000);
            //this.BookingSummaryMap.GoToSummaryPageFromAddon.Click();
        }


        public void GotoSummaryPagefromVisitors()
        {
            this.BookingSummaryMap.GoToSummaryPageFromAddon.Click();
        }
        public void PopUPHandling()
        {
            Thread.Sleep(5000);
            try
            { 
               if (this.BookingSummaryMap.PopUPHandlingForVisitors.Displayed)
              {
                Thread.Sleep(6000);
                  this.BookingSummaryMap.PopUPHandlingForVisitors.Click();
             }
            }
            catch (NoSuchElementException) { }


        }

        public void ExternalVisitors()
        {
         Thread.Sleep(2000);
         this.BookingSummaryMap.ExternalVisitorRadioButton.Click();
         Thread.Sleep(2000);
        this.BookingSummaryMap.EnterLastName.SendKeys("Jay");
        Thread.Sleep(2000);
        this.BookingSummaryMap.EnterFirstName.SendKeys("s");
        Thread.Sleep(2000);
        var dropedown = this.BookingSummaryMap.TitleDropedown;
        var SelectElement = new SelectElement(dropedown);
        SelectElement.SelectByIndex(2);
        this.BookingSummaryMap.CompanyName.SendKeys("NFS");
        Thread.Sleep(2000);
        this.BookingSummaryMap.Email.SendKeys("Jaya1@gmail.com");
        Thread.Sleep(2000);
        this.BookingSummaryMap.Telephone.SendKeys("123456789");
        Thread.Sleep(4000);
        this.BookingSummaryMap.ClickonSaveExternalVisitors.Click();
        Thread.Sleep(8000);
}

        public void FFT49_ENterUDFValues()
        {
            Thread.Sleep(2000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_BookingUDF_Panel1']/fieldset/table/tbody/tr/td[1]"));
            Thread.Sleep(2000);
            this.BookingSummaryMap.AminitiesavailibleYes.Click();
            Thread.Sleep(2000);
            this.BookingSummaryMap.DeskLampAndRefirgerator.SendKeys("Amenities are availible");
        }
        //UDF
        public void FFT_50_ClearChildUDFSelection()
        {
            Thread.Sleep(2000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_BookingUDF_Panel1']/fieldset/table/tbody/tr/td[1]"));
            Thread.Sleep(2000);
            this.BookingSummaryMap.DeskLampAndRefirgerator.Clear();
        }
        //UDF
        public void FFT_98_VerfiyforDiactivatedChild_UDF()
        {
            Thread.Sleep(2000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_BookingUDF_Panel1']/fieldset/table/tbody/tr/td[1]"));
            Thread.Sleep(2000);
            //Assert.IsTrue(this.BookingSummaryMap.DeskLampAndRefirgerator.D
        }

        public void FFT_50_ClearParentUDFSelection()
        {
            Thread.Sleep(2000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_BookingUDF_Panel1']/fieldset/table/tbody/tr/td[1]"));
            Thread.Sleep(2000);
            this.BookingSummaryMap.AminitiesavailibleYes.Click();
        }
        public void FFT_50InvalidUDFContent()
        {
            Assert.IsTrue(this.BookingSummaryMap.InvalidUDFContentPopUp.Enabled);
        }
        public void FFT49and86_PopUPCLearValueFromDependentField()
        {
            Thread.Sleep(2000);
            this.BookingSummaryMap.PopUP_ClearValueFormDepentField.Click();
        }
        public void FFT233_Is_AddonOutOfStock_PopUPEnabled()
        {
            Assert.IsTrue(this.BookingSummaryMap.AddonsOutofStockPopup.Enabled);
        }

        public void ClickOnRecurBookingButton()
        {
            Actions action = new Actions(browser);
            IWebElement recur =this.BookingSummaryMap.ClickOnRecurBookingButton;
            action.MoveToElement(recur).Click().Build().Perform();
        }

        public void SelectDailyRecurBooking_FromBookingSummaryPage()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(2);
            string todaydate = today.ToString("dd/MM/yyyy");
            string tomorrowTo = tomorrow.ToString("dd/MM/yyyy");
            Thread.Sleep(3000);

            IWebElement frame1 = this.BookingSummaryMap.RecurBookingFrame_BookingSummaryPage;
            browser.SwitchTo().Frame(frame1);
            Thread.Sleep(2000);
            this.BookingSummaryMap.SelectDailyRecurBooking_BookingSummaryPage.Click();
            Thread.Sleep(2000);
            IWebElement fromdate = this.BookingSummaryMap.FromDateForRecurBooking;
            Actions action = new Actions(browser);
            action.MoveToElement(fromdate).Click().SendKeys(todaydate).Build().Perform();

            IWebElement Todate = this.BookingSummaryMap.ToDateForRecurBooking;
            Actions action1 = new Actions(browser);
            action1.MoveToElement(Todate).Click().SendKeys(tomorrowTo).Build().Perform();
            
            this.BookingSummaryMap.ShowTargetDate.Click();
            Thread.Sleep(3000);
            this.BookingSummaryMap.ContinueWithBooking.Click();
            Thread.Sleep(2000);
            
    }
        public void EnterTitleForFFT_256()
        {
            this.BookingSummaryMap.BookingTitle.SendKeys("FFT266RecurringBooking105");
        }
        public void EnterTtileFor_FFT_273_1()
        {
            this.BookingSummaryMap.BookingTitle.SendKeys("FFT_273_1");

          }
        public void EnterTtileFor_FFT_274()
        {
            this.BookingSummaryMap.BookingTitle.SendKeys("FFT_274");
        }
        public void EnterTtileFor_FFT_275()
        {
            this.BookingSummaryMap.BookingTitle.SendKeys("FFT_275");
        }
        public void EnterTtileFor_FFT_276()
        {
            this.BookingSummaryMap.BookingTitle.SendKeys("FFT_276");
        }

        public void FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage()
        {
            this.BookingSummaryMap.ClickOnDateAndTimeOptionOnBookingSummaryPage.Click();
        }
        public void SelectTimecalender_Time2PM()
        {
            Thread.Sleep(2000);
            IWebElement frame = this.BookingSummaryMap.SwitchToFrame;
            browser.SwitchTo().Frame(frame);
            Actions action = new Actions(browser);
            IWebElement timepopup = this.BookingSummaryMap.ClickOnTimeViewPopUP;
            action.MoveToElement(timepopup).Click().Build().Perform();
            Thread.Sleep(2000);
            this.BookingSummaryMap.ClickOnTimeViewPopUP_Select2PM.Click();
            Thread.Sleep(2000);
            this.BookingSummaryMap.ClickOnConfirmMoveBooking.Click();
            Thread.Sleep(5000);
        }
        public void SelectToDateTime2_30()
        {
            Thread.Sleep(2000);
            IWebElement frame = this.BookingSummaryMap.SwitchToFrame;
            browser.SwitchTo().Frame(frame);
            Actions action = new Actions(browser);
            IWebElement timepopup = this.BookingSummaryMap.ClickOnToDate_TimeViewPopUp;
            action.MoveToElement(timepopup).Click().Build().Perform();
            Thread.Sleep(3000);
            this.BookingSummaryMap.Select_TOtime2_30pm.Click();
            Thread.Sleep(3000);
            this.BookingSummaryMap.ClickOnConfirmMoveBooking.Click();
            Thread.Sleep(5000);
        }
        public void ClickOnTimeViewPopUP_Select3PM()
        {
            Thread.Sleep(2000);
            IWebElement frame = this.BookingSummaryMap.SwitchToFrame;
            browser.SwitchTo().Frame(frame);
            Actions action = new Actions(browser);
            IWebElement timepopup = this.BookingSummaryMap.ClickOnTimeViewPopUP;
            action.MoveToElement(timepopup).Click().Build().Perform();
            Thread.Sleep(2000);
            this.BookingSummaryMap.ClickOnTimeViewPopUP_Select3PM.Click();
            Thread.Sleep(2000);
            this.BookingSummaryMap.ClickOnConfirmMoveBooking.Click();
            
            

        }
        public void NavigateTosrviceTrackerPage()
        {
            clickonGoToDIary();
            var ssg=this.BookingSummaryMap.NavigateToServiceTrackerPage;
            WebDriverWait wait = new WebDriverWait(browser,TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(ssg));
            Actions act = new Actions(browser);
            act.MoveToElement(ssg).Click().Build().Perform();
            this.BookingSummaryMap.NavigateToServiceTrackerPage.Click();
        }
        public void selectNextDateOnServiceTracker()
        {

            this.BookingSummaryMap.SelectNextDateOnserviceTracker.Click();
            Thread.Sleep(3000);
            this.BookingSummaryMap.SelectNextDateOnserviceTracker.Click();
            Thread.Sleep(3000);
            this.BookingSummaryMap.checkCancelledBookingCheckboxonServiceTracker.Click();
        }
        public void ChangeBookingStatustoCancelled()
        {
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[3]"));
            var statusDropedown = this.BookingSummaryMap.BookingStausDropdown;
            SelectElement select = new SelectElement(statusDropedown);
            select.SelectByIndex(0);
           
        }

            public OpenQA.Selenium.IWebDriver browser { get; set; }




        public IWebDriver Driver { get; set; }
    }
        
}


