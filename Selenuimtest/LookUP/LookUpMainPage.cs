using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProjectsummary.PageElements;

namespace UnitTestProjectsummary.LookUP
{
    public class LookUpMainPage:LoginMainPage
    {
        public LookUpMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        public LookUpMainPage()
        {
            
        }
        public LookUpPageElements LookUPMap
        {
            get
            {
                return new LookUpPageElements(this.browser);
             }
        }
        public void EnterFieldNameForParentQuentionare()
        {
            this.LookUPMap.CreateUDFFieldName.SendKeys("TechnicalRequirment");
        }
        public void EnterFieldNameForChildQuentionare()
        {
            this.LookUPMap.CreateUDFFieldName.SendKeys("wifi Availible?");
        }
        public void ENterUpdatedFieldNameForChildQuestionare()
        {
            this.LookUPMap.CreateUDFFieldName.Clear();
            Thread.Sleep(2000);
            this.LookUPMap.CreateUDFFieldName.SendKeys("Is Projector Availible?");
        }

        public void EnterFieldName_ParentBookingUDF()
        {

            this.LookUPMap.CreateUDFFieldName.SendKeys("room facilities and amenities Availible?");
        }

        public void ENterFieldName_ChildBookingUDF()
        {

            this.LookUPMap.CreateUDFFieldName.SendKeys("Desk Lamp,Refrigerator");
        }

        public void NavidateToUDF()
        {
            this.LookUPMap.NavigatetoAdministration.Click();
            
            this.LookUPMap.NavigatetoLookup.Click();
           
            this.LookUPMap.NavigatetoUDF.Click();
        }
        //dropedown For the selecting Questionare
        public void SelectUDFQuentionnaireDropedown()
        {
            var dropedown = this.LookUPMap.SeletUDFDropedown;
            var SelectUdf = new SelectElement(dropedown);
            Thread.Sleep(2000);
            SelectUdf.SelectByIndex(4);
            Thread.Sleep(3000);
        }
        public void SelectUDF_BookingDropedown()
        {
            var dropedown = this.LookUPMap.SeletUDFDropedown;
            var SelectUdf = new SelectElement(dropedown);
            Thread.Sleep(2000);
            SelectUdf.SelectByIndex(0);
            Thread.Sleep(3000);
        }

        public void SelectDataTypeFromDropedown_Boolean()
        {
            var dropedown1 = this.LookUPMap.DataTypeDropedown;
            var SelectDataType = new SelectElement(dropedown1);
            Thread.Sleep(2000);
            SelectDataType.SelectByIndex(1);
            Thread.Sleep(3000);
        }
       
        public void SelectUDFGroupDropedown()
        {
            var dropedown2 = this.LookUPMap.UDFDropDown;
            var SelectUdFGroup = new SelectElement(dropedown2);
            Thread.Sleep(2000);
            SelectUdFGroup.SelectByIndex(0);
            Thread.Sleep(3000);
        }
        public void ParentUDFDropedown_Questioonare()
        {
            var dropedown3 = this.LookUPMap.ParentUDFDropedown;
            var SelectPrentUdf = new SelectElement(dropedown3);
            Thread.Sleep(2000);
            SelectPrentUdf.SelectByIndex(0);
        }

        public void ParentUDFDropedown_Booking()
        { 
          var dropedown3 = this.LookUPMap.ParentUDFDropedown;
            var SelectPrentUdf = new SelectElement(dropedown3);
            Thread.Sleep(2000);
           // SelectPrentUdf.SelectByIndex(0);
            SelectPrentUdf.SelectByText("room facilities and amenities Availible?");
        }
        
        public void IsDependentYes()
        {
            this.LookUPMap.ISDependent_Yes.Click();
        }

        public void UDfSearchForEditQuestionare_Parent()
        {
            this.LookUPMap.UDF_Search_FieldName.Click();
            Thread.Sleep(2000);
            this.LookUPMap.UDF_Search_Filter.Click();
            Thread.Sleep(3000);
            this.LookUPMap.UDF_SearchFilter_StartsWith.Click();
            this.LookUPMap.UDF_Search_FieldName.SendKeys("TechnicalRequirment");
            this.LookUPMap.UDF_Search_FieldName.SendKeys(Keys.Enter);
        }
        public void UDFSearchForDeleteQuestionare()
        {
            this.LookUPMap.UDF_Search_FieldName.Click();
            Thread.Sleep(2000);
            this.LookUPMap.UDF_Search_Filter.Click();
            Thread.Sleep(3000);
            this.LookUPMap.UDF_SearchFilter_StartsWith.Click();
            this.LookUPMap.UDF_Search_FieldName.SendKeys("Is Projector Availible?");
            this.LookUPMap.UDF_Search_FieldName.SendKeys(Keys.Enter);
        }
        public void UDFSearchFor_deactivateCHildBookingUDF()
        {
            this.LookUPMap.UDF_Search_FieldName.Click();
            Thread.Sleep(2000);
            this.LookUPMap.UDF_Search_Filter.Click();
            Thread.Sleep(3000);
            this.LookUPMap.UDF_SearchFilter_StartsWith.Click();
            this.LookUPMap.UDF_Search_FieldName.SendKeys("Desk Lamp,Refrigerator");
            this.LookUPMap.UDF_Search_FieldName.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            this.LookUPMap.DeactivateChildBookingUDF.Click();
            Thread.Sleep(2000);
            this.LookUPMap.AcceptingPopupforconfirmchnagState.Click();
        }

        public void UDF_ClickOnEditRsecordFirst1()
        {
            this.LookUPMap.UDF_ClickOnFirstEditRecord.Click();
        }

        public void UDF_ClickOnDeleteRecord()
        {
            this.LookUPMap.UDF_ClickonFirstDeleteRecord.Click();
            Thread.Sleep(3000);
            this.LookUPMap.ClickonPopUP_ConfirmDelete.Click();
        }
        public void ClickOnSave_AddMoreButton()
        {
            this.LookUPMap.UDF_ClickOnSave_Addmorebutton.Click();
        }














    
public  IWebDriver browser { get; set; }}
   
    
}
