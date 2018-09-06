using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.LookUP
{
    public class LookUpPageElements
    {
        private readonly IWebDriver browser;
       public LookUpPageElements(IWebDriver browser)
       {
           this.browser = browser;
       }

       public LookUpPageElements()
        {
            // TODO: Complete member initialization
        }
       public IWebElement NavigatetoAdministration      
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id='adminSpan']"));

           }
       }
       public IWebElement NavigatetoLookup
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id='ctl00_lblLookUp']"));

           }
       }
       public IWebElement NavigatetoUDF
       {
           get
           {
               return this.browser.FindElement(By.XPath("//*[@id='ctl00_subLblUDF']"));

           }
       }

       public IWebElement SeletUDFDropedown
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlSelection"));

           }
       }

       public IWebElement CreateUDFFieldName
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_txtFieldName"));
            }
        }

       public IWebElement DataTypeDropedown
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlDataType"));
           }
       }
       public IWebElement UDFDropDown
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlUDFGroup"));
           }
       }
       public IWebElement IsMandatory_Yes
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdoIsMandatoryYes"));
           }
       }
       public IWebElement IsMandatory_No
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdoIsMandatoryNo"));
           }
        }

       public IWebElement IsActive_Yes
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdoIsActiveYes"));
           }
       }

       public IWebElement IsActive_No
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdoIsActiveNo"));
           }
       }
       public IWebElement ISDependent_Yes
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdoIsDependantYes"));
           }

       }
       public IWebElement ISDependent_NO
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rdoIsDependantNo"));
           }
       }

       public IWebElement ParentUDFDropedown
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlIsDependant"));
           }
       }

       public IWebElement UDF_Search_FieldName
       {
           get
           {
               return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$gridUserDefinedFieldDetails$ctl00$ctl02$ctl02$FilterTextBox_FieldName"));
           }
       }

     public IWebElement UDF_Search_Filter
       {
           get
           {
               return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$gridUserDefinedFieldDetails$ctl00$ctl02$ctl02$Filter_FieldName"));
           }
       }

     public IWebElement UDF_SearchFilter_StartsWith
     {
         get
         {
             return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_gridUserDefinedFieldDetails_rfltMenu_detached']/ul/li[4]/a/span"));
         }
     }
     public IWebElement UDF_ClickOnFirstEditRecord
     {
         get
         {
             return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_gridUserDefinedFieldDetails_ctl00__0']/td[12]/a/img"));
         }
     }
     public IWebElement UDF_ClickonFirstDeleteRecord
     {
         get {
             return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_gridUserDefinedFieldDetails_ctl00_ctl04_imgbtnRemove']"));
         }
     }

     public IWebElement ClickonPopUP_ConfirmDelete
     {
         get
         {
             return this.browser.FindElement(By.XPath("/html/body/div[2]/div[11]/div/button[1]/span"));
         }
     }
     public IWebElement UDF_ClickOnSave_Addmorebutton
     {
         get
         {
             return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$buttonSave"));
         }
     }
//element checkbox for deactivating child UDF
     public IWebElement DeactivateChildBookingUDF
     {
         get
         {
             return this.browser.FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_gridUserDefinedFieldDetails_ctl00_ctl04_chkActive']"));

         }
     }
  //element checkbox for Accepting Popup for confirm chnage State
     public IWebElement AcceptingPopupforconfirmchnagState
     {
         get
         {
             return this.browser.FindElement(By.XPath("//*[@id='btnOk']/span"));
         }
     }






























    }
}
