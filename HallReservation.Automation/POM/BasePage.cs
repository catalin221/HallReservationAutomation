using HallReservation.Automation.Drivers;
using OpenQA.Selenium;

namespace HallReservation.Automation.POM
{
    public class BasePage
    {
        public IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
