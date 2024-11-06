





using System.Drawing;
using Microsoft.CodeAnalysis;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using Xplor.Appium.TCOE.Utils.MobileActionsAndTimeOuts;

namespace com.xplor.appium.framework
{
    public class CommonInteration
    {

        int shortimeout = 10;
        public AppiumDriver driver;

        public CommonInteration(AppiumDriver driver)
        {
            this.driver = driver;

        }

        private WaitAndLocators waitAndLocators;
        public WaitAndLocators GetWaitAndLocators()
        {

            if (waitAndLocators == null)
            {
                waitAndLocators = new WaitAndLocators(driver);
            }
            return waitAndLocators;
        }

        public Boolean IsElementDisplayed(AppiumDriver driver, By element)
        {

            return IsElementDisplayed(driver, shortimeout, element);
        }


        public String GetElementText(AppiumDriver driver, By element)
        {
            return GetWaitAndLocators().waitForElement(element, shortimeout).Text;

        }

        public Boolean IsElementDisplayed(AppiumDriver driver, int tiemouts, By element)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(tiemouts));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(dr => driver.FindElement(element).Displayed);
        }


        public void ClickOnElement(By element)
        {
            driver.FindElement(element).Click();

        }

        public void AcceptAlert(AppiumDriver driver){
           bool flag= GetWaitAndLocators().IsAlertisplayed(10);
           if(flag){
            driver.SwitchTo().Alert().Accept();
           }
        }

        public void LongPress(By locator, int elementWaitTimeOut, int longPressTimeout)
        {
            WaitAndLocators locators = new WaitAndLocators(driver);
            new TouchIntractions().LongPress(driver, locators.waitForElement(locator, elementWaitTimeOut), longPressTimeout);
        }
        public void LongPress(By locator, int longPressTimeout)
        {
            WaitAndLocators locators = new WaitAndLocators(driver);
            AppiumElement elementToTouch = locators.waitForElement(locator, shortimeout);
            Point point = new()
            {
                X = elementToTouch.Location.X + (elementToTouch.Size.Width) / 2,
                Y = elementToTouch.Location.Y + (elementToTouch.Size.Height) / 2
            };
            new TouchIntractions().PerformGestureOperation(driver, point, TouchIntractions.GesturesType.LONG_PRESS, longPressTimeout);
        }

        public void SendKeys(By element, string text)
        {
            WebElement inputField = driver.FindElement(element);
            inputField.Clear();
            inputField.SendKeys(text);

        }


    }

}