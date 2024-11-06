using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework.pageObjects.androidPageObjects
{
    public class Account_i(AppiumDriver driver) : Account(driver)
    {
        protected override By ClientsCount => MobileBy.IosClassChain("**/XCUIElementTypeStaticText[`name CONTAINS \"Clients\"`]");
    }
}