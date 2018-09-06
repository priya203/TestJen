//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Chrome;
//using UnitTestProjectsummary;
//using UnitTestProjectsummary.PageElements;

//namespace UnitTestProjectsummary
//{

   
//    [TestClass]
//    public class SearchEngineTests
//    {

//        public SearchEngineTests()
//        {

//        }
//        public IWebDriver Driver;
//        public WebDriverWait Wait;
//        private IWebDriver webDriver;

//        public SearchEngineTests(IWebDriver webDriver)
//        {
//            // TODO: Complete member initialization
//            this.webDriver = webDriver;
//        }

//        [TestInitialize]
//        public void SetupTest()
//        {
//            this.Driver = new ChromeDriver();
//            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
//        }

//        [TestCleanup]
//        public void TeardownTest()
//        {
//            this.Driver.Quit();
//        }

//        [TestMethod]
//        public void LoginMainPageSuccess()
//        {
//            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
//            searchEngineMainPage.Navigate();
//            searchEngineMainPage.Login();
//        }


//        [TestMethod]
//        public void LoginMainPageLoginFailed()
//        {
//            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
//            searchEngineMainPage.Navigate();
//            searchEngineMainPage.LoginInvalidCredientials();
           
//            searchEngineMainPage.Validate().ResultsInvalidPassword("Your login attempt was not successful. Please try again.");
//        }

//        [TestMethod]
//        public void MainPageTtitleVarification()
//        {
//            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
//            searchEngineMainPage.Navigate();
//            searchEngineMainPage.Login();
//            searchEngineMainPage.Validate().TitleVerification();
//        }


//       [TestMethod]
//        public void DisplayForgotPasswordLink()
//        {
//            LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
//           searchEngineMainPage.Navigate();
//           searchEngineMainPage.Validate().ForgotpasswordLINK();
            
//       }

//       [TestMethod]
//       public void DisplayNFSLogo()
//       {
//           LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
//           searchEngineMainPage.Navigate();
//           searchEngineMainPage.Validate().ValidateLogo();
//       }

//       [TestMethod]
//       public void CountNumberOfImagesOnPage()
//       {
//           LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
//           searchEngineMainPage.Navigate();
//           searchEngineMainPage.Validate().CountImages();
//       }

//       //[TestMethod]
//       //public void Logout()
//       //{
//       //    LoginMainPage searchEngineMainPage = new LoginMainPage(this.Driver);
//       //    searchEngineMainPage.Navigate();
//       //    searchEngineMainPage.Login();
//       //    DiaryMainPage diarymainpage1 = new  DiaryMainPage(this.Driver);
//       //    diarymainpage1.Validate1().ValidateUsername();
               
       
//       //}

//    }
//}
