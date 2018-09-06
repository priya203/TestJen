using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.Contacts
{
    public class ContactsMainPage
    {
        
           
    public ContactsMainPage(IWebDriver browser)
       {
         this.browser = browser;
       }

    public ContactsMainPage()
      {
      }

    public ContactsPageElement Contactmap
        {
           get
             {
                 return new ContactsPageElement(this.browser);
             }
        }
    public void navigatetoContacts()
    { 
    
    }





public  IWebDriver browser { get; set; }}


}
