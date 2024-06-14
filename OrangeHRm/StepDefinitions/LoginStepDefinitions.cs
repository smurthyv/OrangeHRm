using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRm.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {


        private DriverHelper _driverHelper;

        public LoginStepDefinitions(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [Given(@"user  login to application")]
        public void LoginToApplication()
        {
             // _driverHelper.Driver.FindElement(By.Id("")).Click();
        }

        [When(@"user enter valid username and password")]
        public void WhenUserEnterValidUsernameAndPassword()
        {
            Thread.Sleep(5000);

            _driverHelper.webDriver.FindElement(By.XPath("//input[@name='username']")).SendKeys("Admin");
            _driverHelper.webDriver.FindElement(By.XPath("//input[@name='password']")).SendKeys("admin123");
            _driverHelper.webDriver.FindElement(By.XPath("//*[@id='app']//button")).Click();

        }

        [Then(@"login should be successfull")]
        public void ThenLoginShouldBeSuccessfull()
        {
            Console.WriteLine("Logged in successfully");
        }
    }
}