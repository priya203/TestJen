using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Interfaces;

//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.Threading;
//using UnitTestProjectsummary.PageElements;
namespace UnitTestProjectsummary
{
    
   public class ExtentReportTest
    {
         public static ExtentReports extent;
         public static ExtentTest test;
         //public IWebDriver Driver;
         protected RemoteWebDriver _driver;
         public WebDriverWait Wait;

          [OneTimeSetUp]
          public void StartReport()
          {

              string reportPath = "F:\\Defects_Screenshots\\FlightBookReport.html";
              extent = new ExtentReports(reportPath, true);
          }

         
          //[OneTimeSetUp]
          // public void StartReport()
          //{
          //    string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
          //    string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
          //    string projectPath = new Uri(actualPath).LocalPath;

          //    string reportPath = projectPath + "Report\\MyOwnReports.html";
          //    // Console.WriteLine(reportPath);
          //    extent = new ExtentReports(reportPath, true);


          //    //extent.AddSystemInfo("Host Name", "Priyanka")
          //    //.AddSystemInfo("Environment", "YourQAEnvironment")
          //    //.AddSystemInfo("Username", "Priya");

          //    extent.LoadConfig(projectPath + "extent-config.xml");
          //}


          [TearDown]
          public void TeardownTest()
          {
              var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            DateTime time = DateTime.Now;
            string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");

            Console.WriteLine("Test: " + TestContext.CurrentContext.Test.Name + "is " + errorMessage);

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                takeScreenshot(dateToday + "error.jpg", stackTrace + errorMessage, "fail");
            else
                takeScreenshot(dateToday + "Pass.jpg", "Snapshot below: " , "pass");

            extent.EndTest(test);
            extent.Flush();
            try
            {
                _driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
                
          }


          //Take Screenshot and update test step status in the HTML report
          public void takeScreenshot(string filename, string stepdesc, string Result)
          {
              var ScrShot = _driver.GetScreenshot();
              ScrShot.SaveAsFile("C:\\FlightBook\\Images\\" + filename + ".jpg", ScreenshotImageFormat.Jpeg);

              if (Result == "pass")
                  test.Log(LogStatus.Pass, stepdesc + test.AddScreenCapture("C:\\FlightBook\\Images\\" + filename + ".jpg"));
              else
                  test.Log(LogStatus.Fail, stepdesc + test.AddScreenCapture("C:\\FlightBook\\Images\\" + filename + ".jpg"));
          }
   



       // public IWebDriver webDriver { get; set; }
    }
}
