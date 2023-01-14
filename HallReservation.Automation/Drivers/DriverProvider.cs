using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HallReservation.Automation.Drivers
{
    public static class DriverProvider
    {
        private static IWebDriver _driver;
        public static IWebDriver WebDriver
        {
            get
            {
                if (_driver == null)
                {
                    var timeout = 60;

                    var chromeOptions = new ChromeOptions();

                    chromeOptions.AddArgument("--window-size=1920,1080");
                    _driver = new ChromeDriver(chromeOptions);
                    _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeout);
                    _driver.Url = "https://localhost:7109";
                }

                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
    }
}
