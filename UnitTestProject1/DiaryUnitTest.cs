using System;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary;
using UnitTestProjectsummary.PageElements;
using System.Threading;
//using Seleniumtest.WebAppLogin;
using UnitTestProjectsummary.WebAppDiary;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports;
using RelevantCodes.ExtentReports;
using UnitTestProjectsummary.MY_Option;

namespace UnitTestProjectsummary
{

    [TestFixture]
  
    public class DiaryUnitTest
    {
        public DiaryUnitTest()
        { 
        }

        public IWebDriver Driver;
        public WebDriverWait Wait;
        //public static ExtentReports extent;
        //public static ExtentTest test;



        [OneTimeSetUp]
        public void SetupTest()
        {
           // string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
           // string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
           // string projectPath = new Uri(actualPath).LocalPath;
           // string reportPath = projectPath + "Report\\MyOwnReports.html";
           // extent = new ExtentReports(reportPath, true);

           // extent.AddSystemInfo("Host Name", "Priyanka")
           //.AddSystemInfo("Environment", "http://localhost/WebAppVV6_3/")
           //.AddSystemInfo("Username", "Priya");

           // extent.LoadConfig(projectPath + "extent-config.xml");

            this.Driver = new ChromeDriver("E:\\Sel\\GetDock_driver\\chromedriver");
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        //public void TakeScreenshot()
        //{
        //    Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
        //    string title = "WebApp";
        //    string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
        //    string filepath = "F:/Defects_Screenshots/";
        //    ss.SaveAsFile(filepath + Runname + ".png", ScreenshotImageFormat.Png);
        //    Thread.Sleep(3000);
        //    string path1 = ".Png";
        //    String Join = filepath + Runname + path1;
        //    Console.WriteLine(Join);
        //    test.Log(LogStatus.Pass, "ppp" + test.AddScreenCapture((Join)));
        //}

  [Test, Category("AllUserDiary"), Order(1)]
        public void VerifyTimeZone()
        {
            LoginMainPage gg = new LoginMainPage(this.Driver);
            gg.Navigate();
            Thread.Sleep(3000);
            gg.Login();
            Thread.Sleep(3000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
           diary.verifyTimezoneForPromaryProperty();
           Thread.Sleep(3000);
           BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           bookingsummary.clickonGoToDIary();
  }
      

        [Test, Category("AllUserDiary"), Order(2)]
        public void VerfiyLogedInUsername()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
           // LoginMainPage gg = new LoginMainPage(this.Driver);
            //gg.Navigate();
            //Thread.Sleep(3000);
            //gg.Login();
            Thread.Sleep(3000);
           // DiaryMainPage diary = new DiaryMainPage(this.Driver);
            MyOptionMainPage opt=new MyOptionMainPage(this.Driver);
            opt.getDisplayNameAndVerifyItForLoogedInUser();
            Thread.Sleep(3000);

           bookingsummary.clickonGoToDIary();
        }
        //Modify display name and check if it updating properly on dairy page of user
        [Test, Category("AllUserDiary"), Order(3)]
        public void DisplayNameModificationsOnPage()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            //LoginMainPage gg = new LoginMainPage(this.Driver);
            //gg.Navigate();
            //Thread.Sleep(3000);
            //gg.Login();
            //Thread.Sleep(3000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.modifyDisplayName();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();


        }

        [Test, Category("AllUserDiary"), Order(4)]
        public void CHeckForTitleofDiaryPage()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            //LoginMainPage gg = new LoginMainPage(this.Driver);
            //gg.Navigate();
            //Thread.Sleep(3000);
            //gg.Login();
            //Thread.Sleep(3000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            LoginPageValidators val=new LoginPageValidators(this.Driver);
            val.TitleVerification();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
        }

