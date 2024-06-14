using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace OrangeHRm.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private DriverHelper _driverHelper;

        public static string loginButton = "//*[@id='cdsv']";

        public Hooks1(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [BeforeScenario]
        public  void BeforeScenario()
        {
            Console.WriteLine("Before Test Run");
            ChromeOptions op = new ChromeOptions();
            op.AddArguments("start-maximized");
            op.AddArguments("--disable-gpu");           
               
            _driverHelper.webDriver = new ChromeDriver(op);
             _driverHelper.webDriver.Url = "https://google.com";
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After test run");
            _driverHelper.webDriver.Quit();
        }

    }
}