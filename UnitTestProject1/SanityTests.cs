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
using RelevantCodes.ExtentReports;
using UnitTestProjectsummary.Addons_NewBookingPage;
using UnitTestProjectsummary.Addons_ResourceManagement;
using System.Configuration;


namespace UnitTestProjectsummary
{
    [TestFixture]
    public class SanityTests
    {

        public IWebDriver Driver;
        public WebDriverWait Wait;
        private readonly string ChromeDriverpath = ConfigurationSettings.AppSettings["ChromeDriverPath"];


        [OneTimeSetUp]
        public void SetupTest()
        {
            //this.Driver = new ChromeDriver();
           this.Driver = new ChromeDriver(ChromeDriverpath);
            //this.Driver = new ChromeDriver("E:\\Sel\\GetDock_driver\\chromedriver");
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

       [Test, Category("Sanity"), Order(1)]
        public void SN_01()
        {
           
        
                // test = extent.StartTest("CreateBookingFromNewBookingPage");
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
                //Thread.Sleep(8000);
                CreateBooking.GotoSummaryPage();
                BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(5000);
                bookingsummary.EnterTitleSanity_NewBooking();
                BookingSearchMainPage search = new BookingSearchMainPage(this.Driver);
                // search.ENterHost();
                //search.ENterRequester();
                //search.EnterNotesForCreateBooking();
                //search.EnterSpecialRequest_bookingStatus();
                Thread.Sleep(5000);
                bookingsummary.clickonsave();
                Thread.Sleep(2000);
                bookingsummary.GetAllDetails();
                // TakeScreenshot();
                bookingsummary.AcceptSaveBookingPopUP();
                //  Assert.IsTrue(true);
                //  test.Log(LogStatus.Pass, "Booking Created successfully");
                Thread.Sleep(3000);
                bookingsummary.clickonGoToDIary();
                Thread.Sleep(5000);
                }
        
      [Test, Category("Sanity"), Order(2)]
        public void SN_02()
        {
             BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(3000);
                // bookingsummary.clickonGoToDIary();
                //test = extent.StartTest("Create Booking From Diary");
                // LoginMainPage logint = new LoginMainPage(this.Driver);
                //// logint.Navigate();
                //logint.Login();
                Thread.Sleep(2000);
                DiaryMainPage dd = new DiaryMainPage(this.Driver);
                dd.selectDiaryCellandContinuwithBooking();
                CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
                // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(5000);
                bookingsummary.EnterTitleSanity_DiaryBooking();
                BookingSearchMainPage search = new BookingSearchMainPage(this.Driver);
                //search.ENterHost();
                //search.ENterRequester();
                //search.EnterNotesForCreateBooking();
                //search.EnterSpecialRequest_bookingStatus();
                Thread.Sleep(5000);
                bookingsummary.clickonsave();
                Thread.Sleep(2000);
                bookingsummary.GetAllDetails();
                //TakeScreenshot();
                bookingsummary.AcceptSaveBookingPopUP();
                // Assert.IsTrue(true);
                // test.Log(LogStatus.Pass, "Booking has Created successfully from diary");
                bookingsummary.clickonGoToDIary();
            }
          

     [Test, Category("Sanity"), Order(3)]
        public void SN_03()
        {
           
                BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(3000);
                bookingsummary.clickonGoToDIary();
                // test = extent.StartTest("Create Booking without title");
                //LoginMainPage logint = new LoginMainPage(this.Driver);
                //logint.Navigate();
                //logint.Login();
                Thread.Sleep(2000);
                DiaryMainPage dd = new DiaryMainPage(this.Driver);
                dd.SN_03_SelectDiaryCell();
                CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
                // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(5000);
                bookingsummary.clickonsave();
                Thread.Sleep(4000);
                // TakeScreenshot();
                bookingsummary.AcceptSaveBookingPopUP();
                //Assert.IsTrue(true);
                // test.Log(LogStatus.Pass, "Booking has Created successfully from diary");
                bookingsummary.clickonGoToDIary();
            }
           
    
    [Test, Category("Sanity"), Order(4)]
        public void SN_04()
        {
          
                BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(3000);
                bookingsummary.clickonGoToDIary();
                //test = extent.StartTest("CreateBookingwith the multiple Addons and requestor");
                // LoginMainPage logint = new LoginMainPage(this.Driver);
                //logint.Navigate();
                //logint.Login();
                Thread.Sleep(2000);
                DiaryMainPage dd = new DiaryMainPage(this.Driver);
                dd.SN_04_SelectDiaryCell();
                CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
                // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(5000);
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
                Thread.Sleep(3000);
                bookingsummary.clickonAddPplTab();
                //Thread.Sleep(3000);
                bookingsummary.AddInternalVisitors();
                Thread.Sleep(3000);
                bookingsummary.PopUPHandling();
                Thread.Sleep(3000);
                bookingsummary.GotoSummaryPagefromVisitors();
                Thread.Sleep(3000);
                bookingsummary.EnterTitleSanityAddonVCheck();
                Thread.Sleep(3000);
                bookingsummary.clickOnParticipant();
                Thread.Sleep(3000);
                //TakeScreenshot();
                addAddon.CliCkOnAddAddon_FromBookingSummary();
                Thread.Sleep(2000);
                addAddon.GetallAddedAddonName();
                Thread.Sleep(2000);
                addAddon.clickOnGoToSummaryFromAddonPage();
                Thread.Sleep(3000);
                bookingsummary.clickonsave();
                Thread.Sleep(4000);
                bookingsummary.AcceptSaveBookingPopUP();
                //Assert.IsTrue(true);
                // test.Log(LogStatus.Pass, "Booking has Created successfully from diary");
                bookingsummary.clickonGoToDIary();
            }
           

        //[Test, Category("Sanity"), Order(5)]
        //public void SN_05()
        //{
        //     BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //     bookingsummary.clickonGoToDIary();
        //     Thread.Sleep(3000);
        //    // test = extent.StartTest("CreateRecurringBooking");
        //    //LoginMainPage gg = new LoginMainPage(this.Driver);
        //    //gg.Navigate();
        //    //gg.Login();
        //    Thread.Sleep(2000);
        //    DiaryMainPage diary = new DiaryMainPage(this.Driver);
        //    diary.FFT47_selectDiaryCellForRecurBooking();
        //    Thread.Sleep(1000);
        //    diary.SelectRecurBooking_Checkbox();
        //    Thread.Sleep(2000);
        //    diary.FFTTest46_EnterFromandToDateSlot_10111();
        //    diary.SelectDailyRecurringBooking();
        //    diary.SelectDailyRecurBookingDates();
        //    diary.ShowTargetDate_ContinueBooking_recur();
        //    diary.FFTTest46_clickOncontinuewithbookingTime_1011();
        //    Thread.Sleep(4000);
        //    diary.EnterTitleForRecurringBooking();
        //    Thread.Sleep(2000);
        //    //TakeScreenshot();
        //    //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //    Thread.Sleep(5000);
        //    bookingsummary.clickonsave();
        //    // Thread.Sleep(2000);
        //    Thread.Sleep(2000);
        //    bookingsummary.GetAllDetails();
        //   // TakeScreenshot();
        //    bookingsummary.AcceptSaveBookingPopUP();
        //   // Assert.IsTrue(true);
        //   // test.Log(LogStatus.Pass, "CreateRecurringBooking");
        //    bookingsummary.clickonGoToDIary();
          
        //}

        //[Test, Category("Sanity"), Order(6)]
        //public void SN_06() //UpdateRecurringBooking And Verify for updated records
        //{
        //    BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //      bookingsummary.clickonGoToDIary();
        //        Thread.Sleep(3000);
        //        //test = extent.StartTest("UpdateRecurringBooking");

        //    //LoginMainPage gg = new LoginMainPage(this.Driver);
        //    //gg.Navigate();
        //    //gg.Login();
        //    Thread.Sleep(2000);
        //    DiaryMainPage diary = new DiaryMainPage(this.Driver);
        //    //bookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //    Thread.Sleep(1000);
        //    diary.FFT47_selectDiaryCellForRecurBooking();
        //    Thread.Sleep(1000);
        //    diary.FFT47_SwitchtorecurringBookingPanel();
        //    Thread.Sleep(1000);
        //    diary.FFT47_SelectEntireSeries();
        //    Thread.Sleep(3000);
        //    BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
        //    booksearch.UpdateSpecialRequest_bookingStatus();
        //    Thread.Sleep(2000);
        //    diary.FFT_47_RecurBookingupdatedTitle();
        //    Thread.Sleep(2000);
        //    bookingsummary.clickonsaveAndExit();
        //    Thread.Sleep(5000);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(3000);
        //   diary.FFT47_SwitchtoDateTableOnDiary();
        //    diary.FFT_47_SelectNextDate();
        //    Thread.Sleep(3000);
        //    diary.FFT47_selectDiaryCellForRecurBooking();
        //    Thread.Sleep(5000);
        //    diary.FFT47_SwitchtorecurringBookingPanel();
        //    Thread.Sleep(5000);
        //    diary.FFT47_SelectEntireSeries();
        //    Thread.Sleep(6000);
        //    //TakeScreenshot();
        //    diary.FFT_47_ValidateUpdatedBookingTitle();
        //    Thread.Sleep(2000);
        //   // TakeScreenshot();
        //    bookingsummary.GetAllDetails();
        //    // Assert.IsTrue(true);
        //    //test.Log(LogStatus.Pass, "Recurring Booking has updated successfully");
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(5000);
        //    diary.ClickonGotoBackDate();
        //    }


        //[Test, Category("Sanity"), Order(7)]
        //public void SN_07()
        //{
        //    BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(3000);
        //   // test = extent.StartTest("DragDropBookingToNewResource");
        //    //LoginMainPage logint = new LoginMainPage(this.Driver);
        //    //logint.Navigate();
        //    //logint.Login();
        //    Thread.Sleep(2000);
        //    DiaryMainPage dd = new DiaryMainPage(this.Driver);
        //    dd.FFTTest200_SelectAndContinueWithBooking();
        //    Thread.Sleep(1000);
        //    //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //    Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
        //    // addAddon.CliCkOnAddAddon_FromBookingSummary();
        //    Thread.Sleep(3000);
        //    Thread.Sleep(2000);
        //    bookingsummary.clickOnAddAddon();
        //    Thread.Sleep(3000);
        //    bookingsummary.EnterTitleFFT_200();
        //    Thread.Sleep(5000);
        //    bookingsummary.clickonsaveAndExit();
        //    Thread.Sleep(7000);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(7000);
        //    dd.FFTTest200_DragandDrop_Chnageroom();
        //    Thread.Sleep(7000);
        //    dd.ClickConfirmChangeRoom();
        //    Thread.Sleep(3000);
        //    dd.ClickOnMovedBooking_Room();
        //    Thread.Sleep(3000);
        //    bookingsummary.FFT200_clickonAddAdon_Button_Verify_AddedAddon();
        //    Thread.Sleep(3000);
        //   // TakeScreenshot();
        //    //Assert.IsTrue(true);
        //    //test.Log(LogStatus.Pass, "Booking move is successfull");
        //    bookingsummary.clickonGoToDIary();
        //}


        //[Test, Category("Sanity"), Order(8)]
        //public void SN_08()
        //{
        //    BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //    bookingsummary.clickonGoToDIary();
        //   // test = extent.StartTest("DragAndDropWithSetupBreakdownTime");
        //    //LoginMainPage logint = new LoginMainPage(this.Driver);
        //    //logint.Navigate();
        //    //logint.Login();
        //    Thread.Sleep(3000);
        //    DiaryMainPage dd = new DiaryMainPage(this.Driver);
        //    dd.FFTTest202_SelectAndContinueWithBooking();
        //    Thread.Sleep(3000);
        //    bookingsummary.EnterTitleFFT_202();
        //    Thread.Sleep(2000);
        //    bookingsummary.ENterSetUPtime();
        //    Thread.Sleep(2000);
        //    bookingsummary.ENterBreakdowntime();
        //    Thread.Sleep(2000);
        //    bookingsummary.clickonsaveAndExit();
        //    Thread.Sleep(7000);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(7000);
        //    dd.FFTTest202_DragandDrop();
        //    Thread.Sleep(8000);
        //    Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
        //    dd.ClickOn_confirmMoveBooking();
        //    Thread.Sleep(8000);
        //    dd.FFTTest202_ClickOnMovedBooking_Time();
        //    Thread.Sleep(4000);
        //    bookingsummary.VerifySetUpBreakdownTime_ForMovedBooking();
        //    Thread.Sleep(3000);
        //  // TakeScreenshot();
        //   // Assert.IsTrue(true);
        //   // test.Log(LogStatus.Pass, "SetUp Breakdown time has been verified successfully");
        //    bookingsummary.clickonGoToDIary();
        //}

        //[Test, Category("Sanity"), Order(9)]
        //public void SN_09()
        //{
        //    BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(2000);

        //    //test = extent.StartTest("SetUPBreakdownOverlap");
        //    //createFirstBookingWithsetUPbreakdownTime12To1
        //    //LoginMainPage gg = new LoginMainPage(this.Driver);
        //    //gg.Navigate();
        //    // Thread.Sleep(3000);
        //    //gg.Login();
        //    Thread.Sleep(3000);
        //    DiaryMainPage diary = new DiaryMainPage(this.Driver);
        //    diary.FFTTest203_SelectAndContinueWithBookingFirst12to1PM();
        //    diary.EnterFromandToDateSlot_12to1PM();
        //    diary.FFTTest46_clickOncontinuewithbookingTime_1011();   //JustClickingOnContinuewithBooking
        //    Thread.Sleep(3000);
        //    bookingsummary.ENterSetUPtime();
        //    bookingsummary.ENterBreakdowntime();
        //    bookingsummary.EnterTitle();
        //    bookingsummary.clickonsave();
        //    Thread.Sleep(2000);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(3000);

        //    //CreateBooking with setUp Breakdown Time 2to3
        //    diary.FFTTest203_SelectAndContinueWithBookingFirst2PMto3PM();
        //    diary.EnterFromandToDateSlot_2PMto3PM();
        //    diary.FFTTest46_clickOncontinuewithbookingTime_1011();
        //    Thread.Sleep(3000);
        //    bookingsummary.ENterSetUPtime();
        //    bookingsummary.ENterBreakdowntime();
        //    bookingsummary.EnterTitle();
        //    bookingsummary.clickonsave();
        //    Thread.Sleep(2000);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(3000);
        //    diary.FFTTest203_DragandDropto_NewTime();
        //    Thread.Sleep(5000);
        //    Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
        //    Thread.Sleep(2000);
        //    diary.FFTTest203_ChangeDateTime_ForMoveBooking();
        //    Thread.Sleep(4000);
        //    diary.ClickOn_confirmMoveBooking();
        //    Thread.Sleep(6000);
        //    //TakeScreenshot();
        //    //Assert.IsTrue(true);
        //    //test.Log(LogStatus.Pass, "BRE Setting Overlap");
        //}


        //[Test, Category("Sanity"), Order(10)]
        //public void SN_10()
        //{
        //    BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //    bookingsummary.clickonGoToDIary();
        //    Thread.Sleep(3000);
        //    //test = extent.StartTest("AddonNoSTockType");
        //    //LoginMainPage logint = new LoginMainPage(this.Driver);
        //    //logint.Navigate();
        //    //logint.Login();
        //    Thread.Sleep(2000);
        //    AddonMainPage addon = new AddonMainPage(this.Driver);
        //    addon.FFT_231StockType_NoStock();
        //    CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
        //    CreateBooking.CreateBookingNavigation();
        //    Thread.Sleep(2000);
        //    CreateBooking.searchButtonclick();
        //    Thread.Sleep(5000);
        //    CreateBooking.CreateBookingValidate().TestResourceCheckbox();
        //    CreateBooking.selectingtheresource();
        //    Thread.Sleep(3000);
        //    CreateBooking.GotoSummaryPage();
        //    Thread.Sleep(4000);
        //    Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
        //    addAddon.CliCkOnAddAddon_FromBookingSummary();
        //    Thread.Sleep(2000);
        //    addAddon.add_addon_Bread_VerifyStock();
        //    addAddon.ClickOnAddAddonButton();
        //    //TakeScreenshot();
        //    Thread.Sleep(2000);
        //    addAddon.SummaryButtonFromAddonPageIsEnabled();
        //    Thread.Sleep(3000);
        //    //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        //   // Assert.IsTrue(true);
        //   // test.Log(LogStatus.Pass, "Test passed as addons are added without restriction");
        //    bookingsummary.clickonGoToDIary();}


       [Test, Category("Sanity"), Order(11)]
        public void SN_11CancelBooking()
        {
           BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
           // test = extent.StartTest("CancelBooking");

            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(3000);
             DiaryMainPage diary = new DiaryMainPage(this.Driver);
             Thread.Sleep(3000);
             diary.cancelBooking_ResourceCancellation();
             Thread.Sleep(2000);
            // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            // Assert.IsTrue(true);
           // test.Log(LogStatus.Pass, "Test passed as Booking has cancelled successsfully");
            //TakeScreenshot();
        }

        //Copy Booking
        [Test, Category("Sanity"), Order(12)]
        public void SN_12()
        {
                BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
               // bookingsummary.clickonGoToDIary();
                Thread.Sleep(3000);
                // test = extent.StartTest("CancelBooking");
                LoginMainPage logint = new LoginMainPage(this.Driver);
                //logint.Navigate();
                //logint.Login();
                //Thread.Sleep(3000);
                DiaryMainPage diary = new DiaryMainPage(this.Driver);
                Thread.Sleep(3000);
                diary.Copybookingfromdiary_toNextDate();
                Thread.Sleep(4000);
                bookingsummary.clickonGoToDIary();
                Thread.Sleep(5000);
                diary.FFT_47_SelectNextDate();
                Thread.Sleep(3000);
                diary.SN_12SelectDIaryCell_View();
                // TakeScreenshot();
                Thread.Sleep(3000);
                // bookingsummary.clickOnParticipant();
                Addons_FromNewBookingPage addAddon2 = new Addons_FromNewBookingPage(this.Driver);
                addAddon2.CliCkOnAddAddon_FromBookingSummary();
                addAddon2.GetallAddedAddonName();
                //Assert.IsTrue(true);
                // test.Log(LogStatus.Pass, "Test passed as Booking has cancelled successsfully");
                bookingsummary.clickonGoToDIary();
                Thread.Sleep(4000);
                diary.ClickonGotoBackDate();
                Thread.Sleep(3000);
         
          
        }

       [Test, Category("Sanity"), Order(13)]
        public void SN_13_CreatePastBooking()
        {
             
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
          //  bookingsummary.clickonGoToDIary();
            Driver.Navigate().Refresh();
            Thread.Sleep(3000);
            //LoginMainPage logint = new LoginMainPage(this.Driver);
            //logint.Navigate();
            //logint.Login();
            Thread.Sleep(4000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.ClickonGotoBackDate();
            Thread.Sleep(3000);
            DiaryMainPage dd = new DiaryMainPage(this.Driver);
            dd.selectDiaryCellandContinuwithBooking();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
             //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(5000);
            bookingsummary.EnterTitleForPastBooking();
            BookingSearchMainPage search = new BookingSearchMainPage(this.Driver);
           // search.EnterNotesForCreateBooking();
            //search.EnterSpecialRequest_bookingStatus();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
            bookingsummary.GetAllDetails();
            //TakeScreenshot();
            bookingsummary.AcceptSaveBookingPopUP();
           Thread.Sleep(3000);
           bookingsummary.clickonGoToDIary();
           Thread.Sleep(3000);
         // diary.FFT_47_SelectNextDate();
           //Thread.Sleep(2000);
          // bookingsummary.clickonGoToDIary();
          //Thread.Sleep(3000);
           
       }
       [Test, Category("Sanity"), Order(14)]
        public void SN_14_UpdatePastBooking()
        {
            
                BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                bookingsummary.clickonGoToDIary();
                Thread.Sleep(3000);
                //LoginMainPage logint = new LoginMainPage(this.Driver);
                //logint.Navigate();
                //logint.Login();
               // Thread.Sleep(4000);
                DiaryMainPage diary = new DiaryMainPage(this.Driver);
                //diary.ClickonGotoBackDate();
                Thread.Sleep(3000);
                DiaryMainPage dd = new DiaryMainPage(this.Driver);
                dd.selectDiaryCellOnly();
                CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
               // BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(5000);
                bookingsummary.EnterUpdatedTitleForPastBooking();
                Thread.Sleep(2000);
                BookingSearchMainPage search = new BookingSearchMainPage(this.Driver);
               // search.ENterHost();
                //search.ENterRequester();
                Thread.Sleep(5000);
                bookingsummary.GetAllDetails();
                Thread.Sleep(2000);
                bookingsummary.clickonsaveAndExit();
                Thread.Sleep(2000);
               // bookingsummary.GetAllDetails();
                //TakeScreenshot();
             // bookingsummary.AcceptSaveBookingPopUP();
                Thread.Sleep(3000);
               bookingsummary.clickonGoToDIary();
                Thread.Sleep(3000);
               diary.FFT_47_SelectNextDate();
               Thread.Sleep(3000);

         
        }


       [Test, Category("Sanity"), Order(15)]
        public void SN15_CreateFutureBooking()
        {
               BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
               bookingsummary.clickonGoToRefresh();

                Thread.Sleep(3000); 
                //LoginMainPage logint = new LoginMainPage(this.Driver);
                //logint.Navigate();
                //logint.Login();
                Thread.Sleep(4000);
                DiaryMainPage diary = new DiaryMainPage(this.Driver);
                diary.FFT_47_SelectNextDate();
                Thread.Sleep(2000);
                DiaryMainPage dd = new DiaryMainPage(this.Driver);
                dd.selectDiaryCellandContinuwithBooking();
                CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
                //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                Thread.Sleep(5000);
                bookingsummary.EnterTitleForFutureBooking();
                BookingSearchMainPage search = new BookingSearchMainPage(this.Driver);
                //search.ENterHost();
                //search.ENterRequester();
                //search.EnterNotesForCreateBooking();
                //search.EnterSpecialRequest_bookingStatus();
                Thread.Sleep(5000);
                bookingsummary.clickonsave();
                Thread.Sleep(2000);
                bookingsummary.GetAllDetails();
                //TakeScreenshot();
                bookingsummary.AcceptSaveBookingPopUP();
                bookingsummary.clickonGoToDIary();
          
          }

         [Test, Category("Sanity"), Order(16)]
         public void SN16_UpdateFutureBooking()
         {
             
                 BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                    bookingsummary.clickonGoToDIary();
                    Thread.Sleep(3000);
                 //LoginMainPage logint = new LoginMainPage(this.Driver);
                 //logint.Navigate();
                 //logint.Login();
                 //Thread.Sleep(4000);
                 DiaryMainPage diary = new DiaryMainPage(this.Driver);
                // diary.FFT_47_SelectNextDate();
                 Thread.Sleep(3000);
                 DiaryMainPage dd = new DiaryMainPage(this.Driver);
                 dd.selectDiaryCellOnly();
                 CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
               //  BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                 Thread.Sleep(5000);
                 bookingsummary.EnterupdatedTitleForFutureBooking();
                 BookingSearchMainPage search = new BookingSearchMainPage(this.Driver);
                 search.ENterHost();
                 //Thread.Sleep(5000);
                // bookingsummary.clickonsave();
                 bookingsummary.GetAllDetails();
                 bookingsummary.clickonsaveAndExit();
                 Thread.Sleep(4000);
               //  bookingsummary.GetAllDetails();
                // bookingsummary.AcceptSaveBookingPopUP();
                 Thread.Sleep(3000);
                 //bookingsummary.clickonGoToDIary();
                 //Thread.Sleep(3000);

             }

         [Test, Category("Sanity"), Order(17)]
         public void SN17_QCReport1()
         {

               BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
               bookingsummary.clickonGoToDIary();
               Thread.Sleep(3000);
                    //DiaryMainPage diary = new DiaryMainPage(this.Driver);

                   //LoginMainPage logint = new LoginMainPage(this.Driver);
                   //logint.Navigate();
                   //logint.Login();
                   //Thread.Sleep(4000);
                 DiaryMainPage diary = new DiaryMainPage(this.Driver);
               //  diary.FFT_47_SelectNextDate();
                 Thread.Sleep(3000);
                 DiaryMainPage dd = new DiaryMainPage(this.Driver);
                 dd.selectDiaryCellOnly();
                 CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
              //   BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                 Thread.Sleep(5000);
                 diary.VerifyQuickConfirmationReportWindow();
                 Thread.Sleep(3000);
                 Driver.Navigate().Refresh();
                // bookingsummary.clickonGoToDIary();
                 Thread.Sleep(3000);

         }



   [Test, Category("Sanity"), Order(18)]
         public void SN18_QCReport2()
         {
            
                 BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                 Driver.Navigate().Refresh();
                 //bookingsummary.clickonGoToDIary();
                 Thread.Sleep(3000);
                 //LoginMainPage logint = new LoginMainPage(this.Driver);
                 //logint.Navigate();
                 //logint.Login();
                 //Thread.Sleep(4000);
                 DiaryMainPage diary = new DiaryMainPage(this.Driver);
               //  diary.FFT_47_SelectNextDate();
                 Thread.Sleep(3000);
                 DiaryMainPage dd = new DiaryMainPage(this.Driver);
               //  dd.selectDiaryCellOnly();
                 CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
                 //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
                 Thread.Sleep(5000);
                 diary.SendQuickConfirmationReport();
                 Thread.Sleep(3000);
                 bookingsummary.clickonGoToDIary();
                 Thread.Sleep(3000);
               }



      




        [TearDown]
        public void GetResult()
        {
            //var status = TestContext.CurrentContext.Result.Outcome.Status;
            //var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            //var errorMessage = TestContext.CurrentContext.Result.Message;

            //if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            //{
            //    test.Log(LogStatus.Fail, stackTrace + errorMessage);
            //}



            //extent.EndTest(test);
        }

        [OneTimeTearDown]
        public void EndReport()
        {
           // extent.Flush();
            //extent.Close();
            Driver.Quit();
        }



    }
}



    

