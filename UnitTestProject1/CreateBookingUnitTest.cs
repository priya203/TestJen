//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using UnitTestProjectsummary.PageElements;
using UnitTestProjectsummary.WebAppCreateBookingPage;
using System;
using System.Threading;
using UnitTestProjectsummary.MY_Option;
using NUnit.Framework;
using System.Globalization;


namespace UnitTestProjectsummary
{
     
    public class CreateBookingUnitTest
    {
        public CreateBookingUnitTest()
        { 
        }

        public IWebDriver Driver;

        public WebDriverWait Wait;
        private IWebDriver webDriver;

        public CreateBookingUnitTest(IWebDriver webDriver)
        {
            // TODO: Complete member initialization
            this.webDriver = webDriver;
        }

      [SetUp]
        public void SetupTest()
        {
            //this.Driver = new ChromeDriver();
            //this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(60));
            //Driver.Manage().Window.Maximize();

            this.Driver = new ChromeDriver("E:\\Sel\\GetDock_driver\\chromedriver");
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        [Test]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }
        [Test]
        public void NavigateToCreateBookingPage()
        {

            //SearchEngineTests test = new SearchEngineTests();
            //test.LoginMainPageSuccess();
            //CreateBookingMainPage cc = new CreateBookingMainPage();
            //cc.CreateBookingNavigation();
            LoginMainPage ll = new LoginMainPage(this.Driver);
            ll.Navigate();
            ll.Login();
            CreateBookingMainPage cc = new CreateBookingMainPage(this.Driver);
            cc.CreateBookingNavigation();
        }

        [Test]
        public void Selecting_The_Resource()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(4000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(7000);
           
        }


     
        public void VerifyFor_SummaryPageRecord()
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
            Thread.Sleep(2000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(7000);

        }
        [Test]
        public void TestUsDateFormat()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(3000);
            MyOptionMainPage opt = new MyOptionMainPage(this.Driver);
            opt.CheckUsTimeFOrmat();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            CreateBookingMainPage create = new CreateBookingMainPage(this.Driver);
            create.CreateBookingNavigation();
            Thread.Sleep(3000);
            IWebElement ele = Driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_popupButton']"));
            ele.Click();
            Thread.Sleep(2000);
            IWebElement ssg = Driver.FindElement(By.LinkText("2"));
            //IWebElement ssg = Driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtFrom_calendar_Top']/tbody/tr[2]/td[1]/a"));
            ssg.Click();
            IWebElement recur = Driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnRecurrence1']"));
            recur.Click();
            Thread.Sleep(3000);
            IWebElement frame1 = Driver.FindElement(By.Name("rdAddDuration"));
            Driver.SwitchTo().Frame(frame1);
            IWebElement FromDate=Driver.FindElement(By.XPath("//*[@id='rcRepeat_dtFrom_dateInput']"));
            var USDate1=FromDate.GetAttribute("Value");

            var USDate=DateTime.Parse(FromDate.GetAttribute("Value"));
            Console.WriteLine(USDate);
            System.DateTime dt = Convert.ToDateTime(USDate.ToString(), new CultureInfo("fr-ca"));
            Console.WriteLine(dt.ToString("dddd MMM d yyyy"));
      

            IWebElement ShowTargetDate = Driver.FindElement(By.XPath("//*[@id='rcRepeat_btnShowTargetDates']"));
            ShowTargetDate.Click();
            IWebElement SelectedDate = Driver.FindElement(By.XPath("//*[@id='rcRepeat_radSelectedDates']/div/ul/li[1]/span"));
            SelectedDate.Click();
           String SelectedDate1 = SelectedDate.Text;
            Console.WriteLine(SelectedDate1);
            Assert.IsTrue(dt.ToString("dddd MMM d yyyy").Equals(SelectedDate1));
}


      //  public IWebDriver webDriver { get; set; }
    }
}
