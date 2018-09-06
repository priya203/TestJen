using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Deparments
{
   public class DeparmentMainpage
    {

       private readonly string Department = ConfigurationSettings.AppSettings["DepartName"];
       private readonly string Property = ConfigurationSettings.AppSettings["PropertyName"];
       private readonly string AddonNotificationmsg = ConfigurationSettings.AppSettings["AddonNotificationMessage"];


        public DeparmentMainpage(IWebDriver browser)
        {
            this.browser = browser;
        }
        public DeparmentMainpage()
        {

        }

        public DeparmentPageElement DeptMap
        {
            get
            {
                return new DeparmentPageElement(this.browser);
            }

        }

        public void FFT_227AddonNotificationMessageDepartement()
        {
            this.DeptMap.Adminstration.Click();
            this. DeptMap.Deptnavigation.Click();
            Thread.Sleep(2000);
            this.DeptMap.departementName.Click();
            this.DeptMap.departementName.SendKeys(Department);
            this.DeptMap.departementName.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            this.DeptMap.PropertyName.Click();
            this.DeptMap.PropertyName.SendKeys(Property);
            Thread.Sleep(2000);
            this.DeptMap.PropertyName.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            this.DeptMap.SelectFirstElementfromsearchresults.Click();
            Thread.Sleep(4000);
            
           this.DeptMap.AddonNotificationyes.Click();
           Thread.Sleep(3000);
            this.DeptMap.AddonNotificationMessage.Clear();
            this.DeptMap.AddonNotificationMessage.SendKeys(AddonNotificationmsg);
            this.DeptMap.ClickOnsaveButton.Click();
        }

        public void FFT_229AddonNotificationMessageDepartement_NO()
        {
            this.DeptMap.Adminstration.Click();
            this.DeptMap.Deptnavigation.Click();
            Thread.Sleep(2000);
            this.DeptMap.departementName.Click();
            this.DeptMap.departementName.SendKeys(Department);
            this.DeptMap.departementName.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            this.DeptMap.PropertyName.Click();
            this.DeptMap.PropertyName.SendKeys(Property);
            Thread.Sleep(2000);
            this.DeptMap.PropertyName.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            this.DeptMap.SelectFirstElementfromsearchresults.Click();
            Thread.Sleep(4000);

            this.DeptMap.AddonNotificationno.Click();
            Thread.Sleep(3000);
            this.DeptMap.ClickOnsaveButton.Click();
        }

        public IWebDriver browser { get; set; }
    }
}
