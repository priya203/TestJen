using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.PageElements
{
    public class LoginPageValidators
    {
       private readonly IWebDriver browser;

        public LoginPageValidators(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected LoginPageElements Map
        {
            get
            {
             
                return new LoginPageElements(this.browser);
            }
        }


        public void ResultsInvalidPassword(string msg)
        {
            Assert.IsTrue(this.Map.InvalidLoginMessage.Text.Contains(msg), "Your login attempt was not successful. Please try again.");
        }


        public void TitleVerification()
        {
            //String ssg = this.Map.Title.Text();
           // Assert.IsTrue(this.browser.Title.Contains(title).Equals("Workspace"), "Workspace");
            Assert.IsTrue(this.browser.Title.Equals("Workspace"),"message");
            //Console.WriteLine(Title); 
            
        }

        public void ForgotpasswordLINK()
        {
            Assert.IsTrue(this.Map.ForgotPassword.Enabled);
            
        }

        public void ValidateLogo()
        {
            Assert.IsTrue(this.Map.Logo.Displayed);
            Console.WriteLine("Logo is Present");  

        }

        public void CountImages()
        {
            Console.WriteLine(this.Map.countimages.Count);  
        }

        public void CheckforloginSuccessful()
        {
            Assert.IsTrue(this.Map.loginSuccessfulCheck.Enabled);
          
        }

        public void CheckForLoginFailure()
        {
            Assert.IsTrue(this.Map.ForgotPassword.Enabled);
        }

       

       // public IWebDriver browser { get; set; }
    }
}
     

    

