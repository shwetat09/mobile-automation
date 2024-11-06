using com.xplor.appium.framework.pageAbstracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework.pageObjects.iOSPageObjects
{
    public class LoginPage_i(AppiumDriver driver) : LoginPage(driver)
    {
        protected override By GetIamClient()
        {
            return MobileBy.IosClassChain("**/XCUIElementTypeButton[`name == \"I'm a Client\"`]");
        }

        protected override By IamCoach => MobileBy.IosClassChain("**/XCUIElementTypeStaticText[`name == \"I'm a Coach\"`]");
    }
}