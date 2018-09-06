using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;
//using MFPOMProject.PageObjects;

namespace UnitTestProjectsummary.AllModules
{
   public class Services
    {
       private IWebDriver driver;
       public Services(IWebDriver driver)
       {
           this.driver = driver;
       }

       protected ServiceReferences Map
       {
           get
           {
               return new ServiceReferences(this.driver);
           }
       }

       public void NavigateAndLogin()
       {
           this.driver.Navigate().GoToUrl("http://nfs-devapp/AonV63");
           driver.FindElement(By.Id("btnOk")).Click();
           this.Map.UserNameInfo2.SendKeys("admin7");
           Thread.Sleep(2000);
           this.Map.PasswordInfo2.SendKeys("admin7");
           Thread.Sleep(2000);
           this.Map.SubmitButton2.Click();
       }

       public void ClickServicesModule()
       {
           Thread.Sleep(3000);
           this.Map.ServiceModuleIcon.Click();
           Thread.Sleep(3000);
       }

       public void EnterReferenceNumber()
       {
           Services Browser = new Services(this.driver);
           Browser.ClickServicesModule();
           this.Map.FindAddonsByReferenceNumber.SendKeys("M9599");
           this.Map.ClickSearchButton.Click();
           Thread.Sleep(3000);
// Assert.IsTrue(this.Map.Quantity.Displayed);
           Thread.Sleep(2000);
       }
       public void checkForNotesEnabled()
       {
           Assert.IsTrue(this.Map.ServiceNotes.Displayed);
       }

       public void EnterBookingtitle()
       {
           Services Browser = new Services(this.driver);
           Browser.ClickServicesModule();
           this.Map.FindAddonsByBookingTitle.SendKeys("MFTest");
           this.Map.ClickSearchButton.Click();

       }

       public void ApproveAddon()
       {
           Services Browser = new Services(this.driver);
           Browser.ApproveAddon();
       }

       public void ClickPropertyDropDown()
       {
           Thread.Sleep(5000);
           this.Map.ServiceModuleIcon.Click();
           var drop = driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_cmbProperties_cmbList_Input"));
           drop.Click();
           Thread.Sleep(3000);
           var SelectElement = new SelectElement(drop);
           Thread.Sleep(3000);
           SelectElement.SelectByText("Calgary");
           Thread.Sleep(3000);
           
       }

       public void ClickOnServiceNotes()
       {

          // LoginMethods Browser = new LoginMethods(this.driver);
           //Browser.NavigateTo();
          // Browser.SuccessFulLogin();
           Thread.Sleep(4000);
           this.Map.ServiceModuleIcon.Click();
           this.Map.ServiceNotes.Click();
           Thread.Sleep(3000);
           this.Map.NotesTextArea.Clear();
           this.Map.NotesTextArea.SendKeys("Test Notes Please ignore");
           this.Map.ServiceNotesSaveButton.Click();
           Thread.Sleep(2000);

       }

       public void TodayDateVerification()
       {
           Services Browser = new Services(this.driver);
          // Browser.NavigateAndLogin();
           Thread.Sleep(3000);
           this.Map.ServiceModuleIcon.Click();
           Thread.Sleep(2000);
           this.Map.ClickOnNextDayArrow.Click();
           Thread.Sleep(2000);
           this.Map.ClickOnTodayDate.Click();

       }

    public void DropDownSelection()
       {
           Services Browser = new Services(this.driver);
           //Browser.NavigateAndLogin();
           Thread.Sleep(3000);
           this.Map.ServiceModuleIcon.Click();
           var depDropDown = this.Map.DepartmentDropDown;
           this.Map.DepartmentDropDown.Click();
           var SelectElement = new SelectElement(depDropDown);
           SelectElement.SelectByIndex(2);
        
       }

    }

   
}