using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary;
using UnitTestProjectsummary.PageElements;
using System.Threading;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
namespace UnitTestProjectsummary

{


     [TestFixture]
    public class SearchEngineTests
    {
        public IWebDriver Driver;
        public WebDriverWait Wait;
        ////private IWebDriver webDriver;
        //public static ExtentReports extent;

        //public static ExtentTest test;
        public static ExtentReports extent;

        public static ExtentTest test;


        public SearchEngineTests(IWebDriver webDriver)
        {
            // TODO: Complete member initialization
            this.webDriver = webDriver;
        }

        public SearchEngineTests()
        {

        }

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
            this.Driver = new ChromeDriver("E:\\Sel\\GetDock_driver\\chromedriver");
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

        }
        public void TakeScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            string title = "WebApp";
            string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string filepath = "F:/Defects_Screenshots/";
            ss.SaveAsFile(filepath + Runname + ".png", ScreenshotImageFormat.Png);
            Thread.Sleep(3000);
            string path1 = ".Png";
            String Join = filepath + Runname + path1;
            Console.WriteLine(Join);
            test.Log(LogStatus.Pass, "ppp" + test.AddScreenCapture((Join)));
        }

      
        [Test]
        public void dummy()
        {
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Login();
            Thread.Sleep(3000);
            IWebElement ss= Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_calDateChange1_dateInput"));
            String DateT = ss.GetAttribute("value");
            Console.WriteLine(DateT);
            Assert.IsTrue(DateT.Equals("16/02/2018"), "Your Test Failed due to mismatch in assertion Value");
      }

        
       [Test]
        public void LoginMainPageSuccess()
        {

            test = extent.StartTest("LoginMainPageSuccess");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Login();
            TakeScreenshot();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().CheckforloginSuccessful();
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Your Login Is Successfull" );

          
        }


        [Test]
        public void LoginMainPageLoginFailed()
        {
            test = extent.StartTest("LoginMainPageLoginFailed");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.LoginInvalidCredientials();
            TakeScreenshot();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().CheckForLoginFailure();
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Login failed for Invalid Username and Password");
          

          
        }

       [Test]
        public void MainPageTtitleVarification()
        {
            test = extent.StartTest("MainPageTtitleVarification");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Login();
            searchEngineMainPage.Validate().TitleVerification();
            TakeScreenshot();
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Your Login Is Successfull");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Main Page Title Workspace Has verified successfully");
          
        }


        [Test]
        public void DisplayForgotPasswordLink()
        {
            test = extent.StartTest("DisplayForgotPasswordLink");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().ForgotpasswordLINK();
            Thread.Sleep(3000);
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Forgot Password link is Enabled for User");
          

        }


        [Test]
        public void DisplayNFSLogo()
        {
            test = extent.StartTest("DisplayNFSLogo");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().ValidateLogo();
            Thread.Sleep(3000);
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "DisplayNFSLogo on Login Page");
          
        }
        [Test]
        public void LogoutTest01()
        {
            test = extent.StartTest("LoginExtentReport");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Login();
            Thread.Sleep(3000);
            searchEngineMainPage.logoutTest();
            TakeScreenshot();
            Thread.Sleep(3000);
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Your Login Is Successfull");
          
        }


        public void CountNumberOfImagesOnPage()
        {
            test = extent.StartTest("LoginExtentReport");
            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            Thread.Sleep(3000);
            searchEngineMainPage.Validate().CountImages();
            Thread.Sleep(3000);
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

        //[OneTimeTearDown]
        //public void EndReport()
        //{
        //    extent.Flush();
        //    extent.Close();
        //    Driver.Quit();
        //}


        public IWebDriver webDriver { get; set; }

    }
}