using AventStack.ExtentReports.Model;
using com.xplor.appium.framework;
using com.xplor.appium.framework.pageObjects;
using OpenQA.Selenium.Appium;

public class CommonOperation(AppiumDriver driver) : GetPageObjects(driver)
{


    public void PerformCoachLogin()
    {
        GetLoginPage().navigateToCoachLogin();
        GetClientLoginPage().changeEnvironment("QA");
        GetClientLoginPage().PerformLogin("newcoachwithoutclient@yopmail.com", "Asdqwe@123");
        LoggerHelper.Info("Coach Login Successful");
        
    }

         public void  NavigateToAccountForCoach(){
         PerformCoachLogin();
         GetBottomNavigation().IsActivityDisplayed();
          GetBottomNavigation().NavigateTo(BottomNavigation.BottomNavigationTabs.Account);

    }


}