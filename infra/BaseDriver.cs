
using OpenQA.Selenium.Appium;
using System.Collections.Generic;
using System;
using Xplor.Appium.TCOE.Utils.SelenideContext;
using Xplor.Appium.TCOE.Utils.Tools;
using Xplor.Appium.TCOE.Utils.Infra;

namespace MobileAutomation
{
     public class BaseDriver:MobileDriver



    {


   



        public  AppiumOptions SingleSessionLocalAndroidOptions
        {
            get
            {
                AppiumOptions options =  GetAutomationCapabilities().SingleSessionLocalAndroidOptions();
                options.AddAdditionalAppiumOption("appium:autoAcceptAlerts", true);
                return options;
            }

        }

        public  AppiumOptions FlowRunSessionLocalAndroidOptions
        {
            get
            {
                return GetAutomationCapabilities().FlowRunSessionLocalAndroidOptions();
            }
        }

        public  AppiumOptions FlowRunSessionLocalAndroidTabletOptions
        {
            get
            {
                return GetAutomationCapabilities().FlowRunSessionLocalAndroidTabletOptions();
            }
        }

        public  AppiumOptions RemoteSessionSingleRunOptions
        {
            get
            {
                return GetAutomationCapabilities().RemoteSessionSingleRunOptions();
            }

        }

        public  AppiumOptions RemoteSessionSingleRunOptionsTablet
        {
            get
            {
                return GetAutomationCapabilities().RemoteSessionSingleRunOptionsTablet();
            }
        }

        public  AppiumOptions RemoteSessionSingleRunIOSOptions

        {
            get
            {
                return GetAutomationCapabilities().RemoteSessionSingleRunIOSOptions();
            }
        }

        public  AppiumOptions GetLatestRemoteSessionSingleRunOptions(string appUrl)
        {
            return GetAutomationCapabilities().GetLatestRemoteSessionSingleRunOptions(appUrl);
        }

        public  AppiumOptions GetLatestRemoteSessionSingleRunOptionsTablet(string appUrl)
        {
            return GetAutomationCapabilities().GetLatestRemoteSessionSingleRunOptionsTablet(appUrl);
        }

        public  AppiumOptions GetLatestRemoteSessionSingleRunIOSOptions(string appUrl)
        {

            return GetAutomationCapabilities().GetLatestRemoteSessionSingleRunIOSOptions(appUrl);
        }


      
        public  AppiumOptions IOSOptions
        {
            get
            {
                AppiumOptions appiumOptions= GetAutomationCapabilities().IOSOptions();
                appiumOptions.AddAdditionalAppiumOption("appium:autoAcceptAlerts", false);
                return appiumOptions;
            }
        }   


       public String GetAppUrl()
        {
           if(setup.IsAndroid){
            return setup.GetTestingBuildPathAndroid();
           }
           return setup.GetTestingBuildPathIOS();
        }

        public  Dictionary<string, AppiumOptions> SingleSessionOptions
        {
            get
            {
                AppiumOptions remoteOptions;
              
                if (setup.IsTablet)
                {
                    remoteOptions = setup.IsLatestBuildRequired() ? GetLatestRemoteSessionSingleRunOptionsTablet(GetAppUrl()) : RemoteSessionSingleRunOptionsTablet;
                }
                else
                {
                    remoteOptions = setup.IsLatestBuildRequired() ? GetLatestRemoteSessionSingleRunOptions(GetAppUrl()) : RemoteSessionSingleRunOptions;
                }

                AppiumOptions remoteIOSOptions = setup.IsLatestBuildRequired() ? GetLatestRemoteSessionSingleRunIOSOptions(GetAppUrl()) : RemoteSessionSingleRunIOSOptions;

                return new Dictionary<string, AppiumOptions>
                {
                    {"Android", setup.IsRemoteRun ? remoteOptions : SingleSessionLocalAndroidOptions},
                    {"iOS", setup.IsRemoteRun ? remoteIOSOptions: IOSOptions}
                };
            }
        }

        public  Dictionary<string, AppiumOptions> FlowSessionOptions
        {
            get
            {
                AppiumOptions remoteOptions;
                if (setup.IsTablet)
                {
                    remoteOptions = setup.IsLatestBuildRequired() ? GetLatestRemoteSessionSingleRunOptionsTablet(GetAppUrl()) : RemoteSessionSingleRunOptionsTablet;
                }
                else
                {
                    remoteOptions = setup.IsLatestBuildRequired() ? GetLatestRemoteSessionSingleRunOptions(GetAppUrl()) : RemoteSessionSingleRunOptions;
                }

                AppiumOptions remoteIOSOptions = setup.IsLatestBuildRequired() ? GetLatestRemoteSessionSingleRunIOSOptions(GetAppUrl()) : RemoteSessionSingleRunIOSOptions;

                return new Dictionary<string, AppiumOptions>
                {
                    {"Android", setup.IsRemoteRun ? remoteOptions : FlowRunSessionLocalAndroidOptions},
                    {"iOS", setup.IsRemoteRun? remoteIOSOptions: IOSOptions}
                };
            }
        }

    }
   }


