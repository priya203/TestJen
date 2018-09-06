using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Addons_ResourceManagement
{
    public class AddonPageElements
    {
         private readonly IWebDriver browser;
         public AddonPageElements(IWebDriver browser)
        {
            this.browser = browser;
        }
         public AddonPageElements()
         { 
         }
         public IWebElement NavigatetoAdministration
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='adminSpan']"));

             }
         }
         public IWebElement ClickOnResouceManagementICon
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_Label1']"));

             }
         }
         public IWebElement ClickOnAddonIcon
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_subLblAddons']"));

             }
         }
         public IWebElement AddonNameSearchTextBox
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00_ctl02_ctl02_FilterTextBox_DisplayName']"));

             }
         }
         public IWebElement PropertyNameSearchTextBox
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00_ctl02_ctl02_FilterTextBox_PropertyName']"));

             }
         }
         public IWebElement SelectFirstRecordFromSearchResult
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdList_ctl00__0']/td[2]/a"));

             }
         }
//Edit Addon Page
         public IWebElement Set_AddonNotification_Yes
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdbAddOnNotification_0"));

             }
         }
         public IWebElement Set_AddonNotification_No
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdbAddOnNotification_1"));

             }
         }
         public IWebElement Enter_AddonNotes
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtNote"));

             }
         }
         public IWebElement SaveAddon
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_btnSaveTop']"));

             }
         }
         public IWebElement StockType
         {
             get
             {
                 return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$ddlStockType"));

             }
         }
         public IWebElement TotalNoofAddons
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtStock_wrapper']"));

             }
         }
         public IWebElement MaximumAddOnperBooking
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtMax_wrapper']"));

             }
         }
         public IWebElement QuantityDeductedfromtheTotalAddons
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtUnit_wrapper']"));

             }
         }
         public IWebElement BookingCutOffPeriod
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtCutOffPeriod']"));

             }
         }
         public IWebElement BookingCutOffTimepopUP
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtCutOffTime_timePopupLink']"));

             }
         }
         public IWebElement CutOFfTime_TextField
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtCutOffTime_dateInput']"));

             }
             
             //*[@id='ctl00_MainContentPlaceHolder_dtCutOffTime_dateInput']
         }
         public IWebElement BookingCutOffTime_3PM
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtCutOffTime_timeView_tdl']/tbody/tr[12]/td[1]/a"));

             }
         }
         public IWebElement BookingCutOffTime_12PM
         {
             get
             {
                 return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_dtCutOffTime_timeView_tdl']/tbody/tr[10]/td[1]/a"));

             }
         }
         public IWebElement Add48_HoursWeekend_Yes
         {
             get { return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_rbtnWeekendAddCutOffHoursYes']"));
             } 
         }

      

      }
}
