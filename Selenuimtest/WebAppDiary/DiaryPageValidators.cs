using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.WebAppDiary
{
    public class DiaryPageValidators
    {

        private readonly IWebDriver browser;

        public DiaryPageValidators(IWebDriver browser)
        {
            this.browser = browser;
        }

        public DiaryPageValidators()
        {
            // TODO: Complete member initialization
        }


        protected DiaryPageElements Map1
        {
            get
            {
                return new DiaryPageElements(this.Driver);
            }
        }

     

        //public void TitleVerification(String title)
        //{
        //    Assert.IsTrue(this.browser.Title.Contains(title), "Workspace");
        //    Console.WriteLine("results are" +title);

        //}
        
       
        //public void ValidateUsername(String Attr)
        //{
        //   this.Map1.LoggedinUser.GetAttribute(String Attr);
           // Assert.IsTrue(this.Map1.LoggedinUser.Text.Equals("George Grover"), "message");
              
        //{
        //    Assert.IsTrue(this.Map1.LoggedinUser.Text.Contains(name), "Getting the Username");
        //    Console.WriteLine("results are" + name);
        //}



        public IWebDriver Driver { get; set; }
    }






       // public IWebDriver browser { get; set; }

        //public IWebDriver Driver { get; set; }
    }

