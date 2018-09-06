using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal; 
//using WorkspaceProject.Login;
using WorkspaceProject;
 

namespace WorkspaceProject.Modules
{
   public class AddNewVisitorMethods
    {
       private IWebDriver driver;
       private readonly string ExtVisitlastname = ConfigurationSettings.AppSettings["ExternalVisitorLastName"];
       private readonly string ExtVisitFirstname = ConfigurationSettings.AppSettings["ExternalVisitorFirstName"];
       private readonly string HostName = ConfigurationSettings.AppSettings["ExternalVisitorhosttName"];

       private readonly string IntVisitlastname = ConfigurationSettings.AppSettings["InternalVisitlastname"];
       private readonly string InternalVisitFirstname = ConfigurationSettings.AppSettings["InternalVisitorsFirstname"];

       public AddNewVisitorMethods(IWebDriver driver)
       {
           this.driver = driver; 
       }
       //mapping references from Add new Visitor References
       protected AddNewVisitorReferences Map
       {
           get
           
           {
               return new AddNewVisitorReferences(this.driver);
           }
       }
       //login in and clicking on the Add New Visitor button

       public void AccessingNewVisitorsPage()
       {
           VisitorPageMethods browser = new VisitorPageMethods(this.driver); 
          
           browser.AccessingVisitorsTab();
           this.Map.AddNewVisitorbuttn.Click();
           Thread.Sleep(4000); 
       }
   
       //clicking on the external option
       public void ClickExternalOption()
       {
           this.Map.ExternalOption.Click();
           Thread.Sleep(5000);
       }

       public void ClickonInternalVisitor()
       {

           this.Map.clickonInternalVisitor.Click();
       }

       //selecting from the last name drropdown
       public void AddLastName()
       {


           this.Map.LastNameTextbox.SendKeys(ExtVisitlastname);
           Thread.Sleep(1000);
           driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchContacts_Input")).SendKeys(Keys.ArrowDown);
           Thread.Sleep(1000);
           driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchContacts_Input")).SendKeys(Keys.Enter);
       }
       public void AddLastNameForInternalVisitor()
       {
            this.Map.LastNameTextbox.SendKeys(IntVisitlastname);
           Thread.Sleep(1000);
           driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchContacts_Input")).SendKeys(Keys.ArrowDown);
           Thread.Sleep(1000);
           driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSearchContacts_Input")).SendKeys(Keys.Enter); }

       public void addFirstName()
       {
           this.Map.FirstName.SendKeys(ExtVisitFirstname);
           Thread.Sleep(2000);
       }

       public void addFirstNameForInternalVisitor()
       {
           this.Map.FirstName.SendKeys(InternalVisitFirstname);
           Thread.Sleep(2000);
       }


       public void 
           addHoatName()
       {
           this.Map.HostName.SendKeys(HostName);
           Thread.Sleep(2000);
           driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdHostName_Input")).SendKeys(Keys.ArrowDown);
           Thread.Sleep(2000);
           driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdHostName_Input")).SendKeys(Keys.Enter); 
       }
       public void DisplayNameClick1()
       {
           this.Map.DisplayName.Click();

       }

   //selecting a title
       public void AddTitle()
       
       {
           /*var drop = this.Map.Title;
           drop.Click(); 
           Thread.Sleep(3000); 
           var SelectElement = new SelectElement(drop); 
           Thread.Sleep(3000); 
           SelectElement.SelectByIndex(0);
           Thread.Sleep(6000); */
           AddNewVisitorReferences browser = new AddNewVisitorReferences(this.driver);
           var SelectVisitorTitle = this.Map.Title;
           this.Map.Title.Click();
           var SelectElement = new SelectElement(SelectVisitorTitle);
           SelectElement.SelectByIndex(3); 
           
       }

          //clicking on the Display NAme
       public void ClickontheDispalyName()
       {
           this.Map.DisplayName.Click();
           Thread.Sleep(5000);
       }

       //clciking on teh Host Name 
       public void ClickontheHostName()
       {
           this.Map.HostName.Click(); 
       }

       //adding a host name
       public void AddaHostName()
       {
       
           this.Map.HostName.SendKeys("Odeta");
           Thread.Sleep(2000);
           driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdHostName_Input")).SendKeys(Keys.ArrowDown);
        Thread.Sleep(2000);
        driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdHostName_Input")).SendKeys(Keys.Enter); 
       }
           //checking on teh Visitors checkbox
           public void ArriveVisitorsCheckbox()
           {
               this.Map.ArrivalTime.Click();
           }
       //Printing the badge
      
       public void ClickonPrintBadge()
           {
               this.Map.PrintBadgeBttn.Click(); 
           }

       //clicking on OK 
       public void ClickonOK()
       {
           this.Map.ClickOnOK.Click(); 
       }
       //clcicking on the Save Button
       public void ClickSaveButton()
       {
           this.Map.SaveButtn.Click();
           Thread.Sleep(5000);
       }
       //clicking on Host Not found 
       public void HostNotFound()
       {
           this.Map.HostNotFound.Click();
       }
      
        //switching on teh Host Not Found pop up

       public void HostNotFPop()
       {
         AddNewVisitorMethods browser = new AddNewVisitorMethods(this.driver); 
         IWebElement HostFrame = this.Map.HostNotFoundPop;
          driver.SwitchTo().Frame(HostFrame);
           browser.LastNameHstntFound(); 
           Thread.Sleep(4000);
          browser.AddComanyHst();
          Thread.Sleep(3000);
          browser.SaveButton1();
          Thread.Sleep(3000);
          driver.SwitchTo().DefaultContent(); 
       }


       //Adding a Host added through teh Active Directory using Host not found
       public void LastNameHstntFound()
       {
           AddNewVisitorReferences browser = new AddNewVisitorReferences(this.driver); 
           browser.LastNameHstntFound.Click();
           Thread.Sleep(4000); 
           //this.Map.LastNameHstntFound.Click();
           browser.LastNameHstntFound.SendKeys("Test1"); 
           //this.Map.LastNameHstntFound.SendKeys("Test1");
           Thread.Sleep(4000);
           driver.FindElement(By.Id("ddlSearchContacts1_Input")).SendKeys(Keys.ArrowDown);
           Thread.Sleep(2000);
           driver.FindElement(By.Id("ddlSearchContacts1_Input")).SendKeys(Keys.Enter); 

       }

       //select the Company from Host nOt found
       public void AddComanyHst()
       {
           AddNewVisitorReferences browser = new AddNewVisitorReferences(this.driver);
           var SelectComanyName = this.Map.Company;
           this.Map.Company.Click();
           var SelectElement = new SelectElement(SelectComanyName);
           SelectElement.SelectByIndex(1); 
            

       }
       //Clicking on teh Save Button1
       public void SaveButton1()
       {
           this.Map.Savebttn1.Click(); 
       }


       //public string InternalVisitFirstname { get; set; }
    }
    }


