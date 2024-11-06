using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework
{
    public class ClientAndCoachLoginPage_i(AppiumDriver driver) : ClientAndCoachLoginPage(driver)
    {
        protected override By Logo => MobileBy.AccessibilityId("tcLogo");
        
        protected override By Username => MobileBy.IosClassChain("**/XCUIElementTypeTextField[`value == \"Email\"`]");
        protected override By Password => MobileBy.IosClassChain("**/XCUIElementTypeSecureTextField[`value == \"Password\"`]");
        protected override By SignInButton => MobileBy.IosClassChain("**/XCUIElementTypeButton[`name == \"Sign in as Coach\" OR name == \"Sign in as Client\"`][1]");

        protected  By NotNowButton => MobileBy.AccessibilityId("Not Now");
        
        protected override By HomeScreenElement => MobileBy.IosClassChain("**/XCUIElementTypeButton[`name == \"Account\"`]");

        public override void SelectEnvironment(string environment)
        {
            By env = MobileBy.AccessibilityId(environment);
             Assert.That(IsElementDisplayed(driver, 10, env));
           ClickOnElement(env);
           

        }

        public override void ValidateHomeScreen(By locator)
        {
              AcceptAlert(driver);
            bool flag =IsElementDisplayed(driver, NotNowButton);
            if(flag){   
               ClickOnElement(NotNowButton);
            }
            IsElementDisplayed(driver, locator);
        }
    }
}