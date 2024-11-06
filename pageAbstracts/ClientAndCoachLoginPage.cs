
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;


namespace com.xplor.appium.framework
{
    public abstract class ClientAndCoachLoginPage(AppiumDriver driver) : CommonInteration(driver)
    {

        protected abstract By Logo { get; }
        protected abstract By Username { get; }
        protected abstract By Password { get; }
        protected abstract By SignInButton { get; }
        protected abstract By HomeScreenElement { get; }


        public abstract void SelectEnvironment(string environment);

        public void changeEnvironment(string environment)
        {
           
            IsElementDisplayed(driver, SignInButton);
             IsElementDisplayed(driver, Logo);
            LongPress(Logo,8);
            SelectEnvironment(environment);


        }


        public void PerformLogin(string username_cred, string password_cred)
        {
            Assert.That(IsElementDisplayed(driver, Username));
            SendKeys(Username, username_cred);
            SendKeys(Password, password_cred);
            ClickOnElement(SignInButton);
            ValidateHomeScreen(HomeScreenElement);
 
        }

        public abstract void ValidateHomeScreen(By locator);


    }



}