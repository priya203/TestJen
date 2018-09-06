using OpenQA.Selenium;
using UnitTestProjectsummary.WebAppDiary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

using System.Globalization;
using UnitTestProjectsummary.MY_Option;
//using System.Runtime.InteropServices;
namespace UnitTestProjectsummary.PageElements{
public class DiaryMainPage
    {
    private readonly string Receiver = ConfigurationSettings.AppSettings["Receiver_ForQuickCOnfirmationReport"];
    private readonly string timezone1 = ConfigurationSettings.AppSettings["TimeZoneForPrimaryProperty"];
    private readonly string DisplayName = ConfigurationSettings.AppSettings["UpdatedDisplayNameForUser"];
        public DiaryMainPage(IWebDriver browser)
          {
            this.browser = browser;
         }
        public DiaryMainPage()
         { }

        protected DiaryPageElements Map1
            {
            get
            {
                
                return new DiaryPageElements(this.browser);
            }
            }
       
         public DiaryPageValidators Validate1()
          {
            
            return new DiaryPageValidators(this.browser);
         }


       public void selectDiaryCellandContinuwithBooking()
       {
           Actions builder = new Actions(this.browser);
           builder.DoubleClick(this.Map1.SelectDiaryCell).Build().Perform();
           Thread.Sleep(2000);
           this.Map1.ClickOnContinueWIthBooking.Click();}

       public void selectDiaryCellOnly()
       {
           Actions builder = new Actions(this.browser);
           builder.DoubleClick(this.Map1.SelectDiaryCell).Build().Perform();
           Thread.Sleep(2000);
       }
       public void GetLoggedinUsername()
       { 
      //  var name=this.Map.VerifyLoggedInUser.text
       }
       public void cancelBooking_ResourceCancellation()
       {
          Actions builder1 = new Actions(this.browser);
          builder1.MoveToElement(this.Map1.SelectDiaryCell);
          Thread.Sleep(4000);
          builder1.ContextClick(this.Map1.SelectDiaryCell).Build().Perform();
          Thread.Sleep(1000);
          builder1.MoveToElement(this.Map1.SelectCancelBooking).Perform();
          Thread.Sleep(1000);
          this.Map1.selectCancelBooking_Thisresource.Click();
          Thread.Sleep(3000);
          this.Map1.Select_OKCancelpopup.Click();
          Thread.Sleep(6000);
       
          WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(20));
          browser.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[3]"));
          Thread.Sleep(2000);
          IWebElement msg00 = browser.FindElement(By.CssSelector("body > div:nth-of-type(3) > div.ui-dialog-content.ui-widget-content"));
          String textcheck = msg00.Text;
          Thread.Sleep(2000);
          Console.Write(textcheck);
          Thread.Sleep(2000);
          this.Map1.SelectOkButton.Click();
          Thread.Sleep(3000);}

