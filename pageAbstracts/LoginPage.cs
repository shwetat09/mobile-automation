

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;



namespace com.xplor.appium.framework.pageAbstracts
{
    public abstract class LoginPage(AppiumDriver driver) : CommonInteration(driver)
    {
        protected abstract By GetIamClient();


        protected abstract By IamCoach { get; }

        public void navigateToClientLogin()
        {
         IsElementDisplayed(driver,10, GetIamClient());
         ClickOnElement(GetIamClient());
         
        }
        public void navigateToCoachLogin()
        {
         IsElementDisplayed(driver,10,IamCoach);
         ClickOnElement(IamCoach);
        
    }
}}