     [Test, Category("AllUserDiary"), Order(5)]
    public void VerifyBuildVersionandDate()
    {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            //LoginMainPage gg = new LoginMainPage(this.Driver);
            //gg.Navigate();
            //Thread.Sleep(3000);
            //gg.Login();
            Thread.Sleep(3000);
            MyOptionMainPage opt=new MyOptionMainPage(this.Driver);
            opt.VeriyVersionAndBuildDate();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
   }
     [Test, Category("AllUserDiary"), Order(6)]
     public void Legend_NeedtoImplement()
     {

         BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
         bookingsummary.clickonGoToDIary();
         //LoginMainPage gg = new LoginMainPage(this.Driver);
         //gg.Navigate();
         //Thread.Sleep(3000);
         //gg.Login();
         //Thread.Sleep(3000);
         MyOptionMainPage opt = new MyOptionMainPage(this.Driver);
         Thread.Sleep(3000);
         bookingsummary.clickonGoToDIary();
      
    }
     [Test, Category("AllUserDiary"), Order(7)]
     public void VerifyTodaysDateAndDaysDisplayingCorrectly()
     {
         BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
         Thread.Sleep(2000);
         bookingsummary.clickonGoToDIary();
         //LoginMainPage gg = new LoginMainPage(this.Driver);
         //gg.Navigate();
         //Thread.Sleep(3000);
         //gg.Login();
         //Thread.Sleep(3000);
         DiaryMainPage dd = new DiaryMainPage(this.Driver);
         dd.DateCheck();
         bookingsummary.clickonGoToDIary(); }

     [Test, Category("AllUserDiary"), Order(8)]
     public void VerifyFutureDateAndDaysDisplayingCorrectly()
     {

         BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
         bookingsummary.clickonGoToDIary();
         LoginMainPage gg = new LoginMainPage(this.Driver);
        // gg.BookingNavigationsAndLogin();
         //Thread.Sleep(3000);
          DiaryMainPage dd = new DiaryMainPage(this.Driver);
         //Thread.Sleep(3000);
         dd.futureDateCheck();
        // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
         bookingsummary.clickonGoToDIary();}


    [Test, Category("AllUserDiary"), Order(9)]
     public void LoginMainPageLoginFailed()
     {
         BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
         bookingsummary.clickonGoToDIary();
         Thread.Sleep(2000);
         IWebElement logout = Driver.FindElement(By.XPath("//*[@id='ctl00_lblLogout']"));
         logout.Click();
         Thread.Sleep(3000);
         Driver.FindElement(By.XPath("//*[@id='btRelogin']")).Click();

         WebDriverWait waitt = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
         waitt.Until(ExpectedConditions.ElementIsVisible(By.Id("loginMain_UserName")));
         
         LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
         //searchEngineMainPage.Navigate();
         searchEngineMainPage.LoginInvalidCredientials();
         //TakeScreenshot();
         Thread.Sleep(3000);
         searchEngineMainPage.Validate().CheckForLoginFailure();
         Assert.IsTrue(true);
        // test.Log(LogStatus.Pass, "Login failed for Invalid Username and Password");



     }


    [Test,Category("PropertyChnages"),Order(1)]
     public void VerifyUpdatePrimaryProperty()
     {
        BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        // bookingsummary.clickonGoToDIary();
         LoginMainPage gg = new LoginMainPage(this.Driver);
         gg.BookingNavigationsAndLogin();
         MyOptionMainPage opt = new MyOptionMainPage(this.Driver);
         opt.PrimaryPropertyModification();
         gg.Login();
        // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
         bookingsummary.clickonGoToDIary();
         opt.VerifyNamesAreModifeidCorrecltlyOnAllPages();
         bookingsummary.clickonGoToDIary(); }

   [Test, Category("PropertyChnages"), Order(2)]
    public void RevertPrimaryProperty()
    {
        BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        bookingsummary.clickonGoToDIary();
        Thread.Sleep(2000);
        MyOptionMainPage opt = new MyOptionMainPage(this.Driver);
        opt.RevertPrimaryPropertyChanges();
        
    }

          
          [Test]
         public void SelectDiaryCell()
        {
           LoginMainPage gg=new LoginMainPage(this.Driver);
             gg.Navigate();
             Thread.Sleep(3000);
             gg.Login();
             Thread.Sleep(3000);
             DiaryMainPage diary=new DiaryMainPage(this.Driver);
             diary.selectDiaryCellandContinuwithBooking();
             Thread.Sleep(4000);
          }

