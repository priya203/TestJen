using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestProjectsummary.PageElements;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.WebAppCreateBookingPage;
using System.Threading;
using UnitTestProjectsummary.WebAppBookingSummaryPage;
using UnitTestProjectsummary.WebAppDiary;
using UnitTestProjectsummary.Addons_NewBookingPage;
using RelevantCodes.ExtentReports;
using System.Configuration;

namespace UnitTestProjectsummary
{
  [TestFixture]
    public class BookingSummaryUnitTest
    {

        public IWebDriver Driver;
        public WebDriverWait Wait;
        //public static ExtentReports extent;
        //public static ExtentTest test;
        private readonly string ChromeDriverpath = ConfigurationSettings.AppSettings["ChromeDriverPath"];

        [OneTimeSetUp]
        public void SetupTest()
        {
        //    string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        //    string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
        //    string projectPath = new Uri(actualPath).LocalPath;
        //    string reportPath = projectPath + "Report\\MyOwnReports.html";
        //    extent = new ExtentReports(reportPath, true);

        //    extent.AddSystemInfo("Host Name", "Priyanka")
        //   .AddSystemInfo("Environment", "http://localhost/WebAppVV6_3/")
        //   .AddSystemInfo("Username", "Priya");

        //    extent.LoadConfig(projectPath + "extent-config.xml");

            this.Driver = new ChromeDriver(ChromeDriverpath);
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

        [Test,Category("DragAndDrop"),Order(1)]
        public void FFT200()
        {
           // test = extent.StartTest("FFT200 DragAndDrop");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage dd = new DiaryMainPage(this.Driver);
            dd.FFTTest200_SelectAndContinueWithBooking();
           Thread.Sleep(1000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
         //  addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            Thread.Sleep(2000);
            bookingsummary.clickOnAddAddon();
            Thread.Sleep(3000);
            bookingsummary.EnterTitleFFT_200();
            Thread.Sleep(5000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(7000);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(7000);
            dd.FFTTest200_DragandDrop_Chnageroom();
            Thread.Sleep(7000);
            dd.ClickConfirmChangeRoom();
            Thread.Sleep(3000);
            dd.ClickOnMovedBooking_Room();
            Thread.Sleep(3000);
            bookingsummary.FFT200_clickonAddAdon_Button_Verify_AddedAddon();
            Thread.Sleep(3000);
           // TakeScreenshot();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "Booking move is successfull");
            bookingsummary.clickonGoToDIary();
          
        }
        
        public void FFT46()
        {
           
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
          }



         [Test, Category("DragAndDrop"), Order(3)]
        public void FFT202()
        {
          BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
          bookingsummary.clickonGoToDIary();
          //test = extent.StartTest("FFT202 DragAndDrop");
          LoginMainPage logint = new LoginMainPage(this.Driver);
          //logint.Navigate();
          //logint.Login();
           Thread.Sleep(3000);
           DiaryMainPage dd = new DiaryMainPage(this.Driver);
           dd.FFTTest202_SelectAndContinueWithBooking();
           Thread.Sleep(3000);
           bookingsummary.EnterTitleFFT_202();
           Thread.Sleep(2000);
           bookingsummary.ENterSetUPtime();
           Thread.Sleep(2000);
           bookingsummary.ENterBreakdowntime();
           Thread.Sleep(2000);
           bookingsummary.clickonsaveAndExit();
           Thread.Sleep(7000);
           bookingsummary.clickonGoToDIary();
           Thread.Sleep(7000);
           dd.FFTTest202_DragandDrop();
           Thread.Sleep(8000);
           Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
           dd.ClickOn_confirmMoveBooking();
           Thread.Sleep(8000);
           dd.FFTTest202_ClickOnMovedBooking_Time();
           Thread.Sleep(4000);
           bookingsummary.VerifySetUpBreakdownTime_ForMovedBooking();
           //TakeScreenshot();
           //Assert.IsTrue(true);
           //test.Log(LogStatus.Pass, "SetUp Breakdown time has been verified successfully");
           bookingsummary.clickonGoToDIary();
                
          
    }


        [Test]
        public void Create_SimpleBooking_FromNewBookingOption()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(5000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }



        [Test]
        public void Search_availibe_resourcBysearchCriteria()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.ENterFromDate();
            Thread.Sleep(2000);
            bookingsummary.EnterToDate();
            Thread.Sleep(2000);
            bookingsummary.enterresourceType();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(3000);
        
        }



        [Test]
        public void CreateBooking_withAddon()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
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
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }

      //  [TestMethod]
        public void CreateBooking_AddingInternalVisitors_WithoutPopUPHandling()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickonAddPplTab();
            Thread.Sleep(3000);
            bookingsummary.AddInternalVisitors();
            Thread.Sleep(3000);
            bookingsummary.GotoSummaryPagefromVisitors();
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }

