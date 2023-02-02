using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer.Drivers
{
    public class AppiumDriver
    {

        public AppiumDriver<AppiumWebElement> Driver { get; set; }

        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\odi\Downloads\application-e774c9b8-bc4b-4eb4-9c83-d4d03dcecb6f.apk");

            var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingAnyFreePort().Build();
            
            return new AndroidDriver<AppiumWebElement>(AppiumService, driverOptions);
        }
    }
}
