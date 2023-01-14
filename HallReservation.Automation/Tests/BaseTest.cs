using HallReservation.Automation.Drivers;
using HallReservation.Automation.POM;
using OpenQA.Selenium;

namespace HallReservation.Automation.Tests
{
    public class BaseTest
    {
        protected IWebDriver _driver = DriverProvider.WebDriver;
        protected HomePage _homePage;

        public BaseTest() 
        {
            _homePage = new HomePage(_driver);
        }   

        [SetUp] 
        public void SetUp() 
        {
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
