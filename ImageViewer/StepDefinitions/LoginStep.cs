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
    public sealed class LoginStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext scenarioContext;

        public LoginStep(ScenarioContext scenarioContext) { this.scenarioContext = scenarioContext; }

        [Given(@"I enter code and password")]
        public void GivenIEnterCodeAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
                .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText[1]")
                .SendKeys((string)data.code);
            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
                .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText[2]")
                .SendKeys((string)data.password);
        }

        [When(@"click Log in")]
        public void WhenClickLogIn()
        {
            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView")
               .Click();
        }

        [Then(@"I am authorized to the app")]
        public void ThenIAmAuthorizedToTheApp()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(true,
                 scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView")
               .Displayed);
        }

        [Then(@"I am not authorized to the app")]
        public void ThenIAmNotAuthorizedToTheApp()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(true,
                 scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView")
               .Displayed);
        }


    }
}