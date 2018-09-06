using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Deparments
{
    public class DeparmentPageElement
    {

        private readonly IWebDriver browser;
        public DeparmentPageElement(IWebDriver browser)
        {
            this.browser = browser;
        }

         public IWebElement Adminstration
         {
             get {
                 return this.browser.FindElement(By.XPath("//*[@id='adminSpan']"));
             }
         }
         public IWebElement Deptnavigation
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_subLblDepartments']"));
             }
         }
         public IWebElement departementName
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00_ctl02_ctl02_FilterTextBox_DepartmentName']"));
             }
         }

           public IWebElement PropertyName
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00_ctl02_ctl02_FilterTextBox_PropertyName']"));
             }
         }
       
             public IWebElement SelectFirstElementfromsearchresults
           {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00__0']/td[2]"));
             }
           }

             public IWebElement AddonNotificationyes
             {
                 get
                 {
                     return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_rdbAddonNotificationList_0']"));
                 }
             }
             public IWebElement AddonNotificationno
             {
                 get
                 {
                     return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_rdbAddonNotificationList_1']"));
                     //*[@id="ctl00_MainContentPlaceHolder_rdbAddonNotificationList_0"]
                 }
             }

             public IWebElement AddonNotificationMessage
             {
                 get
                 {
                     return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtAddonMessage']"));
                 }
             }
             public IWebElement ClickOnsaveButton
             {
                 get
                 {
                     return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnSave']"));
                 }
             }

            
    }
}
