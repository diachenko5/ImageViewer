using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ImageViewer.StepDefinitions
{
    [Binding]
    public sealed class PictureViewScreenStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext scenarioContext;

        public PictureViewScreenStep(ScenarioContext scenarioContext) { this.scenarioContext = scenarioContext; }

        public string idString = null;


        [Then(@"id element is present")]
        public void ThenIdElementIsPresent()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(true,
                 scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[2]")
               .Displayed);
        }

        [Then(@"picture is present")]
        public void ThenPictureIsPresent()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(true,
                 scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView")
               .Displayed);
        }

        [Then(@"slider is present")]
        public void ThenSliderIsPresent()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(true,
                 scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.SeekBar")
               .Displayed);
        }

        [When(@"remember id number")]
        public void WhenRememberIdNumber()
        {
            Thread.Sleep(2000);
            idString =
                scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[2]")
               .Text;
        }

        [When(@"click Logout")]
        public void WhenClickLogout()
        {
            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
            .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView")
            .Click();
        }

        [When(@"Enter code and password")]
        public void WhenEnterCodeAndPassword(Table table)
        {
            Thread.Sleep(2000);
            dynamic data = table.CreateDynamicInstance();

            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
                .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText[1]")
                .SendKeys((string)data.code);
            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
                .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText[2]")
                .SendKeys((string)data.password);
            scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
                .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView")
                .Click();

        }

        [Then(@"id number should increase")]
        public void ThenIdNumberShouldIncrease()
        {
            int id = Int32.Parse(idString);
            Thread.Sleep(2000);
            Assert.AreEqual((id + 1).ToString(),
                scenarioContext.Get<AndroidDriver<AppiumWebElement>>()
               .FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[2]")
               .Text);
        }


    }
}