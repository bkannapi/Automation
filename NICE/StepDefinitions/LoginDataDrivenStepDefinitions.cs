using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace NICE.StepDefinitions
{
    [Binding]
    public class LoginDataDrivenStepDefinitions
    {

        private IWebDriver driver;

        public LoginDataDrivenStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement loginlink => driver.FindElement(By.LinkText("Login"));
        IWebElement usernamebox => driver.FindElement(By.Id("username"));
        IWebElement Nextbutton => driver.FindElement(By.XPath("//*[@id=\"btnNext\"]"));
        IWebElement Passbox => driver.FindElement(By.Id("password"));
        IWebElement Backbutton => driver.FindElement(By.CssSelector("#backBtn"));

        [Given(@"I am on nice home page")]
        public void GivenIAmOnNiceHomePage()
        {
            driver.Navigate().GoToUrl("https://www.nice.com/");

            Thread.Sleep(3000);

           
        }

        [When(@"I click the login link")]
        public void WhenIClickTheLoginLink()
        {
            loginlink.Click();
        }

        [Then(@"I enter the username ""([^""]*)""")]
        public void ThenIEnterTheUsername(string username)
        {
            usernamebox.Clear();
            usernamebox.SendKeys(username);
        }

        [Then(@"I click the next button")]
        public void ThenIClickTheNextButton()
        {
            Nextbutton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"I enter the password ""([^""]*)""")]
        public void ThenIEnterThePassword(string password)
        {
            Passbox.Clear();
            Passbox.SendKeys(password);
        }

        [Then(@"I click the back button")]
        public void ThenIClickTheBackButton()
        {
            Backbutton.Click();
        }
    }
}
