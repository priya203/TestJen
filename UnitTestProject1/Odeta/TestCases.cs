using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.IE;
using System.Threading;
using WorkspaceProject;
//using WorkspaceProject.Login;
using WorkspaceProject.Modules;
using System.Configuration;
using UnitTestProjectsummary.Login;
using UnitTestProjectsummary.PageElements;




namespace UnitTestProjectsummary
{
    [TestClass]
    public class OD_TestCases
    {
        public IWebDriver Driver;

        [TestInitialize]
        public void LaunchIE()
        {
            this.Driver=new ChromeDriver("E:\\Sel\\GetDock_driver\\chromedriver");
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            //this.driver = new Chromedriver(@"E:\Sel\GetDock_driver\chromedriver");
        }
       
        [TestCategory("Login")]
        [TestMethod]
        public void OD_SuccessFulLoginTest()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(4000);
        }
        

        [TestCategory("VisitorPageMethods")]
        [TestMethod] //Login, and Access Visitors Module
        public void OD_AccessingVisitorsTabW()

        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(4000);
            VisitorPageMethods visit = new VisitorPageMethods(this.Driver);
            visit.AccessingVisitorsTab();
            Thread.Sleep(3000);
            Assert.IsTrue(Driver.FindElement(By.Id("ctl00_subLblVisitor")).Displayed);
            
           
        }

        [TestCategory("VisitorPageMethods")]
        [TestMethod] //Login, and Access Visitors Module, Add a name and Search
        public void OD_AccessingVisitorsTW()

        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(4000);
            VisitorPageMethods visit = new VisitorPageMethods(this.Driver);
            visit.AccessingVisitorsTab();
        }
        


    [TestCategory("VisitorPageMethods")]
    [TestMethod]//login, Access Visitors Module, Click on Hide Internals and click on Search
        
    public void OD_SearchforaVisitorW()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(4000);
         VisitorPageMethods browser = new VisitorPageMethods(this.Driver);
         browser.AccessingVisitorsTab();
        Assert.IsTrue(Driver.FindElement(By.Id("ctl00_aVisitorManagement")).Displayed);
        Thread.Sleep(1000);
        browser.HideInternals();
        Thread.Sleep(2000);
        browser.Searchbutton();
        Thread.Sleep(1000);
        }
        

        public void CheckTodayDate()
        {
            IWebElement date = Driver.FindElement(By.Id("ctl00$MainContentPlaceHolder$rdpStartDate$dateInput"));
            String DateT = date.GetAttribute("value");
            Console.WriteLine(DateT);
            Assert.IsTrue(DateT.Equals("20/02/2018"),("Your current date matches"));
        }
   
    [TestCategory("VisitorPageMethods")]
    [TestMethod]//login, Access Visitors Module, searching for an existing Visitor, and Print Badge

    public void OD_SearchforanExisitingVisitorW()
    {
        LoginMainPage logint = new LoginMainPage(this.Driver);
        logint.Navigate();
        logint.Login();
        Thread.Sleep(4000);
        VisitorPageMethods browser = new VisitorPageMethods(this.Driver);
        browser.AccessingVisitorsTab();
        Assert.IsTrue(Driver.FindElement(By.Id("ctl00_aVisitorManagement")).Displayed);
        Thread.Sleep(1000);
        browser.AddingVisitor();
        Thread.Sleep(1000);
        browser.HideInternals();
        Thread.Sleep(1000);
        browser.Searchbutton();
        Thread.Sleep(1000);
        
    }
        
    [TestCategory("VisitorPageMethods")]
   [TestMethod] //login, Access Visitors Module, serching for a cancelled visistor. 

    public void OD_SearchforaCancelledVisitorW()

    {
        LoginMainPage logint = new LoginMainPage(this.Driver);
        logint.Navigate();
        logint.Login();
        Thread.Sleep(4000);
        VisitorPageMethods browser = new VisitorPageMethods(this.Driver);
        browser.AccessingVisitorsTab();
        Thread.Sleep(1000);
        Assert.IsTrue(Driver.FindElement(By.Id("ctl00_aVisitorManagement")).Displayed);
        Thread.Sleep(1000);
        browser.HideInternals();
        Thread.Sleep(1000);
        browser.CancelVisitorCheckbox();
        Thread.Sleep(1000);
        browser.Searchbutton();
        Thread.Sleep(1000);
    }
    //[ TestCategory("AddNewVisitorMethods")]
    //[TestMethod]//login,going to the Visitors page,clcikcing on the Add Visitor and add a visitor
   [TestMethod]

    public void OD_AddingaVisitorExternalW()
    {

        LoginMainPage logint = new LoginMainPage(this.Driver);
        logint.Navigate();
        logint.Login();
        Thread.Sleep(4000);
       
       AddNewVisitorMethods AddVisit = new AddNewVisitorMethods(this.Driver);
       AddVisit.AccessingNewVisitorsPage();
       AddVisit.ClickExternalOption();
       AddVisit.AddLastName();
       AddVisit.addFirstName();
       AddVisit.ClickontheDispalyName();

       AddVisit.addHoatName();
       

        Thread.Sleep(2000);
        AddVisit.AddTitle();
        Thread.Sleep(1000);
       // AddVisit.AddaHostName();
       AddVisit.ClickSaveButton();
        Assert.IsTrue(Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_lblSuccessMessage")).Displayed); 
         
    }
 [TestMethod]
   public void OD_AddingaVisitorInternalW()
   {

       LoginMainPage logint = new LoginMainPage(this.Driver);
       logint.Navigate();
       logint.Login();
       Thread.Sleep(4000);

       AddNewVisitorMethods AddVisit = new AddNewVisitorMethods(this.Driver);
       AddVisit.AccessingNewVisitorsPage();
       Thread.Sleep(2000);

       AddVisit.ClickonInternalVisitor();
       Thread.Sleep(2000);
       AddVisit.AddLastNameForInternalVisitor();
       Thread.Sleep(2000);
       AddVisit.addFirstNameForInternalVisitor();
       AddVisit.ClickontheDispalyName();

       AddVisit.addHoatName();


       Thread.Sleep(2000);
       AddVisit.AddTitle();
       Thread.Sleep(1000);
       // AddVisit.AddaHostName();
        AddVisit.ClickSaveButton();
        Thread.Sleep(3000);
        Assert.IsTrue(Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_lblSuccessMessage")).Displayed);

   }



        
    //Test Category AddNew Visitor Methods
        //   Test Method - login,going to the Visitors page,clcikcing on the Add Visitor and add a visitor and arrive the visitor
  [TestMethod]
   public void OD_ArrivingVisitor()
   {

       LoginMainPage logint = new LoginMainPage(this.Driver);
       logint.Navigate();
       logint.Login();
       Thread.Sleep(4000);
       
       AddNewVisitorMethods browser = new AddNewVisitorMethods(this.Driver);
       browser.AccessingNewVisitorsPage();
       browser.ClickExternalOption();
       Thread.Sleep(3000);
       browser.AddLastName();
       Thread.Sleep(2000);
       browser.AddTitle();
       Thread.Sleep(1000);
       browser.AddaHostName();
       Thread.Sleep(3000);
       browser.ClickSaveButton();
       Thread.Sleep(3000);
       Assert.IsTrue(Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_lblSuccessMessage")).Displayed);
       browser.ArriveVisitorsCheckbox();
       Thread.Sleep(1000);
       browser.ClickonPrintBadge();
       Thread.Sleep(2000);
       browser.ClickonOK();
       Thread.Sleep(2000);

   }
        //Adding an external visitor through Hostnotfound
  [TestMethod]
  public void OD_AddingExternalVisitor1()
  {

      AddNewVisitorMethods browser = new AddNewVisitorMethods(this.Driver);
      browser.AccessingNewVisitorsPage();
      browser.ClickExternalOption();
      browser.AddLastName();
      Thread.Sleep(2000);
      browser.AddTitle();
      Thread.Sleep(3000);
      browser.HostNotFound();
      Thread.Sleep(3000);
      browser.HostNotFPop();

      browser.ClickSaveButton();
      Thread.Sleep(1000); 



  }


  public WebDriverWait Wait { get; set; }
    }


    }