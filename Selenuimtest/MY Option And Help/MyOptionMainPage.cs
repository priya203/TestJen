
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProjectsummary.PageElements;

namespace UnitTestProjectsummary.MY_Option
{
    public class MyOptionMainPage
    {
         private readonly string DisplayName = ConfigurationSettings.AppSettings["UpdatedDisplayNameForUser"];
         private readonly string Builddate = ConfigurationSettings.AppSettings["BuildDate"];
         private readonly string buildVersion = ConfigurationSettings.AppSettings["BuildVersion"];
         private readonly string updateProperty = ConfigurationSettings.AppSettings["PrimaryProperty"];
         private readonly string revertproperty = ConfigurationSettings.AppSettings["revertprimaryProperty"];

      
          public MyOptionMainPage(IWebDriver browser)
          {
            this.browser = browser;
         }
          public MyOptionMainPage()
         { }

          protected MyOptionPageElements Map1
            {
            get
            {

                return new MyOptionPageElements(this.browser);
            }
            }
          public void myoptionNavigations()
          {
              this.Map1.MyOptionButton.Click();
          }
        public void GetDisplayNameOfUser()
          {
              this.Map1.MyOptionButton.Click();
              WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
              wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_MainContentPlaceHolder_txtDisplayName")));
              IWebElement DisplayName1 = browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtDisplayName']"));
              String name = DisplayName1.GetAttribute("Value");
              //Console.WriteLine(name);
            }

        public void getDisplayNameAndVerifyItForLoogedInUser()
        {
            this.Map1.MyOptionButton.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_MainContentPlaceHolder_txtDisplayName")));
            IWebElement DisplayName1 = browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_txtDisplayName']"));
            String nameopt = DisplayName1.GetAttribute("Value");

            IWebElement LoogedInUsername = browser.FindElement(By.XPath("//*[@id='ctl00_lblLogin']"));
            String Nameusr = LoogedInUsername.Text;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(nameopt.Equals(Nameusr),"Assert False as Name Doesnt Match");
        }
        public void modifyDisplayName()
    {
           this.Map1.MyOptionButton.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_MainContentPlaceHolder_txtDisplayName")));
            this.Map1.DisplayName.Clear();
            this.Map1.DisplayName.SendKeys(DisplayName);
            this.Map1.SaveButton.Click();
    }
        public void VeriyVersionAndBuildDate()
        {
            this.Map1.HelpPageNavigation.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_lblAbout']")));
            this.Map1.AboutOption.Click();
            String version = this.Map1.Version.Text;
            Console.WriteLine(version);
            Assert.IsTrue(version.Equals(buildVersion), "Build Version Doesnt Match");


            String Date = this.Map1.BuildDate.Text;
            Console.WriteLine(Date);
            Assert.IsTrue(Date.Equals(Builddate), "Build Date Doesnt Match");
        }

        public void CheckUsTimeFOrmat()
        {
            this.Map1.MyOptionButton.Click();
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_MainContentPlaceHolder_txtDisplayName")));
            IWebElement LanguageP=browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_ddlLanguagePreferences']"));
            SelectElement sel = new SelectElement(LanguageP);
            Thread.Sleep(3000);
            LanguageP.Click();
            Thread.Sleep(3000);
            sel.SelectByText("English (United States)");
            this.Map1.SaveButton.Click();
        }
 public void PrimaryPropertyModification()
     {
         try
         {
             this.Map1.MyOptionButton.Click();
             WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
             wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_MainContentPlaceHolder_txtDisplayName")));

             var SelectElement = new SelectElement(this.Map1.PrimaryProperty);
             String ssg = SelectElement.SelectedOption.Text;
             Console.WriteLine(ssg);
             SelectElement.SelectByText(updateProperty);
             this.Map1.SaveButton.Click();
             Thread.Sleep(3000);
             Console.WriteLine("Upated Property Name" + updateProperty);
             IWebElement logout = browser.FindElement(By.XPath("//*[@id='ctl00_lblLogout']"));
             logout.Click();
             Thread.Sleep(3000);
             browser.FindElement(By.XPath("//*[@id='btRelogin']")).Click();

             WebDriverWait waitt = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
             waitt.Until(ExpectedConditions.ElementIsVisible(By.Id("loginMain_UserName")));
         }
         catch (Exception ex)
         {
             throw ex;
         } 
     }

 public void VerifyNamesAreModifeidCorrecltlyOnAllPages()
 {
     
     WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
     wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='lblPropertyOrTimeZone0']")));
     IWebElement primProperty = browser.FindElement(By.XPath("//*[@id='lblPropertyOrTimeZone0']"));
     String NameP = primProperty.Text;
     Console.WriteLine(NameP);
     Assert.IsTrue(updateProperty.Equals(NameP), "Assert Fail Due TO mismatch in property");
 }
 public void RevertPrimaryPropertyChanges()
 {
     this.Map1.MyOptionButton.Click();
     WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
     wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_MainContentPlaceHolder_txtDisplayName")));

     var SelectElement = new SelectElement(this.Map1.PrimaryProperty);
    // String ssg = SelectElement.SelectedOption.Text;
     //Console.WriteLine(ssg);
     SelectElement.SelectByText(revertproperty);
     this.Map1.SaveButton.Click();
    // IWebElement logout = browser.FindElement(By.XPath("//*[@id='ctl00_lblLogout']"));
     //logout.Click();
 }



      



          public IWebDriver browser { get; set; }




    }
}
