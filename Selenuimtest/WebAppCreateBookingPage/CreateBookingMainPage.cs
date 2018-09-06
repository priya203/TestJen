using OpenQA.Selenium;
using UnitTestProjectsummary.WebAppCreateBookingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
namespace UnitTestProjectsummary.PageElements
{
    public class CreateBookingMainPage:LoginMainPage
    {

        private readonly string CreateB = ConfigurationSettings.AppSettings["createBookingurl"];//"http://localhost/WebAppV6_3/Pages/BookingEdit.aspx";// @"searchEngineUrl";

       

        public CreateBookingMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        public CreateBookingMainPage()
        {
            
        }

        public CreateBookingPageElements CreateBookingMap
        {
            get
            {
                return new CreateBookingPageElements(this.browser);
                
            }


        }

        public CreateBookingPageValidators CreateBookingValidate()
        {
            return new CreateBookingPageValidators(this.browser);
           
        }


        public void CreateBookingNavigation()
        {

            this.browser.Navigate().GoToUrl(this.CreateB);

        }

        public void searchButtonclick()
        {
            this.CreateBookingMap.SearchButton.Click();
        
        }
        public void selectingtheresource()
        {
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@type='checkbox'])[last()]")));
            this.CreateBookingMap.SelctResource.Click();

        }

         public void GotoSummaryPage()
        {
            this.CreateBookingMap.SummaryPage.Click();

        }

         public void SelectingResourceTypeAsAllResources()
         {
             var drop = this.CreateBookingMap.ResourceType;
             var drop2 = new SelectElement(drop);
             drop2.SelectByIndex(2);           
         }

         public void SelectTime_1PM()
          {
             var time1=this.CreateBookingMap.ClickOn_FromDateTimePopUP;
            Actions act = new Actions(browser);
             act.MoveToElement(time1).Click().Build().Perform();
            Thread.Sleep(1000);
            this.CreateBookingMap.SelectDate_1PMTimePopUP.Click();
         }

         public void SelectTime_3PM()
         {
             var time1 = this.CreateBookingMap.ClickOn_FromDateTimePopUP;
             Actions act = new Actions(browser);
             act.MoveToElement(time1).Click().Build().Perform();
             Thread.Sleep(1000);
             this.CreateBookingMap.SelectDate_3PMTimePopUP.Click();}

         public void SelectTime_3AM()
         {
             CreateBookingNavigation();
             Thread.Sleep(2000);
             var today = DateTime.Today;
             string tomorrowFrom = today.ToString("dd/MM/yyyy");
             string tomorrowTo = today.ToString("dd/MM/yyyy");
             this.CreateBookingMap.FromDate.Clear();
             this.CreateBookingMap.FromDate.SendKeys(tomorrowFrom + " 03:00 AM");
             Thread.Sleep(3000);
             this.CreateBookingMap.ToDate.Clear();
             this.CreateBookingMap.ToDate.SendKeys(tomorrowTo + " 04:00 PM");
             Thread.Sleep(3000);
             
         }
         public void SelectTodaysDate_Time2PM_3PM()
         {
             var today = DateTime.Today;
            string tomorrowFrom = today.ToString("dd/MM/yyyy");
             string tomorrowTo = today.ToString("dd/MM/yyyy");
             this.CreateBookingMap.FromDate.Clear();
             this.CreateBookingMap.FromDate.SendKeys(tomorrowFrom + " 02:00 PM");
             Thread.Sleep(3000);
             this.CreateBookingMap.ToDate.Clear();
             this.CreateBookingMap.ToDate.SendKeys(tomorrowTo + " 03:00 PM");
             Thread.Sleep(3000);}

         public void SelectTodaysDate_Time12_30PM()
         {
             CreateBookingNavigation();
             Thread.Sleep(2000);
             var today = DateTime.Today;
            string tomorrowFrom = today.ToString("dd/MM/yyyy");
              string tomorrowTo = today.ToString("dd/MM/yyyy");
             this.CreateBookingMap.FromDate.Clear();
             this.CreateBookingMap.FromDate.SendKeys(tomorrowFrom + " 12:30 PM");
             Thread.Sleep(3000);
             this.CreateBookingMap.ToDate.Clear();
             this.CreateBookingMap.ToDate.SendKeys(tomorrowTo + " 01:30 PM");
             Thread.Sleep(3000);}
         


         public void SelectTomorrowsDate()
         {
             var today = DateTime.Today;
             var tomorrow = today.AddDays(1);
             string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy");
             string tomorrowTo = tomorrow.ToString("dd/MM/yyyy");
              this.CreateBookingMap.FromDate.Clear();
             this.CreateBookingMap.FromDate.SendKeys(tomorrowFrom + " 01:PM");
             Thread.Sleep(3000);
             this.CreateBookingMap.ToDate.Clear();
             this.CreateBookingMap.ToDate.SendKeys(tomorrowTo + " 02:PM");
             Thread.Sleep(3000);
          }
         public void SelectTomorrowsDate_Time10AM()
         {
             var today = DateTime.Today;
             var tomorrow = today.AddDays(1);
             string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy");
             string tomorrowTo = tomorrow.ToString("dd/MM/yyyy");
             this.CreateBookingMap.FromDate.Clear();
             this.CreateBookingMap.FromDate.SendKeys(tomorrowFrom + " 10:AM");
             Thread.Sleep(3000);
             this.CreateBookingMap.ToDate.Clear();
             this.CreateBookingMap.ToDate.SendKeys(tomorrowTo + " 11:AM");
             Thread.Sleep(3000);
         }
         public void SelectDate2Days_FromTodaysDateTime10To11AM()
         {
             var today = DateTime.Today;
             var tomorrow = today.AddDays(2);
             string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy");
             string tomorrowTo = tomorrow.ToString("dd/MM/yyyy");
             this.CreateBookingMap.FromDate.Clear();
             this.CreateBookingMap.FromDate.SendKeys(tomorrowFrom + " 10:AM");
             Thread.Sleep(3000);
             this.CreateBookingMap.ToDate.Clear();
             this.CreateBookingMap.ToDate.SendKeys(tomorrowTo + " 11:AM");
             Thread.Sleep(3000);
         }
         public void SelectDate3Days_FromTodaysDateTime10To11AM()
         {
             var today = DateTime.Today;
             var tomorrow = today.AddDays(3);
             string tomorrowFrom = tomorrow.ToString("dd/MM/yyyy");
             string tomorrowTo = tomorrow.ToString("dd/MM/yyyy");
             this.CreateBookingMap.FromDate.Clear();
             this.CreateBookingMap.FromDate.SendKeys(tomorrowFrom + " 10:AM");
             Thread.Sleep(3000);
             this.CreateBookingMap.ToDate.Clear();
             this.CreateBookingMap.ToDate.SendKeys(tomorrowTo + " 11:AM");
             Thread.Sleep(3000);
         }
         public void SelectingProperties()
         {

             this.CreateBookingMap.SelectProperties.Click();
             Thread.Sleep(3000);
            // this.CreateBookingMap.SelectProperties.SendKeys("Montreal");
             Thread.Sleep(2000);
           //  this.CreateBookingMap.SelectProperties.SendKeys(Keys.ArrowDown,Keys.Enter);
            // var property= this.CreateBookingMap.SelectProperties;
            // var selectproperty = new SelectElement(property);
            // selectproperty.DeselectAll();
            // selectproperty.SelectByIndex(0);
             Thread.Sleep(3000);
         }

        //public  IWebDriver browser { get; set; }}
       // public OpenQA.Selenium.IWebDriver browser { get; set; }

         public OpenQA.Selenium.IWebDriver browser { get; set; }
    }
}
