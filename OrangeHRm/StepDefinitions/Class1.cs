using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRm.StepDefinitions
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Class1
    {
        [SetUp]
        public void setup()
        {
            _driverHelper.webDriver = new ChromeDriver(op);
            _driverHelper.webDriver.Url = "https://google.com";
        }

    }
}
