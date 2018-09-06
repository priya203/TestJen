using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.BRE
{
   public class BREPageElements
    {
        private IWebDriver webDriver;
        private readonly IWebDriver browser;
       public BREPageElements(IWebDriver browser)
       {
           this.browser = browser;
       }

       public BREPageElements()
        {
            // TODO: Complete member initialization
        }

       public IWebElement AdministrationLink
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id='adminSpan']"));
           }
       }
          public IWebElement SettingLink
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id='ctl00_lblSettings']"));
           }
       }
          public IWebElement BRELink
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_subLblBusinessRuleSettings']"));
              }
          }
          public IWebElement SelectProperty_Toronto
          {
              get
              {
                  //return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddlProperty_Arrow']"));
                  //*[@id='ctl00_MainContentPlaceHolder_ddlProperty']/table[1]/tbody[1]/tr[1]/td[1]
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddlProperty_Input']"));
              }
          }
          public IWebElement ClickOnAddons
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pnlBRESettings']/ul/li[2]/a/span/span[2]"));
              }
          }
          public IWebElement ClickOnAddons_48Hrs_CutOff
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pnlBRESettings']/ul/li[2]/div/ul/li[2]/a/span/span[2]"));
              }
          }
          public IWebElement Select48_hoursWeekendDropedown_Friday
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddl48HoursCutoffRuleDays']"));
              }
          }
          public IWebElement CLickOnOfficeHours_ExtendedOfficeHours
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pnlBRESettings']/ul/li[6]/a/span/span[2]"));
              }
          }
          public IWebElement AllowBookingOnHolidaysAndWeekends
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pnlBRESettings']/ul/li[6]/div/ul/li[4]/a/span/span[2]"));
              }
          }
          public IWebElement AllowBookingOnHolidaysAndWeekends_Yes
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_rbtnHolidayWeekEndYes']"));
              }
          }
          public IWebElement UpdateCurrentSettings
          {
              get
              {
                  return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnUpdateCurrentSettings']"));
              }
          }
















    }
}
