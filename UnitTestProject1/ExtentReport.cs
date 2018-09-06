//using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Drawing.Imaging;
using UnitTestProjectsummary.PageElements;
using TechTalk.SpecFlow;
namespace UnitTestProjectsummary
{
   [TestFixture]
    public class ExtentReport
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        public IWebDriver Driver;
        public WebDriverWait Wait;
     


            [OneTimeSetUp]
            public void StartReport()
            {
               string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
               string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
               string projectPath = new Uri(actualPath).LocalPath;
               string reportPath = projectPath + "Report\\MyOwnReports.html";
               extent = new ExtentReports(reportPath, true);

               extent.AddSystemInfo("Host Name", "Priyanka")
              .AddSystemInfo("Environment", "http://localhost/WebAppVV6_3/")
              .AddSystemInfo("Username", "Priya");

               extent.LoadConfig(projectPath + "extent-config.xml");

               this.Driver = new ChromeDriver();
               this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(60));
               Thread.Sleep(2000);
               Driver.Manage().Window.Maximize();
               Thread.Sleep(3000);
            }
        
            public void TakeScreenshot()
            {
               Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
               string title="WebApp";
               string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
                string filepath="F:/Defects_Screenshots/";
                ss.SaveAsFile(filepath + Runname + ".png" ,ScreenshotImageFormat.Png);
                Thread.Sleep(3000);
                string path1=".Png";
                String Join = filepath + Runname + path1;
                Console.WriteLine(Join);
                test.Log(LogStatus.Pass, "ppp" + test.AddScreenCapture((Join)));
            }


        [Test]
        public void DisplayNFSLogo()
        {
            test = extent.StartTest("DisplayNFSLogo");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().ValidateLogo();
            TakeScreenshot();
            Thread.Sleep(3000);
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "DisplayNFSLogo on Login Page");

        }



        [Test]
        public void LoginExtentReport()
        {
            test = extent.StartTest("LoginExtentReport");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Login();
            TakeScreenshot();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().CheckforloginSuccessful();
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Login Is Successfull");
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
            Driver.Quit();
        }


 



    
public  IWebDriver webDriver { get; set; }
public string filepath { get; set; }
    }
}
