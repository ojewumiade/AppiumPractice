using System;
using TechTalk.SpecFlow;

namespace TestTraining.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"That i navigate to the site")]
        public void GivenThatINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
       
        
        [When(@"i click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my firstname")]
        public void WhenIEnterMyFirstname()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my mobile number")]
        public void WhenIEnterMyMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter wrong password")]
        public void WhenIEnterWrongPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to register")]
        public void ThenIShouldBeAbleToRegister()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should not be able to register")]
        public void ThenIShouldNotBeAbleToRegister()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