       public void Copybookingfromdiary_toNextDate()
       {

           Actions builder1 = new Actions(this.browser);
           builder1.MoveToElement(this.Map1.SelectDiarCellSN_04);
           Thread.Sleep(2000);
           builder1.ContextClick(this.Map1.SelectDiarCellSN_04).Build().Perform();
           Thread.Sleep(3000);
           this.Map1.CopyBookingClickFromDiary.Click();
           Thread.Sleep(2000);

           browser.SwitchTo().Frame(browser.FindElement(By.XPath("//*[@id='frmPnlCopy']")));
           Thread.Sleep(2000);
           this.Map1.EnterFromTime_ForMoveBooking.Clear();
           Thread.Sleep(3000);
           var today = DateTime.Today;
           var tomorrow = today.AddDays(1);
           this.Map1.EnterFromTime_ForMoveBooking.SendKeys(tomorrow + "05:00 AM");
           Thread.Sleep(3000);
           this.Map1.ClickOnTimeViewPopUP.Click();
           Thread.Sleep(2000);
           this.Map1.ClickSelectTime5Am.Click();
         //  this.Map1.EnterToDateTime_ForMoveBooking.Clear();
           //this.Map1.EnterToDateTime_ForMoveBooking.SendKeys(tomorrow + "06:00 AM");
           Thread.Sleep(4000);
           browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='rcRepeat_pnlButtons']/table/tbody"));
           Thread.Sleep(2000);
           this.Map1.ClickOnCopyConfirmationmessage.Click();
           Thread.Sleep(4000);
          // diary.ClickOn_confirmMoveBooking();

       }

       public void ClickonGotoBackDate()
       {
           WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
           wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='lbtnLeft']")));
           this.Map1.ClickLeftButtonForbackDate.Click();
       }
       public void SN_12SelectDIaryCell_View()
       { 
         Actions builder2 = new Actions(this.browser);
           builder2.DoubleClick(this.Map1.SelectDiarCellSN_04).Build().Perform();
           Thread.Sleep(3000);
       }
       public void SN_03_SelectDiaryCell()
       {
           Actions builder = new Actions(this.browser);
           builder.DoubleClick(this.Map1.SelectDiarCellSN_03).Build().Perform();
           Thread.Sleep(2000);
           this.Map1.ClickOnContinueWIthBooking.Click();

       }

       public void SN_04_SelectDiaryCell()
       {
           Actions builder = new Actions(this.browser);
           builder.DoubleClick(this.Map1.SelectDiarCellSN_04).Build().Perform();
           Thread.Sleep(2000);
           this.Map1.ClickOnContinueWIthBooking.Click();

       }
        public void FFT47_selectDiaryCellForRecurBooking()
        {
            Actions builder = new Actions(this.browser);
            builder.DoubleClick(this.Map1.FFT47_SelectDiaryCellRecurBooking).Build().Perform();
            Thread.Sleep(2000);
        }
        public void SelectRecurBooking_Checkbox()
        {
            this.Map1.SelectRecurBooking.Click();
            
        }
        public void SelectDailyRecurringBooking()
        {
            
            this.Map1.SelectDailyRecurBooking.Click();
        }

   

        public void EnterFromToDateForDailyRecurring()
        {
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            Thread.Sleep(3000);
            this.Map1.ToDateForDailyRecur.Click();
            Thread.Sleep(2000);
            //this.Map1.FromDateForDailyRecur.Click();
            //this.Map1.FromDateForDailyRecur.Clear();
            this.Map1.FromDateForDailyRecur.SendKeys("22/02/2018");
            //Thread.Sleep(2000);
            //this.Map1.ToDateForDailyRecur.Click();
            
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            this.Map1.ToDateForDailyRecur.SendKeys("25/02/2018"); }

        public void SelectDailyRecurBookingDates()
        {
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            Thread.Sleep(3000);
            this.Map1.ToDateForDailyRecur.Click();
            Thread.Sleep(2000);

            var today = DateTime.Today;
            var tomorrow = today.AddDays(2);
            string todayFrom = today.ToString("dd/MM/yyyy");
            string tomorrowTo = tomorrow.ToString("dd/MM/yyyy");
            
            this.Map1.FromDateForDailyRecur.SendKeys(todayFrom);
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            this.Map1.ToDateForDailyRecur.SendKeys(tomorrowTo);
            }



        public void ShowTargetDate_ContinueBooking_recur()
        {
            this.Map1.ShowTargetDate_RecurBooking.Click();
            Thread.Sleep(2000);
            this.Map1.ContinueBooking_RecurBooking.Click();
        }

   //****FFTTest202**********
        public void FFTTest202_SelectAndContinueWithBooking()
        {
            Actions builder = new Actions(this.browser);
            builder.DoubleClick(this.Map1.FFT202Source_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
        public void FFTTest202_DragandDrop()
        {
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT202Source_SelectDiaryCell, this.Map1.FFT202Target_SelectDiaryCell);
            Thread.Sleep(2000);
            Drag.Build().Perform();
        }
        public void ClickOn_confirmMoveBooking()
        {
            Thread.Sleep(6000);
            this.Map1.FFT202ClickOn_ConfirmMoveBooking.Click();
            Thread.Sleep(3000);
        }
        public void FFTTest202_ClickOnMovedBooking_Time()
        {
            //Thread.Sleep(2000);
            Actions MovedBooking = new Actions(this.browser);
            MovedBooking.DoubleClick(this.Map1.FFT202Target_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
        }

   //*******FFTTest200******
        public void FFTTest200_SelectAndContinueWithBooking()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT200Source_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
         public void FFTTest200_DragandDrop_Chnageroom()
        {
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT200Source_SelectDiaryCell, this.Map1.FFT200Targert_SelectDiaryCell);
            Thread.Sleep(2000);
            Drag.Build().Perform();
        }
        public void ClickConfirmChangeRoom()
        {
            this.Map1.FFT200TConfirm_ChangeRoom.Click();
            Thread.Sleep(5000);
            this.Map1.FFT200TConfirm_ChangeRoomSavedSuccessfully.Click();
            Thread.Sleep(5000);
        }
        public void ClickOnMovedBooking_Room()
        {
            Thread.Sleep(2000);
            Actions MovedBooking = new Actions(this.browser);
            MovedBooking.DoubleClick(this.Map1.FFT200Targert_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
        }
//******FFT46*******
        public void FFTTest46_SelectAndContinueWithBookingFirst()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT46_Source_SelectDiaryCell).Build().Perform();
            Thread.Sleep(1000);
        }
        public void FFTTest46_EnterFromandToDateSlot_10111()
        {
            this.Map1.EnterFrom_TimeForBookingCreation.Clear();
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("10:00 AM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("11:00 AM");
        }
        public void FFTTest46_clickOncontinuewithbookingTime_1011()
        {
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
        public void FFTTest46_SelectAndContinueWithBookingTarget()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT46_Target_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("12:00 PM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("01:00 PM");
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
        public void FFTTest46_DragandDrop()
        {
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT46_Source_SelectDiaryCell, this.Map1.FFT46_Target_SelectDiaryCell);
            Thread.Sleep(2000);
            Drag.Build().Perform();
            Thread.Sleep(6000);
        }
//*********203*************
        public void FFTTest203_SelectAndContinueWithBookingFirst12to1PM()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT203_SelectFirstDiaryCellForBooking_12to1PM).Build().Perform();
            Thread.Sleep(2000);
        }
        public void EnterFromandToDateSlot_12to1PM()
        {
            this.Map1.EnterFrom_TimeForBookingCreation.Clear();
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("12:00 PM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("01:00 PM");
        }
        public void FFTTest203_SelectAndContinueWithBookingFirst2PMto3PM()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT203_SelectSdecondtDiaryCellForBooking_2PMto3PM).Build().Perform();
            Thread.Sleep(2000);
        }
        public void EnterFromandToDateSlot_2PMto3PM()
        {
            this.Map1.EnterFrom_TimeForBookingCreation.Clear();
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("02:00 PM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("03:00 PM");
        }
        public void FFTTest203_DragandDropto_NewTime()
        { 
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT203_SelectFirstDiaryCellForBooking_12to1PM, this.Map1.FFT203_SelectSdecondtDiaryCellForBooking_2PMto3PM);
            Thread.Sleep(3000);
            Drag.Build().Perform();
       }
        public void FFTTest203_ChangeDateTime_ForMoveBooking()
        { 
          //this.Map1.EnterFromTime_ForMoveBooking.Clear();
          //this.Map1.EnterFromTime_ForMoveBooking.SendKeys("14/02/2018 12:30 PM");
          //Thread.Sleep(2000);
          //this.Map1.EnterToDateTime_ForMoveBooking.Clear();
          //this.Map1.EnterToDateTime_ForMoveBooking.SendKeys("14/02/2018 1:30 PM");

          var today = DateTime.Today;
          string todayFrom = today.ToString("dd/MM/yyyy");

          this.Map1.EnterFromTime_ForMoveBooking.Clear();
          this.Map1.EnterFromTime_ForMoveBooking.SendKeys(todayFrom + " 12:30 PM");
          Thread.Sleep(3000);
          this.Map1.EnterToDateTime_ForMoveBooking.Clear();
          this.Map1.EnterToDateTime_ForMoveBooking.SendKeys(todayFrom + " 01:30 PM");
          Thread.Sleep(3000);
        }

        
