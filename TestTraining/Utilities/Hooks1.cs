using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestTraining.Utilities
{
    [Binding]
    public sealed class Hooks1
    {
        ChromeDriver driver

        [BeforeScenario]
        public void BeforeScenario()
        {
          driver = new ChromeDriver
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
