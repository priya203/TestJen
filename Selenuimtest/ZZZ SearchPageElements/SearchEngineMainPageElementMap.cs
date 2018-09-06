using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.PageElements
{
    public class SearchEngineMainPageElementMap
    {
        private readonly IWebDriver browser;

        public SearchEngineMainPageElementMap(IWebDriver browser)
        {
            this.browser = browser;
        }

        public IWebElement SearchBox
        {
            get
            {
                return this.browser.FindElement(By.Id("sb_form_q"));
            }
        }

        public IWebElement GoButton
        {
            get
            {
                return this.browser.FindElement(By.Id("sb_form_go"));
            }
        }

        public IWebElement ResultsCountDiv
        {
            get
            {
                return this.browser.FindElement(By.Id("b_tween"));
            }
        }
      
        }
    }
   

