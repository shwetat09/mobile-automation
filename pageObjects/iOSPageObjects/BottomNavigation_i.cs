using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework.pageObjects.androidPageObjects
{
    public class BottomNavigation_i(AppiumDriver driver) : BottomNavigation(driver)
    {
        protected override By Clients =>  MobileBy.IosClassChain("**/XCUIElementTypeButton[`name == \"Clients\"`]");

        protected override By Activity =>  MobileBy.IosClassChain("**/XCUIElementTypeButton[`name == \"Activity\"`]");

        protected override By Messages =>  MobileBy.IosClassChain("**/XCUIElementTypeButton[`name == \"Messages\"`]");

        protected override By Account =>  MobileBy.IosClassChain("**/XCUIElementTypeButton[`name == \"Account\"`]");

 
      
    }
}