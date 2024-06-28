using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Xml.Linq;



namespace NICE.StepDefinitions
{
    [Binding]
    public class NiceHomepageStepDefinitions
    {
        private IWebDriver driver;

        public NiceHomepageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
        }

        [When(@"pass the NICE URL")]
        public void WhenPassTheNICEURL()
        {
            driver.Navigate().GoToUrl("https://www.nice.com/");
            
            Thread.Sleep(3000);
        }

        [Then(@"NICE home page should load")]
        public void ThenNICEHomePageShouldLoad()
        {
            //String ActualTitle = driver.();
            //String ExpectedTitle = "Customer Experience (CX) AI Platform";
           // Assert.AreEqual(ActualTitle, ExpectedTitle);

            IWebElement link = driver.FindElement(By.LinkText("Products"));

            // Get the text of the link
            string actualLinkText = link.Text;

            // Expected link text
            string expectedLinkText = "Products";

            // Assert that the actual link text matches the expected link text to ensure the home page loading fine
            Assert.AreEqual(expectedLinkText, actualLinkText, "Link text does not match");

            //driver.Quit();

            


        }
    }
}
