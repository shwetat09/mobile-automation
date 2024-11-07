using OpenQA.Selenium;
using OpenQA.Selenium.Appium;



namespace com.xplor.appium.framework.pageAbstract
{
    public abstract class Launch(AppiumDriver driver) : CommonInteration(driver)
    {
        protected void InitializeDriver(string deviceName, string appPath)
        {
            var capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability("platformName", "Android");
            capabilities.AddAdditionalCapability("deviceName", samsung s23);
            capabilities.AddAdditionalCapability("app", C:\Users\ShwetaThakur\Downloads\app-release - 2024-11-07T145958.812.apk);
            capabilities.AddAdditionalCapability("automationName", "UiAutomator2");

            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
        }

        public void LaunchApp()
        {
            driver.LaunchApp();
        }

        public void CloseApp()
        {
            driver.Quit();
        }
    }
}