        [Test,Category("AmendBooking"),Order(1)]
          public void FFT46()
          {
           //   test = extent.StartTest(" Display ALternate resource availible Page");
              LoginMainPage logint = new LoginMainPage(this.Driver);
              logint.Navigate();
              logint.Login();
              DiaryMainPage dd = new DiaryMainPage(this.Driver);
              dd.FFTTest46_SelectAndContinueWithBookingFirst();
              dd.FFTTest46_EnterFromandToDateSlot_10111();
              dd.FFTTest46_clickOncontinuewithbookingTime_1011();

              BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
              Thread.Sleep(3000);
              bookingsummary.EnterTitleFFT_46Case1();
              Thread.Sleep(1000);
              bookingsummary.clickonsaveAndExit();
              Thread.Sleep(9000);
              bookingsummary.clickonGoToDIary();
              Thread.Sleep(7000);
              dd.FFTTest46_SelectAndContinueWithBookingTarget();
              Thread.Sleep(5000);
              bookingsummary.EnterTitleFFT_46Case2();
              Thread.Sleep(1000);
              bookingsummary.clickonsaveAndExit();
              Thread.Sleep(7000);
              bookingsummary.clickonGoToDIary();
              Thread.Sleep(7000);
              dd.FFTTest46_DragandDrop();
              Thread.Sleep(3000);
              Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
              Thread.Sleep(1000);
              dd.ClickOn_confirmMoveBooking();
              Thread.Sleep(8000);
              bookingsummary.BookingSummaryValidate().DisplayAlternteResource();
              Thread.Sleep(5000);
             // TakeScreenshot();
              bookingsummary.clickonGoToDIary();
              //Assert.IsTrue(true);
             //test.Log(LogStatus.Pass, "ALternate resource Page");
          }

          [Test, Category("AmendBooking"), Order(2)]
          public void FFT47_pre_CreateRecurringBooking10AMto11AM()
          {
              BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
              bookingsummary.clickonGoToDIary();
              Thread.Sleep(3000);
              //test = extent.StartTest("CreateRecurringBooking");
              //LoginMainPage gg = new LoginMainPage(this.Driver);
              //gg.Navigate();
              //gg.Login();
              //Thread.Sleep(2000);
              DiaryMainPage diary = new DiaryMainPage(this.Driver);
              diary.FFT47_selectDiaryCellForRecurBooking();
              Thread.Sleep(1000);
              diary.SelectRecurBooking_Checkbox();
              Thread.Sleep(2000);
              diary.FFTTest46_EnterFromandToDateSlot_10111();
              diary.SelectDailyRecurringBooking();
              diary.SelectDailyRecurBookingDates();
              diary.ShowTargetDate_ContinueBooking_recur();
              diary.FFTTest46_clickOncontinuewithbookingTime_1011();
              Thread.Sleep(4000);
              diary.EnterTitleForRecurringBooking();
              Thread.Sleep(2000);
              //TakeScreenshot();
            //  BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
              bookingsummary.clickonsaveAndExit();
              Thread.Sleep(10000);
              bookingsummary.clickonGoToDIary();
             // Assert.IsTrue(true);
             // test.Log(LogStatus.Pass, "CreateRecurringBooking");
          }


