
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;


namespace com.xplor.appium.framework
{
    public abstract class Account(AppiumDriver driver) : CommonInteration(driver)
    {


        protected abstract By ClientsCount { get; }
      
   
        public void IsClientsCountDisplayed(){
            Assert.That(IsElementDisplayed(driver,ClientsCount));   
        }


    public  void ValidateClientsCount(string count){
        Assert.That(GetElementText(driver,ClientsCount), Is.EqualTo(count));
    }

    }
    
    }