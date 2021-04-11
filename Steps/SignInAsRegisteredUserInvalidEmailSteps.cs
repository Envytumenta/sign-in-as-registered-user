using OpenQA.Selenium;
using SignInAsRegisteredUser.Hooks;
using SignInAsRegisteredUser.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SignInAsRegisteredUserInvalidEmail.Steps
{
    [Binding]
    public class SignInAsRegisteredUserInvalidEmailSteps
    {
        public IWebDriver driver = WebHook.driver;


        SignInAsRegisteredUserPage signInAsRegisteredUserPage = new SignInAsRegisteredUserPage();



        [Given(@"that user is a registered user- on Giftrete website")]
        public void GivenThatUserIsARegisteredUser_OnGiftreteWebsite()
        {
            driver.Navigate().GoToUrl("https://www.qa2020.giftrete.com/");
        }
        
        [When(@"user click on sign in button")]
        public void WhenUserClickOnSignInButton()
        {
            signInAsRegisteredUserPage.SignInButton();
        }
        
        [When(@"user enter my email address\(""(.*)""\)")]
        public void WhenUserEnterMyEmailAddress(string p0)
        {
            signInAsRegisteredUserPage.EmailAddress();
        }
        
        [When(@"user enter my password\(""(.*)""\)")]
        public void WhenUserEnterMyPassword(string p0)
        {
            signInAsRegisteredUserPage.Password();
        }
        
        [When(@"user tick the remember me box \(Optional\)")]
        public void WhenUserTickTheRememberMeBoxOptional()
        {
            signInAsRegisteredUserPage.RememberMeButton();
        }
        
        [When(@"user click on login to your account button")]
        public void WhenUserClickOnLoginToYourAccountButton()
        {
            signInAsRegisteredUserPage.AccountButton();
        }
        
        [Then(@"user must not be signed in")]
        public void ThenUserMustNotBeSignedIn()
        {
            
        }
    }
}