        [Test]
        public void CreateBooking_AddingInternalVisitors_WithPopUPHandling()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickonAddPplTab();
            //Thread.Sleep(3000);
            bookingsummary.AddInternalVisitors();
            Thread.Sleep(3000);
            bookingsummary.PopUPHandling();
            Thread.Sleep(3000);
            bookingsummary.GotoSummaryPagefromVisitors();
            Thread.Sleep(3000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }
         [Test]
        public void CreateBooking_withAddon_andVisitors()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
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
            bookingsummary.clickonAddPplTab();
            //Thread.Sleep(3000);
            bookingsummary.AddInternalVisitors();
            Thread.Sleep(3000);
            bookingsummary.PopUPHandling();
            Thread.Sleep(3000);
            bookingsummary.GotoSummaryPagefromVisitors();
            Thread.Sleep(3000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }
       
         public void CreateBooking_withInternaland_ExternalVisitors_NoPopUP()
         {
             LoginMainPage logint = new LoginMainPage(this.Driver);
             logint.Navigate();
             logint.Login();
             CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
             CreateBooking.CreateBookingNavigation();
             Thread.Sleep(3000);
             CreateBooking.searchButtonclick();
             Thread.Sleep(5000);
             CreateBooking.CreateBookingValidate().TestResourceCheckbox();
             CreateBooking.selectingtheresource();
             Thread.Sleep(8000);
             CreateBooking.GotoSummaryPage();
             BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
             Thread.Sleep(3000);
             bookingsummary.clickonAddPplTab();
             Thread.Sleep(3000);
             bookingsummary.AddInternalVisitors();
             //Thread.Sleep(3000);
             //bookingsummary.PopUPHandling();
             Thread.Sleep(3000);
             bookingsummary.ExternalVisitors();
            // Thread.Sleep(4000);
            // bookingsummary.PopUPHandling();
             Thread.Sleep(3000);
             bookingsummary.GotoSummaryPagefromVisitors();
             Thread.Sleep(3000);
             bookingsummary.EnterTitle();
             Thread.Sleep(5000);
             bookingsummary.clickonsave();
             Thread.Sleep(2000);
         
         
         }
        [Test]
         public void CreateBookingFromDiary_Addons_Vissitors()
         {
             LoginMainPage logint = new LoginMainPage(this.Driver);
             logint.Navigate();
             logint.Login();
             DiaryMainPage dd = new DiaryMainPage(this.Driver);
             dd.selectDiaryCellandContinuwithBooking();
             BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
             Thread.Sleep(3000);
             bookingsummary.clickOnAddAddon();
             Thread.Sleep(3000);
             bookingsummary.clickonAddPplTab();
             //Thread.Sleep(3000);
             bookingsummary.AddInternalVisitors();
             Thread.Sleep(3000);
             bookingsummary.PopUPHandling();
             Thread.Sleep(3000);
             bookingsummary.GotoSummaryPagefromVisitors();
             Thread.Sleep(3000);
             bookingsummary.EnterTitle();
             Thread.Sleep(5000);
             bookingsummary.clickonsave();
             Thread.Sleep(2000);
         }

        [Test]
        public void CreateBookingSimpleFromDiary()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            DiaryMainPage dd = new DiaryMainPage(this.Driver);
            dd.selectDiaryCellandContinuwithBooking();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }

          [Test, Category("DragAndDrop"), Order(2)]
        public void FFT203_SetUPBreakdownOverlap_Latest()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(2000);

           // test = extent.StartTest("FFT203_SetUPBreakdownOverlap");
            //createFirstBookingWithsetUPbreakdownTime12To1
          // LoginMainPage gg = new LoginMainPage(this.Driver);
            //gg.Navigate();
           // Thread.Sleep(3000);
            //gg.Login();
            //Thread.Sleep(3000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.FFTTest203_SelectAndContinueWithBookingFirst12to1PM();
            diary.EnterFromandToDateSlot_12to1PM();
            diary.FFTTest46_clickOncontinuewithbookingTime_1011();   //JustClickingOnContinuewithBooking
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
            diary.ClickOn_confirmMoveBooking();
            Thread.Sleep(6000);
           // TakeScreenshot();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "BRE Setting Overlap");
        }





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



        public IWebDriver webDriver { get; set; }
    }
}
