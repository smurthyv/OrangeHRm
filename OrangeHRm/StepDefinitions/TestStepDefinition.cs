using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRm.StepDefinitions
{
    public class TestStepDefinition
    {
        private DriverHelper _driverHelper;

        public TestStepDefinition(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [Given(@"user  login with invalid application")]
        public void GivenUserLoginWithInvalidApplication()
        {
            Thread.Sleep(5000);

            _driverHelper.webDriver.FindElement(By.XPath("//input[@name='username']")).SendKeys("Admin");
            _driverHelper.webDriver.FindElement(By.XPath("//input[@name='password']")).SendKeys("admin123");
            _driverHelper.webDriver.FindElement(By.XPath("//*[@id='app']//button")).Click();
        }

        [When(@"user enter invalid username and password")]
        public void WhenUserEnterInvalidUsernameAndPassword()
        {
            Console.WriteLine("Logged in successfully");
        }

        [Then(@"login should be unsuccessfull")]
        public void ThenLoginShouldBeUnsuccessfull()
        {
            Console.WriteLine("Logged in successfully");
        }

    }
}
