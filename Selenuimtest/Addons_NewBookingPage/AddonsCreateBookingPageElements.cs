using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Addons_NewBookingPage
{
    public class AddonsCreateBookingPageElements
    {
         private readonly IWebDriver browser;
         public AddonsCreateBookingPageElements(IWebDriver browser)
        {
            this.browser = browser;
        }
        public AddonsCreateBookingPageElements()
         { 
         }
       

        //Click on Add Addon From Booking Summary Page
        public IWebElement BookingSummaryClickOnAddAddon
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_grdSummary_ctl00_ctl04_tblWizardSteps']/tbody/tr[1]/td"));

            }
        }

        //ENter AddonSearchTextBox For Search
        public IWebElement Add_AddonForSearch
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ctl00_txtSearch']"));

            }
        }

        //CLick On Addon Search Button
        public IWebElement CLickOnAddonSearchButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ctl00_btnSearchIn']"));

            }
        }

        public IWebElement SelectFirstAddon_AddonSearch_Cake
        {
            get
            {
                //return this.browser.FindElement(By.XPath("//*[@id='chk?88da304d-aacc-4f29-964c-5f8bac94fa33?Cake / Gâteau?0']"));
                return this.browser.FindElement(By.XPath("//*[@type='checkbox']"));

            }
        }

        public IWebElement AcceptAddonNotificationMessage
        {
            get
            {
                return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$ctl00$rdAddonNotification$C$ctl00"));
            }
        }
        
        public IWebElement GetAddonNotificationMessageHeader
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='RadWindowWrapper_ctl00_MainContentPlaceHolder_ctl00_rdAddonNotification']/table/tbody/tr[1]/td[2]/table/tbody/tr/td[2]/em"));
            }
        }
        public IWebElement AddSelectedAddons
        {
            get
            {
                return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$ctl00$btnAdd"));

            }
        }
        public IWebElement VerifyAddedAddonName
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='ShTBLNo0']/tbody/tr/td/table[1]/tbody/tr[1]/td[3]/table"));
            }
        }

        public IWebElement GetAllAddonsDum
        {
            get
            {
                return this.browser.FindElement(By.Name("fieldset_addons"));
            }
        }
        public IWebElement GoToSummaryFromAddons
        {
            get
            {
                return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$btnSaveAndGoToSummary"));
            }
        }
        public IWebElement AddonQuantity
        {
            get
            {
               return this.browser.FindElement(By.XPath("//*[@id='txt_24465133-d742-4ee8-a66d-2828245bef6f_0'][@class='ui-spinner-input']"));

                //return this.browser.FindElement(By.Name("txt_24465133-d742-4ee8-a66d-2828245bef6f_0"));

            }
        }
        public IWebElement clickOnEditAddonQuantity
        {
            get { 

            return this.browser.FindElement(By.XPath("//*[@type='image']"));
            }
        }
        public IWebElement UpdateNewAddonQuantity
        {
            get
            {

                return this.browser.FindElement(By.XPath("//*[@id='lblQunt']"));
            }
        }
        public IWebElement ClickOnSaveUpdatedAddon
        {
            get
            {

                return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ctl00_btnSave']"));
            }
        }
        public IWebElement VerifyAddonCutt_Message
        {
            get
            {

                return this.browser.FindElement(By.XPath("/html/body/div[3]/div[3]/div/button/span"));
            }
        }

        public IWebElement VerifyAddedAddon
        {
            get
            {

                return this.browser.FindElement(By.XPath("//*[@id='divAddOnCont']"));
            }
        }

        public IWebElement CheckEditadoonIcon
        {
            get
            {

                return this.browser.FindElement(By.XPath("//*[@id='imgTime_1bb55e87-48ec-4c27-89cc-7816c7d29965']"));
            }
        }

















    }
}
