
using AventStack.ExtentReports;
using com.xplor.appium.framework.pageAbstracts;
using com.xplor.appium.framework.pageObjects;
using com.xplor.appium.framework.utils;
using log4net.Config;
using MobileAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;
using OpenQA.Selenium.Internal;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using Xplor.Appium.TCOE.Utils.Infra;
{

}
namespace com.xplor.appium.framework
{



    public class BaseTests
    {

        public AppiumDriver driver;
      
        public CommonOperation page ;
        public ExtentTest _test;
  

        [SetUp]
        public void Setup()

        {
         
         BaseDriver baseDriver = new BaseDriver();
         ProjectSetup projectSetup = new ProjectSetup();
         baseDriver.StartDriver(baseDriver.SingleSessionOptions[projectSetup.TestingOS]);
         this.driver = baseDriver.Driver;
         page = new CommonOperation(driver);
              DirectoryInfo di = new DirectoryInfo("../../../");
             Environment.SetEnvironmentVariable("BASEPATH", di.FullName);
            ReportsGenerator.SetupExtentReport(driver);
            XmlConfigurator.Configure(new FileInfo(projectSetup.ProjectDirectory + "/log4net.config"));  
             _test = ReportsGenerator.InitializeExtentReport();
        }

     

        [TearDown]
        public void OneTimeTearDown()

        {
            ReportsGenerator.PublishExtentReport();
            ReportsGenerator.FlushExtentReport();
            driver.Dispose();


        }

    }
}