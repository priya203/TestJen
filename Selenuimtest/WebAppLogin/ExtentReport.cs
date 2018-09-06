//using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;
using UnitTestProjectsummary.PageElements;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectsummary.WebAppLogin
{
    
   public class ExtentReport
    {
        public IWebDriver Driver;
        public WebDriverWait Wait;
        public static ExtentReports extent;
         public static ExtentTest test;


          public ExtentReport(IWebDriver webDriver)
        {
            // TODO: Complete member initialization
            this.webDriver = webDriver;
        }

          public ExtentReport()
        {

        }


    [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();

            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            String projectPath = "E:\\Sel\\VisualStudioSetUP\\NET4.7\\Selenuimtest\\";

            string reportPath = "C:\\FlightBook\\MyOwnReports.html";
            extent = new ExtentReports(reportPath, true);
            extent.LoadConfig(projectPath + "extent-config.xml");
        }


        //[OneTimeSetUp]

        public void StartReport()
        {

           // string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
           // string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
           // string projectPath = new Uri(actualPath).LocalPath;
            String projectPath="E:\\Sel\\VisualStudioSetUP\\NET4.7\\Selenuimtest\\";

            string reportPath = "C:\\FlightBook\\MyOwnReports.html";
            // Console.WriteLine(reportPath);
            extent = new ExtentReports(reportPath, true);


            //extent.AddSystemInfo("Host Name", "Priyanka")
            //.AddSystemInfo("Environment", "YourQAEnvironment")
            //.AddSystemInfo("Username", "Priya");

            extent.LoadConfig(projectPath + "extent-config.xml");
        }

         [Test]
        public void DemoReportPass()
        {
            test = extent.StartTest("DemoReportPass");
           
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Login();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().CheckforloginSuccessful();
            //Assert.IsTrue(true);
            //test.Log(LogStatus.Pass, "Assert Pass as condition is True");

        }

        // [Test]
        public void DemoReportFail()
        {
            test = extent.StartTest("DemoReportFail");
            Assert.IsTrue(false);
            test.Log(LogStatus.Pass, "Assert Pass as condition is Fail");

        }

        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
            }
            extent.EndTest(test);
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }








        public IWebDriver webDriver { get; set; }
    }
}
