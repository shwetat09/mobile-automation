using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework.pageObjects.androidPageObjects
{
    public class Account_a(AppiumDriver driver) : Account(driver)
    {
        protected override By ClientsCount => MobileBy.Id("co.truecoach.client:id/accountClientCount");
    }
}