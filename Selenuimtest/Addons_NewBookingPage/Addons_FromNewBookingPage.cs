//using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using System.Configuration;

namespace UnitTestProjectsummary.Addons_NewBookingPage
{
   public class Addons_FromNewBookingPage
    {
       private readonly string addon1 = ConfigurationSettings.AppSettings["Addon1"];
       private readonly string addon2 = ConfigurationSettings.AppSettings["Addon2"];
       private readonly string addon3 = ConfigurationSettings.AppSettings["Addon3"];
       private readonly string addon4 = ConfigurationSettings.AppSettings["AddonNameA"];
       
       private readonly string AddonnameForNotification = ConfigurationSettings.AppSettings["AddonNameForNotificationCheck"];
       private readonly string AddonNameForStock = ConfigurationSettings.AppSettings["AddonNaME"];


       public Addons_FromNewBookingPage(IWebDriver browser)
       { 
           this.browser = browser;
       }

       public Addons_FromNewBookingPage()
        {
       }
       public AddonsCreateBookingPageElements AddonMapBooking
       {
           get
           {
               return new AddonsCreateBookingPageElements(this.browser);
           }
       }
       public void CliCkOnAddAddon_FromBookingSummary()
       {
           this.AddonMapBooking.BookingSummaryClickOnAddAddon.Click();

       }
       public void GetAllAddonTextFromDifferentCatagory()
       {

           IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.ClassName("fieldset_addons"));
           IList<IWebElement> all = new List<IWebElement>(ec);
           foreach (var item in all)
           {
               Console.WriteLine(item.Text);
               Console.WriteLine("\n");
           }
       }

       public void GetallAddedAddonName()
       { 
              IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.XPath("//*[@id='divAddOnCont']"));
           IList<IWebElement> all = new List<IWebElement>(ec);
           foreach (var item in all)
           {
               Console.WriteLine("Addons are:-"+item.Text);
       }}
       public void AddAddon_Cake_BySearch()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys(AddonnameForNotification);
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void add_addon_Bread_VerifyStock()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys(AddonNameForStock);
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT256_add_addon_Milk()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys(addon1);
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT256_add_addon_Juice()
       {
           this.AddonMapBooking.Add_AddonForSearch.Clear();
           this.AddonMapBooking.Add_AddonForSearch.SendKeys(addon2);
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT256_add_addon_Tea()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys(addon3);
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT_263_Add_addon_CheeseTray()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys(addon4);
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void AddonQuantity5()
       {
           //Actions action = new Actions(browser);
           //action.MoveToElement(this.AddonMapBooking.AddonQuantity);
           //action.Click().DoubleClick();
           //action.SendKeys("5");

           this.AddonMapBooking.AddonQuantity.Clear();
           Thread.Sleep(2000);
           this.AddonMapBooking.AddonQuantity.SendKeys("5");
       }
       public void EditAddon()
       {
           this.AddonMapBooking.clickOnEditAddonQuantity.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.UpdateNewAddonQuantity.Clear();
           this.AddonMapBooking.UpdateNewAddonQuantity.SendKeys("3");
           Thread.Sleep(1000);
           this.AddonMapBooking.ClickOnSaveUpdatedAddon.Click();

       }

       public void AddonQuantity3()
       {
           this.AddonMapBooking.AddonQuantity.Clear();
           Thread.Sleep(2000);
           this.AddonMapBooking.AddonQuantity.SendKeys("3");
       }
       public void AcceptAddonNotificationMessageAndGetHeaderText()
       {
           var ssg=this.AddonMapBooking.GetAddonNotificationMessageHeader.Text;
           Console.WriteLine("Addon Notification Message Header Is=" + ssg);
           Thread.Sleep(2000);
           this.AddonMapBooking.AcceptAddonNotificationMessage.Click();
       }
       
       public void ClickOnAddAddonButton()
       {
           this.AddonMapBooking.AddSelectedAddons.Click();
       }
       public void VerifyAddAddonButtonIsEnabled()
       { 
           IWebElement AddButton=this.AddonMapBooking.AddSelectedAddons;
           Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(AddButton.Enabled);
       }

       public void GetAddedAddonName()
       {
           var addonname = this.AddonMapBooking.VerifyAddedAddonName.Text;
           Console.WriteLine("AddonName= " + addonname);
       }

       public void SummaryButtonFromAddonPageIsEnabled()
       {
           Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(this.AddonMapBooking.GoToSummaryFromAddons.Enabled);
       }
       public void clickOnGoToSummaryFromAddonPage()
       {
           this.AddonMapBooking.GoToSummaryFromAddons.Click();
       }

       public void verfiy_AddonCuttOffMessage_Enabled()
       {
          Assert.IsTrue(this.AddonMapBooking.VerifyAddonCutt_Message.Displayed);
       }

       public void HandleAddonPopUPByIfElse()
       {
               Thread.Sleep(5000);
               if (this.AddonMapBooking.VerifyAddonCutt_Message.Enabled)
               {
                   Thread.Sleep(3000);
                   this.AddonMapBooking.VerifyAddonCutt_Message.Click();
               }
               else {
               Console.WriteLine("No Pop Up is displayed Processing further");
               }
       }

       public void handlePopUpByTryCatch()
       {
           try
           {
               if (this.AddonMapBooking.VerifyAddonCutt_Message.Enabled)
               {
                   Thread.Sleep(3000);
                   this.AddonMapBooking.VerifyAddonCutt_Message.Click();
               }
           }
           catch (NoSuchElementException) { }

       
       }
       public void VerifyAddedAddon()
       {
            Thread.Sleep(2000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='divAddOnCont']"));
            Thread.Sleep(4000);
            Assert.IsTrue(this.AddonMapBooking.VerifyAddedAddonName.Enabled);
       }

       public void VerifyAddonShouldNotAdded()
       {
           Thread.Sleep(2000);
            Thread.Sleep(2000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='divAddOnCont']"));
            Thread.Sleep(4000);
            IWebElement namei = browser.FindElement(By.XPath("//*[@id='ShTBLNo0']/tbody/tr/td/table[1]/tbody/tr[1]/td[3]/table"));
            if (browser.FindElements(By.XPath("//*[@id='ShTBLNo0']/tbody/tr/td/table[1]/tbody/tr[1]/td[3]/table")).Count != 0)
            {
                this.AddonMapBooking.BookingSummaryClickOnAddAddon.Click();
            }
            else
            {
                Console.WriteLine("Elementis not present Test Passed");
            }
       }








       public IWebDriver browser { get; set; }

       
    }
}
