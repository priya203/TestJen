using System;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.PageElements;
using System.Threading;
using NUnit;
using UnitTestProjectsummary.Addons_ResourceManagement;
using UnitTestProjectsummary.Addons_NewBookingPage;
using System.Collections.Generic;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;
using UnitTestProjectsummary.PropertySetting_page;
using UnitTestProjectsummary.BRE;
//using RelevantCodes.ExtentReports;
using UnitTestProjectsummary.Deparments;
using System.Configuration;

namespace UnitTestProjectsummary
{
    [TestFixture]
    public class AddonTestCases
    {

        public IWebDriver Driver;
        public WebDriverWait Wait;
       // public static ExtentReports extent;
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

            //extent.LoadConfig(projectPath + "extent-config.xml");

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

        

        [Test,Category("AddonNotificationsAndStockType"),Order(1)]
        public void FFT227andFFT228_AddonNotificationMessage()
        {
            //test = extent.StartTest("FFT227andFFT228_AddonNotificationMessage");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(4000);
            
          
            DeparmentMainpage dept=new DeparmentMainpage(this.Driver);

            dept.FFT_227AddonNotificationMessageDepartement();
            Thread.Sleep(3000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_227AddonNotificationMessage();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.AddAddon_Cake_BySearch();
            Thread.Sleep(4000);
            addAddon.AcceptAddonNotificationMessageAndGetHeaderText();
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(3000);
            //TakeScreenshot();
            addAddon.GetAddedAddonName();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "Addon notification Message displayed");
            
            Thread.Sleep(3000);
            

        }


        [Test,Category("AddonNotificationsAndStockType"),Order(2)]
        public void FFT229_DisableAddonNotificationMessage()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            //bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("FFT229_DisableAddonNotificationMessage");
            Thread.Sleep(3000);
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
           DeparmentMainpage dept = new DeparmentMainpage(this.Driver);
          // dept.FFT_229AddonNotificationMessageDepartement_NO();
           Thread.Sleep(2000);
           AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_229DisableAddonNotificationMessage();
           // Thread.Sleep(3000);
           // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.AddAddon_Cake_BySearch();
            Thread.Sleep(3000);
            //TakeScreenshot();
            //addAddon.VerifyAddAddonButtonIsEnabled();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "Test Passed as Addon notification Message displayed");
        }



