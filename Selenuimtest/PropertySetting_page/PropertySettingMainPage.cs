using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.PropertySetting_page
{
   public class PropertySettingMainPage
    {
       private readonly string pp = ConfigurationSettings.AppSettings["PropertyNameP"];

        public PropertySettingMainPage(IWebDriver browser)
       { 
           this.browser = browser;
       }

        public PropertySettingMainPage()
        {
       }
        public PropertySettingsPageElement PropertySettingMap
       {
           get
           {
               return new PropertySettingsPageElement(this.browser);
           }
       }
        public void NavigateTo_PropertySettings()
        {
            this.PropertySettingMap.NavigatetoAdministration.Click();
            this.PropertySettingMap.Navigateto_Settings.Click();
            this.PropertySettingMap.Navigateto_PropertySettings.Click();
        }
        public void PropertyDroperdown_TorontoNew()
        {
            var drop1 = this.PropertySettingMap.SelectProperty_Dropedown;
            SelectElement sel = new SelectElement(drop1);
          //  sel.SelectByIndex(4);
            sel.SelectByText(pp);
        }

        public void Set_AddonNotice24_CutOff_3Pm()
        {
            NavigateTo_PropertySettings();
            Thread.Sleep(2000);
            PropertyDroperdown_TorontoNew();
            this.PropertySettingMap.AddOn_NoticePeriod.Clear();
            this.PropertySettingMap.AddOn_NoticePeriod.SendKeys("24");
            this.PropertySettingMap.AddOn_CutOff_Time.Clear();
            this.PropertySettingMap.AddOn_CutOff_Time.SendKeys("03:00 PM");
            Thread.Sleep(2000);
            this.PropertySettingMap.ClickOnUpdateSettings.Click();
            Thread.Sleep(2000);
        }
  //FFT_268
        public void Set_AddonNotice8_CutOff_3PM()
        {   NavigateTo_PropertySettings();
            Thread.Sleep(2000);
            PropertyDroperdown_TorontoNew();
            Thread.Sleep(2000);
            this.PropertySettingMap.AddOn_NoticePeriod.Clear();
            this.PropertySettingMap.AddOn_NoticePeriod.SendKeys("8");
            this.PropertySettingMap.AddOn_CutOff_Time.Clear();
            this.PropertySettingMap.AddOn_CutOff_Time.SendKeys("03:00 PM");
            Thread.Sleep(2000);
            this.PropertySettingMap.ClickOnUpdateSettings.Click();
            Thread.Sleep(2000);
        }
        public void Clear_AddonNotice_CutOff()
        {
            NavigateTo_PropertySettings();
            Thread.Sleep(2000);
            PropertyDroperdown_TorontoNew();
            Thread.Sleep(2000);
            this.PropertySettingMap.AddOn_NoticePeriod.Clear();
            this.PropertySettingMap.AddOn_NoticePeriod.SendKeys("0");
            this.PropertySettingMap.AddOn_CutOff_Time.Clear();
            this.PropertySettingMap.AddOn_CutOff_Time.SendKeys("11:45 PM");
            Thread.Sleep(2000);
            this.PropertySettingMap.ClickOnUpdateSettings.Click();
            Thread.Sleep(2000);
        }


        public IWebDriver browser { get; set; }
    }





}
