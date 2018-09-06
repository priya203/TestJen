using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.BRE
{
   public class BREMainPage
    {
       
       public BREMainPage(IWebDriver browser)
       { 
           this.browser = browser;
       }

       public BREMainPage()
        {
       }
       public BREPageElements bremap
       {
           get
           {
               return new BREPageElements(this.browser);
           }
       }

       public void BREnavigations()
       {
            this.bremap.AdministrationLink.Click();
            this.bremap.SettingLink.Click();
            this.bremap.BRELink.Click();
       }

       public void SelectDropeDownTorronto()
       {   var drop1 = this.bremap.SelectProperty_Toronto;
           drop1.Click();
           Thread.Sleep(1000);
           Actions action = new Actions(browser);
           action.MoveToElement(drop1).SendKeys("Toronto - NEW").Build().Perform();}

       public void SelectDayOfWeektoApply48Hours()
       {   var drop3 = this.bremap.Select48_hoursWeekendDropedown_Friday;
           SelectElement select1 = new SelectElement(drop3);
           select1.SelectByIndex(5);}

       public void FFT_269_48CutOffRuleForFriday()
       {
           BREnavigations();
           Thread.Sleep(3000);
           SelectDropeDownTorronto();
           Thread.Sleep(2000);
           this.bremap.ClickOnAddons.Click();
           Thread.Sleep(4000);
           this.bremap.ClickOnAddons.Click();
           Thread.Sleep(1000);
           this.bremap.ClickOnAddons_48Hrs_CutOff.Click();
           SelectDayOfWeektoApply48Hours();
           Thread.Sleep(2000);
           this.bremap.CLickOnOfficeHours_ExtendedOfficeHours.Click();
           Thread.Sleep(2000);
           this.bremap.AllowBookingOnHolidaysAndWeekends.Click();
           Thread.Sleep(1000);
           this.bremap.AllowBookingOnHolidaysAndWeekends_Yes.Click();
           this.bremap.UpdateCurrentSettings.Click();
    }


       public IWebDriver browser { get; set; }
    }
}
