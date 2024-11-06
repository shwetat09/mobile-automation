using com.xplor.appium.framework.pageAbstracts;
using com.xplor.appium.framework.pageObjects.androidPageObjects;
using com.xplor.appium.framework.pageObjects.iOSPageObjects;
using OpenQA.Selenium.Appium;

namespace com.xplor.appium.framework.pageObjects
{


    public class GetPageObjects 
    {
        Boolean isAndroid;
        AppiumDriver driver;

        public  GetPageObjects(AppiumDriver driver){
            
                this.driver=driver;
                string platformName=driver.PlatformName.ToString();
                this .isAndroid=platformName.ToLower().Equals("android");

        }

        public LoginPage GetLoginPage(){
       

            return (isAndroid==true) ? new LoginPage_a(driver):new LoginPage_i(driver);
            
            
            }

       
        public ClientAndCoachLoginPage GetClientLoginPage(){

            return (isAndroid==true) ? new ClientAndCoachLoginPage_a(driver):new ClientAndCoachLoginPage_i(driver);
            
            
            }
       
        public BottomNavigation GetBottomNavigation(){  

            return (isAndroid==true) ? new BottomNavigation_a(driver):new BottomNavigation_i(driver);

       
        }

        public Account GetAccount(){    

            return (isAndroid==true) ? new Account_a(driver):new Account_i(driver);
        }



   
   
   
    }}
    
    
    
    


