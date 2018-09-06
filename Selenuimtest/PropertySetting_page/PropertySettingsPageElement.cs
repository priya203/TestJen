using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.PropertySetting_page
{
   public class PropertySettingsPageElement
    {
        private readonly IWebDriver browser;
         public PropertySettingsPageElement(IWebDriver browser)
        {
            this.browser = browser;
        }
         public PropertySettingsPageElement()
         { 
         }

         public IWebElement NavigatetoAdministration
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='adminSpan']"));

             }
         }
         public IWebElement Navigateto_Settings
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_lblSettings']"));

             }
         }
         public IWebElement Navigateto_PropertySettings
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_subLblPropertySettings']"));

             }
         }
         public IWebElement SelectProperty_Dropedown
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddlProperty']"));

             }
         }
         public IWebElement AddOn_CutOff_Time
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtCutOff_dateInput']"));

             }
         }
    
         public IWebElement AddOn_CutOff_Hours
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtCutOffHours']"));

             }
         }
         public IWebElement AddOn_NoticePeriod
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtAddonNoticePeriod']"));

             }
         }
         public IWebElement ClickOnUpdateSettings
         {
             get {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnSave']"));
             
             }
         }
        
    }
}
