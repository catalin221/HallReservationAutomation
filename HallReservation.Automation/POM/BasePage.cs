using HallReservation.Automation.Drivers;
using OpenQA.Selenium;

namespace HallReservation.Automation.POM
{
    public class BasePage
    {
        public IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
          _driver = DriverProvider.WebDriver;
        }

        public void GoToHomePage()
        {
            _driver.Navigate().GoToUrl(_driver.Url);
        }
    }
}
