using System;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.PageElements;
using System.Threading;
using UnitTestProjectsummary.LookUP;
using RelevantCodes.ExtentReports;
using System.Configuration;

namespace UnitTestProjectsummary
{
    [TestFixture]
    public class LookUPTest
    {
        
        public IWebDriver Driver;
        public WebDriverWait Wait;
        //public static ExtentReports extent;
        //public static ExtentTest test;
        private readonly string ChromeDriverpath = ConfigurationSettings.AppSettings["ChromeDriverPath"];


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


        [Test, Category("UDFs-Questionare"),Order(1)]
        public void FFT48_CreateParentQueastionare()
        {
            //test = extent.StartTest("UDFs-Questionare");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(2000);
            lookup.SelectUDFQuentionnaireDropedown();
            lookup.EnterFieldNameForParentQuentionare();
            lookup.SelectDataTypeFromDropedown_Boolean();
            lookup.SelectUDFGroupDropedown();
            //Thread.Sleep(2000);
            //TakeScreenshot();
            lookup.ClickOnSave_AddMoreButton();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Questionare");
         }

         [Test, Category("UDFs-Questionare"), Order(2)]
        public void FFT48_CreateChildQuestionnaire()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(5000);
            //test = extent.StartTest("UDFs-Questionare");

            LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(2000);
            lookup.SelectUDFQuentionnaireDropedown();
            lookup.EnterFieldNameForChildQuentionare();
            lookup.SelectDataTypeFromDropedown_Boolean();
            lookup.SelectUDFGroupDropedown();
            Thread.Sleep(2000);
            lookup.IsDependentYes();
            Thread.Sleep(2000);
            lookup.ParentUDFDropedown_Questioonare();
            //TakeScreenshot();
            lookup.ClickOnSave_AddMoreButton();
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Questionare");
         
        }

         [Test, Category("UDFs-Questionare"), Order(3)]
        public void FFT48_UpdateParentQuestionnaires()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("UDFs-Questionare");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(3000);
            lookup.SelectUDFQuentionnaireDropedown();
            lookup.UDfSearchForEditQuestionare_Parent();
            Thread.Sleep(2000);
            lookup.UDF_ClickOnEditRsecordFirst1();
            Thread.Sleep(2000);
            lookup.ENterUpdatedFieldNameForChildQuestionare();
            //TakeScreenshot();
            lookup.ClickOnSave_AddMoreButton();
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Questionare");
        }

          [Test, Category("UDFs-Questionare"), Order(4)]
         public void FFT48_DeleteChildQuestionnaires()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("UDFs-Questionare");

            LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(2000);
            lookup.SelectUDFQuentionnaireDropedown();
            //this will search record for delete operatoion
            lookup.UDFSearchForDeleteQuestionare();
            Thread.Sleep(2000);
            lookup.UDF_ClickOnDeleteRecord();
            //TakeScreenshot();
            Thread.Sleep(2000);
            lookup.ClickOnSave_AddMoreButton();
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Questionare");
          }


        [Test, Category("UDFs-Booking"), Order(1)]
        public void CreateParentBookingUDF()
          {
              //test = extent.StartTest("UDFs-Booking");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(1000);
            lookup.SelectUDF_BookingDropedown();
            lookup.EnterFieldName_ParentBookingUDF();
            lookup.SelectDataTypeFromDropedown_Boolean();
            lookup.SelectUDFGroupDropedown();
            //.Sleep(2000);
            lookup.ClickOnSave_AddMoreButton();
            //TakeScreenshot();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Booking");
        }

       [Test, Category("UDFs-Booking"), Order(2)]
        public void CreateChildtBookingUDF()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            //test = extent.StartTest("UDFs-Booking");
            Thread.Sleep(3000);
           LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(1000);
            lookup.SelectUDF_BookingDropedown();
            lookup.ENterFieldName_ChildBookingUDF();
            Thread.Sleep(2000);
            lookup.IsDependentYes();
            Thread.Sleep(2000);
            lookup.ParentUDFDropedown_Booking();
            lookup.ClickOnSave_AddMoreButton();
            Thread.Sleep(2000);
            //TakeScreenshot();
           bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Booking");
        }

       [Test, Category("UDFs-Booking-AmendBooking"), Order(1)]
        public void FFT85_MainTest()
        {
           
            //test = extent.StartTest("UDFs-Booking");
            LoginMainPage logint = new LoginMainPage(this.Driver);
           logint.Navigate();
           logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
            Thread.Sleep(2000);
            diary.FFTTest46_EnterFromandToDateSlot_10111();
            diary.FFTTest46_clickOncontinuewithbookingTime_1011();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT49_ENterUDFValues();
            bookingsummary.EnterTitle();
            Thread.Sleep(2000);
            bookingsummary.clickonsave();
            //TakeScreenshot();
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Booking-AmendBooking");
        }

        [Test, Category("UDFs-Booking-AmendBooking"), Order(2)]
        public void FFT50()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("UDFs-Booking-AmendBooking");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
          
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT_50_ClearChildUDFSelection();
            Thread.Sleep(2000);
            bookingsummary.clickonsave();
            Thread.Sleep(3000);
            bookingsummary.FFT_50InvalidUDFContent();
            //TakeScreenshot();
            Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Booking-AmendBooking");
        
        }

        [Test, Category("UDFs-Booking-AmendBooking"), Order(3)]
        public void FFT49_And_FFT86()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("UDFs-Booking-AmendBooking");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
           
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT_50_ClearParentUDFSelection();
            Thread.Sleep(5000);
            bookingsummary.FFT49and86_PopUPCLearValueFromDependentField();
            Thread.Sleep(2000);
            //TakeScreenshot();
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Booking-AmendBooking");

           }

         [Test, Category("UDFs-Booking-AmendBooking"), Order(4)]
        public void FFT98_DeactivateChildUdfandVerfiyForBooking()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("UDFs-Booking-AmendBooking");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(3000);
            lookup.SelectUDF_BookingDropedown();
            Thread.Sleep(2000);
            lookup.UDFSearchFor_deactivateCHildBookingUDF();

            //GOTO dIARY AND VERFIY FOR DEACTIVATED UDF
           // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            Thread.Sleep(4000);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
            //TakeScreenshot();
             bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "UDFs-Booking-AmendBooking");
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
