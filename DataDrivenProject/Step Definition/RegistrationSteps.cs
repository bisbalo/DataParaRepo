using DataDrivenProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace DataDrivenProject.Step_Definition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;
        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            registrationPage.NavigateToWebsite(url);
        }
        
        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my username ""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            registrationPage.EnterUsername(username);
        }
        
        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string email)
        {
            registrationPage.EnterEmailAddress(email);
        }
        
        [Given(@"i enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            

           
            
            {
                registrationPage.EnterPassword(password);
            }

        }

        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickSignUpButton();
        }
        
        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {

            Thread.Sleep(5000);
            Assert.That(registrationPage.IsHomeDisplayed);
        }

       

    }
}
