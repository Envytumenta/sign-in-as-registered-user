using OpenQA.Selenium;
using SignInAsRegisteredUser.Hooks;
using SignInAsRegisteredUser.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SignInAsRegisteredUser.Steps
{
    [Binding]
    public class SignInAsRegisteredUserSteps
    {
        public IWebDriver driver = WebHook.driver;

        SignInAsRegisteredUserPage signInAsRegisteredUserPage = new SignInAsRegisteredUserPage();



        [Given(@"that I am a registered user- on Giftrete website \(www\.giftrete\.com\)")]

        public void GivenThatIAmARegisteredUser_OnGiftreteWebsiteWww_Giftrete_Com()
        {
            driver.Navigate().GoToUrl("https://www.qa2020.giftrete.com/");
        }
        
        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            signInAsRegisteredUserPage.SignInButton();
        }

        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            signInAsRegisteredUserPage.EmailAddress();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            signInAsRegisteredUserPage.Password();
        }
        
        [When(@"I tick the remember me box \(Optional\)")]
        public void WhenITickTheRememberMeBoxOptional()
        {
            signInAsRegisteredUserPage.RememberMeButton();
        }
        
        [When(@"I click on login to your account button")]
        public void WhenIClickOnLoginToYourAccountButton()
        {
            signInAsRegisteredUserPage.AccountButton();
        }
        
        [Then(@"I must be signed in")]
        public void ThenIMustBeSignedIn()
        {
           
        }
    }
}