      [Test, Category("AmendBooking"), Order(3)]
          public void FFT47_Main() //UpdateRecurringBooking And Verify for updated records
          {
              BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
             bookingsummary.clickonGoToDIary();
              Thread.Sleep(3000);
              //test = extent.StartTest("UpdateRecurringBooking");
             // LoginMainPage gg = new LoginMainPage(this.Driver);
             // gg.Navigate();
             // gg.Login();
              Thread.Sleep(2000);
              DiaryMainPage diary = new DiaryMainPage(this.Driver);
             //bookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
              Thread.Sleep(1000);
              diary.FFT47_selectDiaryCellForRecurBooking();
              Thread.Sleep(1000);
              diary.FFT47_SwitchtorecurringBookingPanel();
              Thread.Sleep(1000);
              diary.FFT47_SelectEntireSeries();
              Thread.Sleep(3000);
              BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
              booksearch.UpdateSpecialRequest_bookingStatus();
              Thread.Sleep(2000);
              diary.FFT_47_RecurBookingupdatedTitle();
              Thread.Sleep(2000);
              bookingsummary.clickonsaveAndExit();
              Thread.Sleep(5000);
              bookingsummary.clickonGoToDIary();
              Thread.Sleep(3000);
              diary.FFT47_SwitchtoDateTableOnDiary();
              diary.FFT_47_SelectNextDate();
              Thread.Sleep(3000);
              diary.FFT47_selectDiaryCellForRecurBooking();
              Thread.Sleep(5000);
              diary.FFT47_SwitchtorecurringBookingPanel();
              Thread.Sleep(5000);
              diary.FFT47_SelectEntireSeries();
              Thread.Sleep(6000);
              //TakeScreenshot();
              diary.FFT_47_ValidateUpdatedBookingTitle();
              Thread.Sleep(2000);
              bookingsummary.clickonGoToDIary();
              //Assert.IsTrue(true);
             // test.Log(LogStatus.Pass, "Recurring Booking has updated successfully");
          }

       
    public void FFT203_SetUPBreakdownOverlap()
    {
        //createFirstBookingWithsetUPbreakdownTime12To1
        LoginMainPage gg = new LoginMainPage(this.Driver);
        gg.Navigate();
        Thread.Sleep(3000);
        gg.Login();
        Thread.Sleep(2000);
        DiaryMainPage diary = new DiaryMainPage(this.Driver);
        diary.FFTTest203_SelectAndContinueWithBookingFirst12to1PM();
        diary.EnterFromandToDateSlot_12to1PM();
        diary.FFTTest46_clickOncontinuewithbookingTime_1011();   //JustClickingOnContinuewithBooking
        BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        Thread.Sleep(3000);
        bookingsummary.ENterSetUPtime();
        bookingsummary.ENterBreakdowntime();
        bookingsummary.EnterTitle();
        bookingsummary.clickonsave();
        Thread.Sleep(2000);
        bookingsummary.clickonGoToDIary();
        Thread.Sleep(3000);

        //CreateBooking with setUp Breakdown Time 2to3
        diary.FFTTest203_SelectAndContinueWithBookingFirst2PMto3PM();
        diary.EnterFromandToDateSlot_2PMto3PM();
        diary.FFTTest46_clickOncontinuewithbookingTime_1011(); 
        Thread.Sleep(3000);
        bookingsummary.ENterSetUPtime();
        bookingsummary.ENterBreakdowntime();
        bookingsummary.EnterTitle();
        bookingsummary.clickonsave();
        Thread.Sleep(2000);
        bookingsummary.clickonGoToDIary();
        Thread.Sleep(3000);
        diary.FFTTest203_DragandDropto_NewTime();
        Thread.Sleep(5000);
        Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
        Thread.Sleep(2000);
        diary.FFTTest203_ChangeDateTime_ForMoveBooking();
        Thread.Sleep(4000);
        diary.ClickOn_confirmMoveBooking();}

    //[TearDown]
    //public void GetResult()
    //{
    //    var status = TestContext.CurrentContext.Result.Outcome.Status;
    //    var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
    //    var errorMessage = TestContext.CurrentContext.Result.Message;

    //    if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
    //    {
    //        test.Log(LogStatus.Fail, stackTrace + errorMessage);
    //    }



    //    extent.EndTest(test);
    //}



    [OneTimeTearDown]
    public void EndReport()
    {
        //extent.Flush();
        //extent.Close();
        Driver.Quit();
    }



           
              

             

           
          
        

        //public IWebDriver webDriver { get; set; }
    }
}
