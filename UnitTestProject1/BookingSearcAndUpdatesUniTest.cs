using System;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.PageElements;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;
using System.Threading;
using RelevantCodes.ExtentReports;
using UnitTestProjectsummary.WebAppDiary;

namespace UnitTestProjectsummary
{

    [TestFixture]
    public class BookingSearcAndUpdatesUniTest
    {
        
        public IWebDriver Driver;
        public WebDriverWait Wait;
        private string tt;
        //public static ExtentReports extent;
        //public static ExtentTest test;

        
   
       [SetUp]
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

           // this.Driver = new ChromeDriver();
           // this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
           // Thread.Sleep(2000);
           // Driver.Manage().Window.Maximize();
           // Thread.Sleep(3000);
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

   
        [Test,Order(1)]
        public void BookingSearchPageNavigation()
        {
            //test = extent.StartTest("BookingSearchPageNavigation");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
           // TakeScreenshot();
            //Thread.Sleep(5000);
            Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "DisplayNFSLogo on Login Page");
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
                

        }
         [Test,Order(2)]
        public void BookingSearch()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            //test = extent.StartTest("BookingSearch");
           
           Thread.Sleep(4000);
            LoginMainPage logint = new LoginMainPage(this.Driver);
           // logint.Navigate();
            //logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(6000);
            booksearch.EnterSearcCriteria();
            booksearch.selectBookingTypedrop();
            booksearch.selectpropertyDroperdown();
            booksearch.SelectStatusDroperdown();
            //TakeScreenshot();
            Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "DisplayNFSLogo on Login Page");
                
           // booksearch.CLickOnBookingSearchandSelectTheRecord();
         }

        //[TestMethod]
        public void UpdateBooking_withResource_addon()
        {
            BookingSearch();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.ClickOnBookAnatherResourceForUpdateBooking();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickOnAddAddon();
            Thread.Sleep(3000);
            booksearch.ClickonSaveEditedrecord();
        }
        //[TestMethod]
        public void UpdateBooking_HostAndRequester()
        {
            BookingSearch();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
          //  booksearch.ClickOnBookAnatherResourceForUpdateBooking();
            //CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            //Thread.Sleep(3000);
            //CreateBooking.searchButtonclick();
            //Thread.Sleep(5000);
            //CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            //CreateBooking.selectingtheresource();
           //Thread.Sleep(8000);
            //CreateBooking.GotoSummaryPage();
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            booksearch.UpdateHost();
            booksearch.UpdateRequester();
            booksearch.ClickonSaveEditedrecord();
}
       // [TestMethod]
        public void UpdateBooking_BookingType_SpecialRequests_Notes_Title()
        {
            BookingSearch();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            //booksearch.ClickOnBookAnatherResourceForUpdateBooking();
            //CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            //Thread.Sleep(3000);
            //CreateBooking.searchButtonclick();
            //Thread.Sleep(5000);
            //CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            //CreateBooking.selectingtheresource();
            //Thread.Sleep(8000);
            //CreateBooking.GotoSummaryPage();
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
           // booksearch.UpdateRequester();
            booksearch.UpdateParticipants_BookingType();
            booksearch.Update_Notes();
            booksearch.UpdateSpecialRequest_bookingStatus();
            booksearch.EnterNewTitle();
            booksearch.ClickonSaveEditedrecord();
        
        }


       // [TestMethod]
        public void UpdateBooking_AllParams()
        {
           BookingSearch();
           BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
           booksearch.ClickOnBookAnatherResourceForUpdateBooking();
           CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
           Thread.Sleep(3000);
           CreateBooking.searchButtonclick();
           Thread.Sleep(5000);
           CreateBooking.CreateBookingValidate().TestResourceCheckbox();
           CreateBooking.selectingtheresource();
           Thread.Sleep(8000);
           CreateBooking.GotoSummaryPage();
           BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           Thread.Sleep(3000);
           bookingsummary.clickOnAddAddon();
           Thread.Sleep(3000);
           booksearch.UpdateHost();
           booksearch.UpdateRequester();
           booksearch.UpdateParticipants_BookingType();
           booksearch.Update_Notes();
           booksearch.UpdateSpecialRequest_bookingStatus();
           booksearch.EnterNewTitle();
           booksearch.ClickonSaveEditedrecord();}

   [Test, Category("Booking Search"), Order(1)]
    public void BookingSearchPageProperties()
        {   
             //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            //bookingsummary.clickonGoToDIary();
            LoginMainPage gg = new LoginMainPage(this.Driver);
            gg.BookingNavigationsAndLogin();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.bookingsearchnavigationscratch();
            Thread.Sleep(2000);
            booksearch.check_bookingsearchpageEnabled();
            Driver.Quit();
         }
   [Test, Category("Booking Search"), Order(2)]
   public void NewBookingPage_FromSearchBooking()
   {  //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
       //bookingsummary.clickonGoToDIary();
       LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.NewBookingPageLink();}

   [Test, Category("Booking Search"), Order(3)]
   public void CreateBooking_FromSearchPage()
   {
       //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
       //bookingsummary.clickonGoToDIary();
       LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.CreateBookingSearchNewBookingPage();
        CreateBookingMainPage booking = new CreateBookingMainPage(this.Driver);
       booking.SelectDate2Days_FromTodaysDateTime10To11AM();

       CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
        Thread.Sleep(3000);
       CreateBooking.searchButtonclick();
       Thread.Sleep(5000);
       CreateBooking.CreateBookingValidate().TestResourceCheckbox();
       CreateBooking.selectingtheresource();
       //Thread.Sleep(8000);
       CreateBooking.GotoSummaryPage();
       BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
       Thread.Sleep(5000);
       bookingsummary.EnterTitle_NewBookingFromSearchPage();
       BookingSearchMainPage search = new BookingSearchMainPage(this.Driver);
       Thread.Sleep(5000);
       bookingsummary.clickonsave();
       Thread.Sleep(2000);
       bookingsummary.GetAllDetails();
       bookingsummary.AcceptSaveBookingPopUP();    
       Thread.Sleep(3000);
       bookingsummary.clickonGoToDIary();
       Thread.Sleep(5000);}

   [Test, Category("Booking Search"), Order(4)]
   public void Search_BookingCreatedFromSearchPage()
   {
        LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.searchBookingwith_TitleandDate();
   }

   [Test, Category("Booking Search"), Order(5)]
   public void Search_WithMultipleInputs()  //Inputes needs to be provided from App.config file.
   {
       LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.EnterSearcCriteria();
       booksearch.selectBookingTypedrop();
       booksearch.selectpropertyDroperdown();
       booksearch.SelectStatusDroperdown();
       booksearch.bookingsearch_MultipleInput();}

   [Test, Category("Booking Search"), Order(6)]
   public void Verify_BookingHyperlinkOpenscorrectBooking()
   { 
       LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.searchBookingwith_TitleandDate();
       booksearch.verifyBookingHyperlink_InBookingTitle();}

   [Test, Category("Booking Search"), Order(7)]//MovingBookingFromSearchShould be executed
   public void MoveBooking_FromSearchPage()
   {
        LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.searchBookingwith_TitleandDate();
       booksearch.MoveBooking();}

   [Test, Category("Booking Search"), Order(8)]//MovingBookingFromSearchShould be executed
   public void VerifyUpdatedTimeofMovedBooking()
   {
       LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.searchBookingwith_TitleandDate();
       Thread.Sleep(2000);
       booksearch.VerifyMovedBookingTime();}

 [Test, Category("Booking Search"), Order(9)]//CopyBookingFromSearchShould be executed
   public void CopyBooking()
   {
       LoginMainPage gg = new LoginMainPage(this.Driver);
       gg.BookingNavigationsAndLogin();
       BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
       booksearch.bookingsearchnavigationscratch();
       booksearch.searchBookingwith_TitleandDate();
       Thread.Sleep(3000);
       booksearch.CopyBooking();}

 [Test, Category("Booking Search"), Order(10)]//CopyBookingFromSearchShould be executed
 public void VerifyforCopyBooking()
 {  LoginMainPage gg = new LoginMainPage(this.Driver);
     gg.BookingNavigationsAndLogin();
     BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
     booksearch.bookingsearchnavigationscratch();
     booksearch.SerachForCopiedBooking();
     Thread.Sleep(3000);}

 [Test, Category("Booking Search"), Order(11)]//CopyBookingFromSearchShould be executed
 public void RecurBooking()
 {
     LoginMainPage gg = new LoginMainPage(this.Driver);
     gg.BookingNavigationsAndLogin();
     BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
     booksearch.bookingsearchnavigationscratch();
     booksearch.searchBookingwith_TitleandDate();
     booksearch.RecurBookings();
     Thread.Sleep(3000);
 }
 [Test, Category("Booking Search"), Order(12)]//CopyBookingFromSearchShould be executed
 public void VerifiyRecurrance()
 {
     LoginMainPage gg = new LoginMainPage(this.Driver);
     gg.BookingNavigationsAndLogin();
     BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
     booksearch.bookingsearchnavigationscratch();
     booksearch.SerachForRecurringBooking();
     Thread.Sleep(3000);
     IWebElement AUth=Driver.FindElement(By.XPath("//*[@id='ctl00_spanAuthorizationrequest']"));
     AUth.Click();
     Thread.Sleep(4000);
     //IWebElement name = Driver.FindElement(By.LinkText("Block32"));
     booksearch.temp1();
     
 }







   //[Test, Category("Booking Search"), Order(6)]
  

//Check Copy move button works or not



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



        [TearDown]
        public void EndReport()
        {
            //extent.Flush();
           // extent.Close();
            Driver.Quit();
        }

public  IWebDriver webDriver { get; set; }}
    //public string filepath { get; set; }
     


        //public IWebDriver webDriver { get; set; }
    }

