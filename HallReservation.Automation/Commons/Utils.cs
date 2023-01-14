using HallReservation.Automation.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace HallReservation.Automation.Commons
{
    public class Utils
    {
        private static readonly Random random = new();

        public static void ExplicitWait(int timeInMiliseconds)
        {
            try
            {
                new WebDriverWait(DriverProvider.WebDriver, TimeSpan.FromMilliseconds(timeInMiliseconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("dummyElement")));
            }
            catch (WebDriverTimeoutException) { }
        }


        public static IWebElement FluentWait(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(30))
            {
                PollingInterval = TimeSpan.FromSeconds(5),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            var element = wait.Until(drv => drv.FindElement(by));

            return element;
        }
    }
}