//***47*******
        //for updaing recurring booking
        public void FFT47_SwitchtorecurringBookingPanel()
        {
         browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='recurrenceDiv']/table[1]/tbody[1]/tr[1]/td[1]"));
         }
        public void FFT47_SelectEntireSeries()
        {
            this.Map1.FFT_47_SelectEntireSeries.Click();
            this.Map1.FFT_47_ClickOnOK_SelectENtireSeries.Click();
            Thread.Sleep(3000);
        }
        public void FFT47_SwitchtoDateTableOnDiary()
        {
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='topbutntable']/tbody/tr/td[1]/table/tbody/tr/td[3]/table"));
        }
        public void FFT_47_SelectNextDate()
        { 
            this.Map1.FFT_47_ClickOnNextDate.Click();
        }
        //provide title for creating recurring Booking
        public void EnterTitleForRecurringBooking()
        {
            this.Map1.BookingTitle.SendKeys("RecurringBooking");
        }
        public void FFT_47_RecurBookingupdatedTitle()
        {
            this.Map1.BookingTitle.Clear();
            this.Map1.BookingTitle.SendKeys("Recurringupdatedtitle");
        }
        public void FFT_47_ValidateUpdatedBookingTitle()
        {
            IWebElement updatedTitle1 = this.Map1.BookingTitle;
            Thread.Sleep(2000);
            string value = updatedTitle1.GetAttribute("value");
           // Console.WriteLine(value);
            Assert.IsTrue(value.Equals("Recurringupdatedtitle"), "Your Test Failed due to mismatch In the title");
        }

