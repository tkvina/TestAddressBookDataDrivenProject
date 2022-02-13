using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestAddressBookDataDrivenWithParameter.Utilities;

namespace TestAddressBookDataDrivenWithParameter.PageObject
{
    class TestAddressBookDataDrivenPage1
    {
        public TestAddressBookDataDrivenPage1()
        {
            driver = TestAddressBookDataDrivenHooks1.driver;
        }
        IWebDriver driver;


        IWebElement SignIn => driver.FindElement(By.XPath("//*[@id='sign-in'] "));

        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement Password => driver.FindElement(By.XPath("//*[@id='session_password'] "));

        IWebElement SignInButton => driver.FindElement(By.XPath(" //*[@id='clearance']/div/div/form/div[3]/input"));

        IWebElement Hamburger => driver.FindElement(By.XPath("/html/body/nav/button/span "));

        public void ClickOnSign()
        {
            SignIn.Click();
        }
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        public void ClickOnSignInButton()
        {
            SignInButton.Click();
        }
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickOnHamburger()
        {
            Hamburger.Click();
        }










    }
}
