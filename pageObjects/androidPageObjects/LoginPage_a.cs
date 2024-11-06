

using com.xplor.appium.framework.pageAbstracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;



namespace com.xplor.appium.framework
{
    public class LoginPage_a(AppiumDriver driver) : LoginPage(driver)
    {
        protected override By GetIamClient()
        {
            return MobileBy.Id("co.truecoach.client:id/clientButton");
        }

        protected override By IamCoach => MobileBy.Id("co.truecoach.client:id/coachButton");
    }
}