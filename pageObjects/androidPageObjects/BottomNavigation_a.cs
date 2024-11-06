using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework.pageObjects.androidPageObjects
{
    public class BottomNavigation_a(AppiumDriver driver) : BottomNavigation(driver)
    {
        protected override By Clients =>  MobileBy.AndroidUIAutomator("new UiSelector().resourceId(\"co.truecoach.client:id/navigation_bar_item_large_label_view\").text(\"Clients\")");

        protected override By Activity => MobileBy.AndroidUIAutomator("new UiSelector().text(\"Activity\")");

        protected override By Messages => MobileBy.AndroidUIAutomator("new UiSelector().text(\"Messages\")");

        protected override By Account => MobileBy.AndroidUIAutomator("new UiSelector().text(\"Account\")");

 
      
    }
}