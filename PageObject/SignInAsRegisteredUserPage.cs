using OpenQA.Selenium;
using SignInAsRegisteredUser.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SignInAsRegisteredUser.PageObject
{

    class SignInAsRegisteredUserPage
    {
        public IWebDriver driver;

        public SignInAsRegisteredUserPage()
        {
            driver = WebHook.driver;
        }
        
        private By signInButton = By.XPath("//*[contains(text(),'Sign In')]");
        private By emailAddress = By.Id("user_email");
        private By password = By.Id("user_password");
        private By rememberMeBox = By.CssSelector("div.landing-form>div:nth-child(1)>form>div.form-row.space-between>div:nth-child(1)>div label");
        private By accountButton = By.Id("btn_signin");
        public void SignInButton()
        {
            
            driver.FindElement(signInButton).Click();
        }

        public void EmailAddress()
        {
            Thread.Sleep(10000);
            driver.FindElement(emailAddress).SendKeys("mantiti@mail.com");
        }

        public void Password()
        {
            driver.FindElement(password).SendKeys("Asernal");
        }

        public void RememberMeButton()
        {
            driver.FindElement(rememberMeBox).Click();
        }

        public void AccountButton()
        {
            driver.FindElement(accountButton).Click();
        }









    }

}
