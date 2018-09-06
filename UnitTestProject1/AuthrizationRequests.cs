
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProjectsummary.Authorization_request;
using UnitTestProjectsummary.PageElements;

namespace UnitTestProjectsummary
{
      [TestFixture]
    public class AuthrizationRequests
    {
        public IWebDriver Driver;
        public WebDriverWait Wait;
        public String refnum;
        private readonly string refg = ConfigurationSettings.AppSettings["ToDate"];

        [SetUp]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver("E:\\Sel\\GetDock_driver\\chromedriver");
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }


        [Test, Category("Authrization"), Order(1)]
        public void Authrization_RequestPageProperties()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AuthrizationMainPage auth=new AuthrizationMainPage(this.Driver);
            auth.NavigatetoAuth();
            auth.checkElementsEnabled();
        }
        [Test, Category("Authrization"), Order(2)]
        public void Authrization_RequestStartDateVerify()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AuthrizationMainPage auth = new AuthrizationMainPage(this.Driver);
            auth.NavigatetoAuth();
            auth.checkElementsEnabled();
            auth.StartDateCHeck();
        }
        [Test, Category("Authrization"), Order(3)]
        public void CreateBookings_Status_RequestDemand()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.BookingNavigationsAndLogin();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.SelectTodaysDate_Time2PM_3PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(5000);
            bookingsummary.EnterTitle_AuthrizationRequestBooking();
            Thread.Sleep(5000);
            bookingsummary.Status_Request();
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
            bookingsummary.GetAllDetails();
            bookingsummary.AcceptSaveBookingPopUP();
            Thread.Sleep(2000);
            IWebElement test1 = Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_lblReferenceNumber"));
            var strArr = test1.Text.Split(':');
            var refnumber = strArr[1];

            test(refnumber);
           // String aa = readvalue();

           // refnum = refnumber;
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

        public void test(string refvalue)
        {

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["Ref900"].Value = refvalue;
            config.Save(ConfigurationSaveMode.Modified);
        }
        public String readvalue()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var clientsFilePath = config.AppSettings.Settings["Ref900"].Value;
            return clientsFilePath;
        }
 


     
     [Test, Category("Authrization"), Order(4)]
        public void Searchwith_referenceNumber()
        {

            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.BookingNavigationsAndLogin();
           // CreateBookings_Status_RequestDemand();
            AuthrizationMainPage auth = new AuthrizationMainPage(this.Driver);
            auth.NavigatetoAuth();
            auth.checkElementsEnabled();
            
            IWebElement RefNumb=Driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00_ctl02_ctl02_FilterTextBox_BookingReferenceNumberAuth_SP']"));
            RefNumb.SendKeys(readvalue());
            RefNumb.SendKeys(Keys.Enter);
            Driver.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00__0']"));
           // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);  
            IWebElement searchref=Driver.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00__0']/td[3]"));
            string searchref2 = searchref.Text;
            //Console.WriteLine(searchref2);
            //Thread.Sleep(2000);
            Assert.IsTrue(searchref2.Equals(readvalue()));
           // Thread.Sleep(2000);
     }

        [Test, Category("Authrization"), Order(4)]
        public void ConfirmBooking_FromAuthPage()
        {
            Searchwith_referenceNumber();

        
        }
   
        
    }




}
