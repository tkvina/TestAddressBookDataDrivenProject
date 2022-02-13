using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestAddressBookDataDrivenWithParameter.PageObject;

namespace TestAddressBookDataDrivenWithParameter.StepDefinitions
{
    [Binding]
    public class TestAddressBookDataDrivenSteps
    {

        TestAddressBookDataDrivenPage1 testAddressBookDataDrivenPage;
        public TestAddressBookDataDrivenSteps()
        {
            testAddressBookDataDrivenPage = new TestAddressBookDataDrivenPage1();
        }
        
        
        
        [Given(@"I Navigate to website ""(.*)""")]
        public void GivenINavigateToWebsite(string url)
        {
            testAddressBookDataDrivenPage.NavigateToWebsite(url);
        }
        
        [Given(@"I click on the Hamburger dropdown")]
        public void GivenIClickOnTheHamburgerDropdown()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on Sign in")]
        public void GivenIClickOnSignIn()
        {
            testAddressBookDataDrivenPage.ClickOnSign();
       }
        
        [Given(@"I Enter Password ""(.*)""")]
        public void GivenIEnterPassword(string password)
        {
            testAddressBookDataDrivenPage.EnterPassword(password);
        }
        
        [When(@"I click on SignUp button")]
        public void WhenIClickOnSignUpButton()
        {
            testAddressBookDataDrivenPage.ClickOnSignInButton();
        }
        
        [Then(@"I should be able to login successfully to register")]
        public void ThenIShouldBeAbleToLoginSuccessfullyToRegister()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I Enter Email ""(.*)""")]
        public void GivenIEnterEmail(string email)
        {
            Thread.Sleep(5000);
            testAddressBookDataDrivenPage.EnterEmail(email);
        }

    }
}
