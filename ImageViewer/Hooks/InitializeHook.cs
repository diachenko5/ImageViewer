using ImageViewer.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ImageViewer.Hooks
{
    [Binding]
    class InitializeHook
    {
        private readonly ScenarioContext scenarioContext;
        public InitializeHook(ScenarioContext scenarioContext) { this.scenarioContext = scenarioContext; }

        [BeforeScenario]
        public void Initialize() 
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            // context injection sets the type
            scenarioContext.Set(appiumDriver.InitializeAppium());
        }
    }
}
