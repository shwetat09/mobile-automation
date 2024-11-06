
using com.xplor.appium.framework.pageAbstracts;
using com.xplor.appium.framework.pageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using  OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;
using OpenQA.Selenium.Internal;

namespace com.xplor.appium.framework{




public class Test_Display_0_Clients :BaseTests
{
 

    
   
    
    [Test]
    [Property("aiocasekey", "TC-TC-365")]
    [Description("Test to verify Account Page Shows 0 Clients for Coach")]
    public void Test1()
    {
      
  

        //  page.PerformCoachLogin();
         // page.GetBottomNavigation().IsActivityDisplayed();
          //page.GetBottomNavigation().NavigateTo(BottomNavigation.BottomNavigationTabs.Account);
          page.NavigateToAccountForCoach();
          page.GetAccount().IsClientsCountDisplayed();
          page.GetAccount().ValidateClientsCount("0 Clients");

          
       
        
    }


}

}