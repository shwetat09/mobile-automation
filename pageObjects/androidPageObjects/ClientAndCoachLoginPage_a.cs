using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework
{
    public class ClientAndCoachLoginPage_a(AppiumDriver driver) : ClientAndCoachLoginPage(driver)
    {
        protected override By Logo => MobileBy.Id("appLogo");

        protected override By Username => MobileBy.Id("co.truecoach.client:id/emailEditText");

        protected override By Password => MobileBy.Id("co.truecoach.client:id/passwordEditText");

        protected override By SignInButton => MobileBy.Id("co.truecoach.client:id/loginButton");

         protected  By selectButton => MobileBy.Id("android:id/button1");

        protected override By HomeScreenElement => MobileBy.AndroidUIAutomator("new UiSelector().resourceId(\"co.truecoach.client:id/navigation_bar_item_icon_container\").instance(2)");

        public override void SelectEnvironment(string environment)
        {
            By env = MobileBy.AndroidUIAutomator("new UiSelector().text(\""+environment+"\")");
            Assert.That(IsElementDisplayed(driver, 20, env));
            ClickOnElement(env);
            ClickOnElement(selectButton);
           

        }

        public override void ValidateHomeScreen(By locator)
        {
          
            IsElementDisplayed(driver, locator);
        }
    }
}