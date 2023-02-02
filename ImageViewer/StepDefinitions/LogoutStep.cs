using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow.Assist;

namespace ImageViewer.StepDefinitions
{
    [Binding]
    public sealed class LogoutStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext scenarioContext;

        public LogoutStep(ScenarioContext scenarioContext) { this.scenarioContext = scenarioContext; }

        [Then(@"click Logout")]
        public void WhenClickLogon()
        {
            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
            .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView")
            .Click();
        }



    }
}