//*******49**********
        public void FFTTest49_SelectAndContinueWithBooking_UDF()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT49_SelectDiarycellForUDF).Build().Perform();
           
        }

//*****QuickCOnfirmationReport******88

        public void VerifyQuickConfirmationReportWindow()
        {   
            this.Map1.QuickConfirmationReport.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().Window(browser.WindowHandles.Last());
            Assert.IsTrue(this.browser.Title.Equals("Quick Report"), "Quick Report");
            Thread.Sleep(2000);
            Assert.IsTrue(this.Map1.ReceiverForConfirmationReport.Enabled, "Asset fails are sender is not avalible");
            IWebElement frameElemet = browser.FindElement(By.XPath("//*[@id='reEmailBody_contentIframe']"));
            Assert.IsTrue(frameElemet.Enabled, "Assert false as body of the report is not present");
        }


public void SendQuickConfirmationReport()
        {
            //this.Map1.QuickConfirmationReport.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().Window(browser.WindowHandles.Last());
            Assert.IsTrue(this.browser.Title.Equals("Quick Report"), "Quick Report");
            Thread.Sleep(2000);
            String handle = browser.WindowHandles.Last();
            Console.WriteLine(handle);
            this.Map1.ReceiverForConfirmationReport.Clear();
            this.Map1.ReceiverForConfirmationReport.SendKeys(Receiver);

            this.Map1.SubjectNameforConfirmationReport.Clear();
            this.Map1.SubjectNameforConfirmationReport.SendKeys("QuickCOnfirmationReport");

            IWebElement frameElemet = browser.FindElement(By.XPath("//*[@id='reEmailBody_contentIframe']"));
            browser.SwitchTo().Frame(frameElemet);

            this.Map1.BodyContentforConfirmationReport.Clear();
            this.Map1.BodyContentforConfirmationReport.SendKeys("This is Quick Confirmation report");
            Thread.Sleep(2000);
            browser.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            this.Map1.SendQuickConfirmationReport.Click();
            Thread.Sleep(6000);

            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]")));
           browser.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[1]"));
            Thread.Sleep(4000);
            this.Map1.AcceptSendQBReportPopUP.Click();
            Thread.Sleep(3000);}

