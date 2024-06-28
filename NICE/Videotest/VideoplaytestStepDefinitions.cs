using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace NICE.Videotest
{
    [Binding]
    public class VideoplaytestStepDefinitions
    {
        private IWebDriver driver;

        public VideoplaytestStepDefinitions(IWebDriver driver)

        {
            this.driver = driver;
        }
        IWebElement playbutton => driver.FindElement(By.XPath("//*[@id=\"movie_player\"]/div[32]/div[2]/div[1]/button"));
        IWebElement videoelement => driver.FindElement(By.XPath(" //*[@id=\"movie_player\"]/div[1]/video"));

        [Given(@"login to youtube")]
        public void GivenLoginToYoutube()
        {

            driver.Navigate().GoToUrl("https://www.youtube.com/watch?app=desktop&v=r0SYxDp080o");
            Thread.Sleep(10000);
        }

        [When(@"I play the NICE youtube video")]
        public void WhenIPlayTheNICEYoutubeVideo()
        {
           // playbutton.Click();
        }

        [Then(@"video should play")]
        public void ThenVideoShouldPlay()
        {
            string script = "return arguments[0].currentTime > 0 && arguments[0].paused == false && arguments[0].ended == false;";
            bool isPlaying = (bool)((IJavaScriptExecutor)driver).ExecuteScript(script, videoelement);

            Assert.True(isPlaying, "The video is not playing.");
        }
    }
}
