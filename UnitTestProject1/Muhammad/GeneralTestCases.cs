using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
//using OpenQA.Selenium.IE;
using UnitTestProjectsummary.PageElements;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.AllModules;
using System.Threading;
using OpenQA.Selenium.Support.UI;
//using NUnit.Framework;
//using OpenQA.Selenium.IE;
//using MFPOMProject;
//using MFPOMProject.PageObjects;
//using System.Threading;
//using MFPOMProject.AllModules;


namespace UnitTestProjectsummary
{
    [TestClass]
    public class MF_GeneralTestCases
    {

        public IWebDriver Driver;
        
        [TestInitialize]

        public void LaunchIE()
        {
           this.Driver = new ChromeDriver("E:\\Sel\\GetDock_driver\\chromedriver");
            //this.Driver = new InternetExplorerDriver("E:\\Sel\\GetDock_driver\\chromedriver");
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

    

        [TestMethod]
        //Navigate to Service Module
        public void ServicesModuleNavigationW()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            Services Browser = new Services(this.Driver);
            Browser.ClickServicesModule();
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='ctl00_subLblServiceTracker']")).Enabled);
            //Assert.IsTrue(Driver.FindElement(By.Id("ctl00_serviceTrackerTextSpan")).Displayed);
        }

        [TestMethod]
        //Search by Reference Number
        public void FindAddonsByReferenceNumberW()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            Services Services = new Services(this.Driver);
            Services.EnterReferenceNumber();
            Thread.Sleep(2000);
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdService_ctl00__0']/td[9]")).Enabled);
            
        }

        [TestMethod]
        //Search By Correct Booking Title
        public void FindBookingByTitleW()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            Services Browser = new Services(this.Driver);
            Browser.EnterBookingtitle();
            Thread.Sleep(3000);
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdService_ctl00__0']/td[9]")).Enabled);
        }


        [TestMethod]
        //Approve Addon From the above booking
        public void ApproveAddonW()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            Services serve = new Services(this.Driver);
            serve.ClickServicesModule();
            Thread.Sleep(3000);
            Driver.FindElement(By.CssSelector("#ctl00_MainContentPlaceHolder_grdService_ctl00_ctl04_imgbtnAccept")).Click();
        
        }

        [TestMethod]
        //Select a Property from the Property DropDown in Services
        public void SelectPropertyDropDown()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            Services Browser = new Services(this.Driver);
            Browser.ClickPropertyDropDown();
           
        }

      [TestMethod]
    
       public void MF_FFT51_CheckTodayDate()
        {
             LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            Thread.Sleep(5000);
            IWebElement ss = Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_calDateChange1_dateInput"));
            String DateT = ss.GetAttribute("value");
            Console.WriteLine(DateT);
            Assert.IsTrue(DateT.Equals("27/03/2018"));
        }

     [TestMethod]

        public void ServiceAddonNotesW()
      {
          LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
          Services SaveNotes = new Services(this.Driver);
          SaveNotes.ClickOnServiceNotes();
         
      }
        [TestMethod]

        public void ServiceCurrentDay()
     {
         LoginMainPage logint = new LoginMainPage(this.Driver);
         logint.Navigate();
         logint.Login();
         Thread.Sleep(2000);
         Services Browser = new Services(this.Driver);
         Browser.TodayDateVerification();
         Thread.Sleep(3000);
         IWebElement sss = Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_calDateChange_dateInput"));
         Thread.Sleep(3000);
         String ServicesDate = sss.GetAttribute("value");
         Console.WriteLine(ServicesDate);
         Assert.IsTrue(ServicesDate.Equals ("27/03/2018"));


     }
        
        [TestMethod]

       public void DepartDropDownW()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            Services MyServiceDrop = new Services(this.Driver);
            MyServiceDrop.DropDownSelection();
            Assert.IsTrue(Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSearch")).Displayed);
            
        }

        [TestMethod]
        public void CreateNewBooking()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            BookingModuleMethods browser = new BookingModuleMethods(this.Driver);
           // browser.NavigateToSignIn();

            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
           // CreateBooking.SelectTime_1PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            //Thread.Sleep(3000);
            //browser.ClickBookingsIcon();
            //Thread.Sleep(1000);
            //browser.ClickSearchButton();
            //Thread.Sleep(3000);
            //browser.ClickOnResource();
            //Thread.Sleep(2000);
            //browser.ClickSummaryButton();
            Thread.Sleep(7000);
            browser.BookingTitleText();
            Thread.Sleep(2000);
            browser.BookingHostField();
            Thread.Sleep(1000);
            browser.SaveAndExit();
            Thread.Sleep(2000);
            //Assert.IsTrue(Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSaveAndExit")).Displayed);
        }

        [TestMethod]
        public void CreateBookingFromDiary()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            BookingModuleMethods browser = new BookingModuleMethods(this.Driver);
         //   browser.NavigateToSignIn();
            Thread.Sleep(3000);
            browser.CreateBookingAtNine();
            Thread.Sleep(3000);
            browser.ContinueBookingFromDiary();
            Thread.Sleep(3000);
            browser.BookingTitleText();
            Thread.Sleep(1000);
            browser.BookingHostField();
            Thread.Sleep(2000);
            browser.SaveAndExit();
            //Assert.IsTrue(Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnGoToDiary")).Displayed);
        }


        //[TestCleanup]
      //  public void TearDown()
       // {
          //  this.driver.Quit();
       // }



        public WebDriverWait Wait { get; set; }
    }
       
}