        [Test, Category("AddonNotificationsAndStockType"), Order(6)]
        public void FFT230_AddonsDisplayingUndeResourceCatagoey()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("FFT230_AddonsDisplayingUndeResourceCatagoey");
            //Thread.Sleep(3000);
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
           // TakeScreenshot();
            Thread.Sleep(3000);
            addAddon.GetAllAddonTextFromDifferentCatagory();
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "test passed as addons are getting displyed with resource catageory");
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
          
           


        }

        [Test, Category("AddonNotificationsAndStockType"), Order(3)]
        public void FFT231_AddonNoSTockType()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("FFT231_AddonNoSTockType");
           // LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_231StockType_NoStock();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            addAddon.ClickOnAddAddonButton();
           // TakeScreenshot();
            Thread.Sleep(2000);
            addAddon.SummaryButtonFromAddonPageIsEnabled();
            Thread.Sleep(3000);
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "Test passed as addons are added without restriction");


        }









        [Test, Category("AddonNotificationsAndStockType"), Order(4)]
        public void FFT232_AddonStockItem()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
          //  test = extent.StartTest("FFT232_AddonStockItem");
            Thread.Sleep(2000);
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_232StockType_WithStockAndCOnfigurations();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            Thread.Sleep(3000);
            addAddon.AddonQuantity5();
            addAddon.ClickOnAddAddonButton();
            //TakeScreenshot();
            addAddon.clickOnGoToSummaryFromAddonPage();
            addAddon.SummaryButtonFromAddonPageIsEnabled();
            Thread.Sleep(2000);
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "Test passed as Validations are alloweded");
            
        }

        [Test, Category("AddonNotificationsAndStockType"), Order(5)]
        public void FFT233_AddonStockType()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("BookingSearchPageNavigation");
            Thread.Sleep(2000);
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_232StockType_WithStockAndCOnfigurations();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);

            //***create Booking with addon quantity 4
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(3000);
           // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTitle();
            Thread.Sleep(2000);
            bookingsummary.clickonsave();

            //****Create Booking with addon quantity 3
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            Thread.Sleep(3000);
            addAddon.AddonQuantity3();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
            bookingsummary.FFT233_Is_AddonOutOfStock_PopUPEnabled();
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "Test passed as system is not allowing to book more number of addons");
        }


        [Test, Category("AddOnRecurringBooking"),Order(1)]
        public void FFT256_AddonRecurringBooking()
        {
         //   test = extent.StartTest("AddOnRecurringBooking");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);

            //createRecurring Booking with Addons
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.ClickOnRecurBookingButton();
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            Thread.Sleep(2000);
            bookingsummary.SelectDailyRecurBooking_FromBookingSummaryPage();
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);

            //adding two addons
            addAddon.FFT256_add_addon_Milk();
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.FFT256_add_addon_Juice();
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(3000);
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.EnterTitleForFFT_256();
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(10000);
            bookingsummary.clickonGoToDIary();

            //BookingSearch and Update Second occurance with new Addon
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectSecondOccurance();
            Thread.Sleep(2000);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.EditAddon();
            Thread.Sleep(1000);
            addAddon.FFT256_add_addon_Tea();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(10000);
            bookingsummary.clickonGoToDIary();

            //Booking search and update last occurance for time 2-3PM
            CreateBooking.CreateBookingNavigation();
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectThirdOccurance();
            Thread.Sleep(2000);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.SelectTimecalender_Time2PM();
            bookingsummary.NavigateTosrviceTrackerPage();
            Thread.Sleep(3000);
           // TakeScreenshot();
            bookingsummary.clickonGoToDIary();
           // test.Log(LogStatus.Pass, " please verify for updated time 3 to 4Pm in the screenshot");


        }

       [Test, Category("AddOnRecurringBooking"),Order(2)]
        public void FFT_257_AddOnRecurringBooking()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("AddOnRecurringBooking");
           
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            //Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectThirdOccurance();
            Thread.Sleep(2000);
           // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.ClickOnTimeViewPopUP_Select3PM();
            Thread.Sleep(15000);
            bookingsummary.NavigateTosrviceTrackerPage();
            Thread.Sleep(3000);
            //TakeScreenshot();
            bookingsummary.clickonGoToDIary();
            //test.Log(LogStatus.Pass, " please verify for updated time 3 to 4Pm in the screenshot");
        }

     [Test, Category("AddOnRecurringBooking"),Order(3)]
        public void FFT_259_AddOnRecurringBooking()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("AddOnRecurringBooking");
          //  LoginMainPage logint = new LoginMainPage(this.Driver);
           // logint.Navigate();
            //logint.Login();
            //Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectThirdOccurance();
            Thread.Sleep(2000);
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.ChangeBookingStatustoCancelled();
            bookingsummary.clickonsaveAndExit();
            bookingsummary.clickonGoToDIary();
            bookingsummary.NavigateTosrviceTrackerPage();
            Thread.Sleep(3000);
            bookingsummary.selectNextDateOnServiceTracker();
            Thread.Sleep(3000);
           // TakeScreenshot();
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "Please verify for cancelled Addon in provided screenshot");
        }

        [Test,Category("CutOffTime-CurrentTime1PM"),Order(1)]
        public void FFT_263Addon_CutOFF_period()
        {
            //test = extent.StartTest("CutOffTime-CurrentTime1PM");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
          addon.FFT_263_SetBookingCutOffPeriod_2Hrs();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_1PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            Thread.Sleep(3000);
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
           // TakeScreenshot();
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            //Thread.Sleep(2000);
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }

        [Test, Category("CutOffTime-CurrentTime1PM"), Order(2)]
        public void FFT_264Addon_CutOFF_period()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("CutOffTime-CurrentTime1PM");
            //LoginMainPage logint = new LoginMainPage(this.Driver);
           // logint.Navigate();
           // logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
           
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_3PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            Thread.Sleep(2000);
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
        addAddon.ClickOnAddAddonButton();
        Thread.Sleep(3000);
        addAddon.handlePopUpByTryCatch();
        Thread.Sleep(2000);
        addAddon.VerifyAddedAddon();

       // addAddon.verfiy_AddonCuttOffMessage_Enabled.click();
            Thread.Sleep(2000);
            //TakeScreenshot();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }

     [Test, Category("CutOffTime-CurrentTime1PM"), Order(3)]
        public void FFT_265Addon_CutOFF_period()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("CutOffTime-CurrentTime1PM");
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_265_SetBookingCutOffTime_3PM();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_1PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.handlePopUpByTryCatch();
            addAddon.VerifyAddedAddon();
            //TakeScreenshot();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }

         [Test, Category("CutOffTime-CurrentTime1PM"), Order(4)]
        public void FFT_266Addon_CutOFF_period()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           // bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("CutOffTime-CurrentTime1PM");
           // LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_265_SetBookingCutOffTime_12PM();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_1PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
           // TakeScreenshot();
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }

     [Test, Category("CutoffTime-CurrentTime:4PM"), Order(2)]
        public void FFT_267CutoffNoticePeriod()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("CutoffTime-CurrentTime:4PM");
           LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Set_AddonNotice24_CutOff_3Pm();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_267_ClearCutOffPeriodAndTime();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTomorrowsDate();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
           // TakeScreenshot();
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutoffWeekend-Day:Friday-CurrentTime:4PM");

        }

           [Test, Category("CutoffTime-CurrentTime:4PM"), Order(1)]
        public void FFT_268CutoffNoticePeriod()
        {

            //test = extent.StartTest("CutoffTime-CurrentTime:4PM");
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Set_AddonNotice8_CutOff_3PM();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_267_ClearCutOffPeriodAndTime();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTomorrowsDate();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(4000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
          
            Thread.Sleep(2000);
           // TakeScreenshot();
            Thread.Sleep(2000);
           
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
          //  Assert.IsTrue(true);
          //  test.Log(LogStatus.Pass, "CutoffTime-CurrentTime:4PM");
           
        }
        [Test, Category("CutoffWeekend-Day:Friday-CurrentTime:4PM"),Order(1)]
        public void FFT_269CutoffWeekendRule()
        {
            //test = extent.StartTest("CutoffWeekend-Day:Friday-CurrentTime:4PM");
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_269_Set48HoursforWeekend_CutOffTime3PM();
            BREMainPage bre = new BREMainPage(this.Driver);
            bre.FFT_269_48CutOffRuleForFriday();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTomorrowsDate_Time10AM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
           // TakeScreenshot();
             // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutoffTime-CurrentTime:4PM");


        }

        [Test, Category("CutoffWeekend-Day:Friday-CurrentTime:4PM"), Order(2)]
        public void FFT_270CutoffWeekendRule()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(4000);
          //  test = extent.StartTest("CutoffWeekend-Day:Friday-CurrentTime:4PM");
            //LoginMainPage logint = new LoginMainPage(this.Driver);
          // logint.Navigate();
          // logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_269_Set48HoursforWeekend_CutOffTime3PM();
            BREMainPage bre = new BREMainPage(this.Driver);
            bre.FFT_269_48CutOffRuleForFriday();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectDate2Days_FromTodaysDateTime10To11AM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(4000);
            //TakeScreenshot();
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(2000);
           // Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "CutoffWeekend-Day:Friday-CurrentTime:4PM");
        }

          [Test, Category("CutoffWeekend-Day:Friday-CurrentTime:4PM"), Order(3)]
        public void FFT_271CutoffWeekendRule()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("CutOffTime-CurrentTime1PM");
           // LoginMainPage logint = new LoginMainPage(this.Driver);
           // logint.Navigate();
           // logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_269_Set48HoursforWeekend_CutOffTime3PM();
            BREMainPage bre = new BREMainPage(this.Driver);
            bre.FFT_269_48CutOffRuleForFriday();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectDate3Days_FromTodaysDateTime10To11AM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            //TakeScreenshot();
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            //TakeScreenshot();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            //TakeScreenshot();
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(2000);
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutoffWeekend-Day:Friday-CurrentTime:4PM");
        }
           

        [Test, Category("CutOffTime-CurrentTime1PM"), Order(5)]
        public void FFT_272Cutoffs()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("CutOffTime-CurrentTime1PM");
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            //Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT272_SetCutOFfTime_4Pm_2Hrs();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTodaysDate_Time2PM_3PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            //TakeScreenshot();
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
           // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }

        [Test, Category("CutOffTime-CurrentTime1PM"), Order(6)]
        public void FFT_273_1Cutoffs()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("CutOffTime-CurrentTime1PM");
            //Creating New Booking With Titile FFT273
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_267_ClearCutOffPeriodAndTime();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.SelectTodaysDate_Time12_30PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.handlePopUpByTryCatch();
            addAddon.VerifyAddedAddon();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
           

           // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTtileFor_FFT_273_1();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();

            //Updating AddonSettings
            //AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_263_SetBookingCutOffPeriod_2Hrs();

            //update ExistingBooking
            bookingsummary.clickonGoToDIary();
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.FFT_273_1_BookingSearch();
            Thread.Sleep(2000);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.SelectToDateTime2_30();
            Thread.Sleep(6000);
            bookingsummary.NavigateTosrviceTrackerPage();
           // TakeScreenshot();
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
           // test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }


        [Test, Category("CutOffTime-CurrentTime1PM"), Order(7)]
        public void FFT_274Cutoffs()
        {
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("CutOffTime-CurrentTime1PM");

           // LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
           // logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_267_ClearCutOffPeriodAndTime();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.SelectTodaysDate_Time12_30PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.handlePopUpByTryCatch();
            addAddon.VerifyAddedAddon();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
           // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTtileFor_FFT_274();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();

            //Updating AddonSettings
          //  AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_265_SetBookingCutOffTime_12PM();

            //update ExistingBooking
            bookingsummary.clickonGoToDIary();
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.FFT_274_BookingSearch();
            Thread.Sleep(2000);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.SelectToDateTime2_30();
            Thread.Sleep(6000);
            bookingsummary.NavigateTosrviceTrackerPage();
           // TakeScreenshot();
            Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
            //Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }
        


   [Test, Category("CutOffTime-CurrentTime1PM"), Order(8)]
  public void FFT_275Cutoffs()
        {

            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            //test = extent.StartTest("CutOffTime-CurrentTime1PM");

            //LoginMainPage logint = new LoginMainPage(this.Driver);
           //logint.Navigate();
           //logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
           addon.FFT_275_CutOffTime_12PM_2hours();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            Thread.Sleep(2000);
            CreateBooking.SelectTodaysDate_Time12_30PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(6000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
       //new Cases
            addAddon.handlePopUpByTryCatch();
            addAddon.VerifyAddedAddon();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTtileFor_FFT_275();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            bookingsummary.NavigateTosrviceTrackerPage();
            Thread.Sleep(2000);
           // TakeScreenshot();
           // Thread.Sleep(2000);
            bookingsummary.clickonGoToDIary();
            //test.Log(LogStatus.Pass, "CutOffTime-CurrentTime1PM");
        }
          
        
 [Test]
 public void FFT_276Cutoffs()
 {
     LoginMainPage logint = new LoginMainPage(this.Driver);
     logint.Navigate();
     logint.Login();
     Thread.Sleep(2000);
     PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
     //propertyset.Clear_AddonNotice_CutOff();
     Thread.Sleep(2000);
     AddonMainPage addon = new AddonMainPage(this.Driver);
    // addon.FFT_276_Set48HoursforWeekend_CutOffTime3PM_2HrPeriod();
     BREMainPage bre = new BREMainPage(this.Driver);
     //bre.FFT_269_48CutOffRuleForFriday();
     CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
  
     Thread.Sleep(2000);
     CreateBooking.SelectTime_3AM();
     CreateBooking.searchButtonclick();
     Thread.Sleep(5000);
     CreateBooking.CreateBookingValidate().TestResourceCheckbox();
     CreateBooking.selectingtheresource();
     Thread.Sleep(3000);
     CreateBooking.GotoSummaryPage();
     Thread.Sleep(4000);
     Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
     addAddon.CliCkOnAddAddon_FromBookingSummary();
     Thread.Sleep(3000);
     addAddon.FFT_263_Add_addon_CheeseTray();
     Thread.Sleep(2000);
     addAddon.ClickOnAddAddonButton();
     Thread.Sleep(2000);
     addAddon.clickOnGoToSummaryFromAddonPage();
     Thread.Sleep(2000);
     BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
     bookingsummary.EnterTtileFor_FFT_276();
     Thread.Sleep(2000);
     bookingsummary.clickonsaveAndExit();
     Thread.Sleep(3000);
     bookingsummary.clickonGoToDIary();
     Thread.Sleep(3000);
     bookingsummary.NavigateTosrviceTrackerPage();
    
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
    // extent.Flush();
     //extent.Close();
     //Driver.Quit();
 }

        public IWebDriver webDriver { get; set; }

    }
}