//*******ALL User Diary******
public void verifyTimezoneForPromaryProperty()
{
    Thread.Sleep(3000);
    IWebElement primProperty = browser.FindElement(By.XPath("//*[@id='lblPropertyOrTimeZone0']"));
    String NameP = primProperty.Text;
    IWebElement timezone = browser.FindElement(By.XPath("//*[@id='ShTBLNo0']/tbody/tr[2]/td[1]"));
    WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ShTBLNo0']/tbody/tr[2]/td[1]")));
    String ssg = timezone.Text;
    Console.WriteLine("Primary Proerty Name  " + NameP+ " TImeZone :" +ssg);
    Assert.IsTrue(ssg.Equals(timezone1), "TestFailsasTimeFormat of primary property Doesnt match with the UserInput");
}
public void verifyLoggedInUsername()
{
    WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_lblLogin']")));
    IWebElement LoogedInUsername=browser.FindElement(By.XPath("//*[@id='ctl00_lblLogin']"));
    String Name = LoogedInUsername.Text;
    Console.WriteLine(Name);
}
public void modifyDisplayName()
{
    MyOptionMainPage opt = new MyOptionMainPage(this.browser);
    opt.modifyDisplayName();
    BookingSummaryMainPage book = new BookingSummaryMainPage(this.browser);
    book.clickonGoToDIary();
    WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_lblLogin']")));
    IWebElement LoogedInUsername = browser.FindElement(By.XPath("//*[@id='ctl00_lblLogin']"));
    String Name = LoogedInUsername.Text;
    Assert.IsTrue(DisplayName.Equals(Name),"TestFailedasModifiedNameDoesntMatch");
}

public void DateCheck()
{
    WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_calDateChange1_dateInput']")));
    this.Map1.CLickonTodaysDate.Click();

    IWebElement todaysd = this.Map1.CLickonDateTextBox;
    String date9 = todaysd.GetAttribute("Value");
    Console.WriteLine(date9);

    IWebElement DateDay = this.Map1.CLickOnDateTodaysDayTextBox;
    String date10 = DateDay.Text;
    Console.WriteLine(date10);

    
    string date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
    Console.WriteLine(date);
    string date1 = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
    Assert.IsTrue(date9.Equals(date1),"Mismach in date");
    Assert.IsTrue(date10.Equals(date),"Mismatch in date and day");
 }
public void futureDateCheck()
{
    Thread.Sleep(2000);
    this.Map1.FFT_47_ClickOnNextDate.Click();
    Thread.Sleep(4000);
    WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_calDateChange1_dateInput']")));
    IWebElement todaysd = this.Map1.CLickonDateTextBox;
    
    IWebElement DateDay = this.Map1.CLickOnDateTodaysDayTextBox;
    String date10 = DateDay.Text;
    Console.WriteLine(date10);

    String dateDayFuture = DateTime.Today.AddDays(1).ToString("dddd, dd MMMM yyyy");
    Console.WriteLine(dateDayFuture);
    Assert.IsTrue(date10.Equals(dateDayFuture), "Mismatch in date and day");
}





        

  

           public IWebDriver webDriver { get; set; }
        
       
        public OpenQA.Selenium.IWebDriver browser { get; set; }


        public OpenQA.Selenium.IWebDriver driver { get; set; }



        public string ggh { get; set; }
    }
}






