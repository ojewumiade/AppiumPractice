using System;
using TechTalk.SpecFlow;
using TestTraining.PageObjects;

namespace TestTraining.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage
private object driver;

        public LoginSteps()
        {
            loginPage = new LoginPage()
        }
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
           driver.Navigate().GoToUrl("http://www.giftrete.com")
        }
        
        [When(@"I click on Login link")]
        public void WhenIClickOnLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [When(@"I enter my username")]
        public void WhenIEnterMyUsername()
        {
            loginPage.EnterMyUsername();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            loginPage.EnterMyPassword();
        }
        
        [When(@"i click on login button")]
        public void WhenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on the Giftrete site")]
        public void ThenIShouldBeOnTheGiftreteSite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
