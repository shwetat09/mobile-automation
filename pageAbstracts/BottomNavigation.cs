
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;


namespace com.xplor.appium.framework
{
    public abstract class BottomNavigation(AppiumDriver driver) : CommonInteration(driver)
    {

        public enum BottomNavigationTabs{
            Clients, Activity, Messages, Account
        }

        protected abstract By Clients { get; }
        protected abstract By Activity { get; }
        protected abstract By Messages { get; }
        protected abstract By Account { get; }
   
   
        public void IsActivityDisplayed(){
            Assert.That(IsElementDisplayed(driver,Activity));

        }

        public void NavigateTo(BottomNavigationTabs tab)
        {
            switch (tab)  {
                case BottomNavigationTabs.Clients:
                    ClickOnElement(Clients);
                    break;
                case BottomNavigationTabs.Activity:
                    ClickOnElement(Activity);
                    break;
                case BottomNavigationTabs.Messages:
                    ClickOnElement(Messages);
                    break;
                    case BottomNavigationTabs.Account:
                    ClickOnElement(Account);
                    break;
                default:
                    throw new System.Exception("Invalid tab");
            }
        
        }

    }
    
    }