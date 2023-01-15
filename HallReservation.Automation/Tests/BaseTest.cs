using HallReservation.Automation.Drivers;
using HallReservation.Automation.POM;
using OpenQA.Selenium;

namespace HallReservation.Automation.Tests
{
    public class BaseTest
    {
        private IWebDriver _driver;

        protected IWebDriver Driver { get { return _driver; } }

        protected HomePage _homePage;
        protected SalaPage _salaPage;
        protected CreateSalaPage _createSalaPage;
        protected EditSalaPage _editSalaPage;

        public BaseTest()
        {
            if (_driver == null)
            {
                _driver = new DriverProviderInstance().WebDriver;
            }
        }

        [OneTimeSetUp]
        public void SetUp()
        {
            _homePage = new(Driver);
            _salaPage = new(Driver);
            _createSalaPage = new(Driver);
            _editSalaPage = new(Driver);
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
