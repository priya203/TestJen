using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using WorkspaceProject.Login;
using WorkspaceProject;
using UnitTestProjectsummary.Login;
using UnitTestProjectsummary.PageElements;

namespace WorkspaceProject.Modules
{
    public class VisitorPageMethods
    {


        public VisitorPageMethods(IWebDriver browser)
        {
            // TODO: Complete member initialization
            this.browser = browser;
        }
       
        //mapping refernces from Login References
        protected VisitorPageReferences Map
        {
            get
            {
                return new VisitorPageReferences(this.browser);
            }

        }
        //Login in and clicking on the VisistorsTab
        public void AccessingVisitorsTab()

        {
            this.Map.VisitorsTab.Click();
            Thread.Sleep(4000);

        }

        //adding a visitor to the visitors page. 
        public void AddingVisitor()
        {
           
            this.Map.VisitorNameTextbox.SendKeys("Test User7");
            Thread.Sleep(5000);
        }
    
    //Clicking on the Search Button
    public void Searchbutton()
{
    this.Map.Searchbutton.Click();
    Thread.Sleep(4000);
}
        //clicking on the HideInternals icon
    public void HideInternals()
    {
        this.Map.HideInternals.Click();
        Thread.Sleep(2000);
    }
        //clicking on the Host Name field

            public void HostName()
            {
            this.Map.HostName.Click();
            Thread.Sleep(2000);
    }
 //Clicking on the Print Badge checking box

        public void PrintBadgeCheckbox()
        {
            this.Map.PrintBadgeCheckbox.Click();
            Thread.Sleep(2000);
        }
        
        //clicking on the Canceleld Visitor 

        public void CancelVisitorCheckbox()
        {
            this.Map.ShowCancelleedVisitor.Click();
        }
    //Clicking on the Print Badge Button
        public void PrintBadgeButton()
        {
            this.Map.PrintBadgeButton.Click();

        }







        public IWebDriver browser { get; set; }
    }
}
 