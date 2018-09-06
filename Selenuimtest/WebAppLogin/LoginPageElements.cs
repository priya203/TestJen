using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.PageElements
{
   public class LoginPageElements
   {
       private readonly IWebDriver browser;
       public LoginPageElements(IWebDriver browser)
       {
           this.browser = browser;
       }

       //public LoginPageElements()
       //{
       //    // TODO: Complete member initialization
       //}

       public IWebElement LoginPageUsername
        {
            get
            {
                return this.browser.FindElement(By.Id("loginMain_UserName"));
            }
        }

       public IWebElement LoginPagePassword
        {
            get
            {
                return this.browser.FindElement(By.Id("loginMain_Password"));
            }

        }

       public IWebElement SubmitButton
        {
            get
            {
                return this.browser.FindElement(By.Name("loginMain$LoginButton"));
            }

        }

       public IWebElement InvalidLoginMessage
        {
            get
            {
               return this.browser.FindElement(By.XPath("//*[@id=\"loginMain\"]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]"));

            }

        }

       public IWebElement ForgotPassword
        {
           get
            {
                return this.browser.FindElement(By.Id("loginMain_lnkForgetPassword"));

           }

        }

       public IWebElement Logo
       {
           get
           {
               return this.browser.FindElement(By.Id("poweredbylogo"));

           }

       }

       public IList<IWebElement> countimages
       {
           get
           {
                return this.browser.FindElements(By.TagName("img"));

           }

       }
       public IWebElement LogoutButton
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_lblLogout"));
           }
       }
       public IWebElement loginSuccessfulCheck
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id=\"diarySpan\"]"));

           }

       }

       public IWebElement TextBox
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_calDateChange1_dateInput"));
           }
       }

       public string Title { get; set; }

       //public IWebDriver browser { get; set; }





       internal void CheckforloginSuccessful()
       {
           throw new NotImplementedException();
       }
   }
}
