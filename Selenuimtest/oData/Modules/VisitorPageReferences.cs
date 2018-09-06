using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceProject.Modules
{
  public  class VisitorPageReferences
    {
        private readonly IWebDriver driver;

        public VisitorPageReferences(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement VisitorsTab
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_VisitorManagementTextSpan"));
            }
        }
     
        public IWebElement VisitorNameTextbox
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtVisitorName"));
            }
        }

        public IWebElement PropertyNameTextbox
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_cmbproperty"));


            }
        }
        public IWebElement HostNametextbox
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtHostName"));

            }
        }
        public IWebElement Datetextbox
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdpStartDate_dateInput"));

            }
        }
      public IWebElement Searchbutton 
        {
            get
            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnSearch"));
            }
        }
      public IWebElement HideInternals
      {
          get

          {
              return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_chkInternal"));
          }
      }

      public IWebElement HostName
      { get

          {
              return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtHostName"));
          }
      }
        public IWebElement ShowCancelleedVisitor
      {
            get

            {
                return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_chkCancelledVisitor"));
          
                
          }
      }


    public IWebElement PrintBadgeCheckbox
      
    {
        get

          {
              return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_grdVisitors_ctl00_ctl04_chkVisitor"));
          }
      }
      public IWebElement PrintBadgeButton
    {
        get
        {
            return this.driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnPrintBadge"));
        }
    }

        
    }

}



