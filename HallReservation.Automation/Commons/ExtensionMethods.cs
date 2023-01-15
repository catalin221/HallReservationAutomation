using HallReservation.Automation.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HallReservation.Automation.Commons
{
    static class ExtensionMethods
    {
        private const int RETRY_ATTEMPTS = 3;
        private const int WEB_DRIVER_TIMEOUT_SECONDS = 10;
        private const int WEB_DRIVER_SLEEP_MILLISECONDS = 100;

        public static IWebElement FindLinkForSelection(this IWebElement table, string targetName, string xpathLinkId)
        {
            var rows = table.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                var tds = row.FindElements(By.TagName("td"));
                foreach (var td in tds)
                {
                    var name = td.Text;
                    if (name == targetName)
                    {
                        var link = row.FindElement(By.XPath(xpathLinkId));
                        return link;
                    }
                }
            }
            return null;
        }


        public static void WaitForElementAndSendKeys(this IWebElement webElement, string keyToSend)
        {
            int attempts = 0;
            IWebElement element = null;
            while (attempts < RETRY_ATTEMPTS)
            {
                try
                {
                    WebDriverWait wait = new(DriverProvider.WebDriver, TimeSpan.FromSeconds(WEB_DRIVER_TIMEOUT_SECONDS));
                    WaitForReadyState(wait);
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));

                    if (webElement.Enabled)
                    {
                        webElement.Click();
                        webElement.SendKeys(keyToSend);
                        break;
                    }
                    else
                    {
                        Utils.ExplicitWait(WEB_DRIVER_SLEEP_MILLISECONDS);
                        attempts++;
                    }
                }
                catch
                {
                    attempts++;
                    if (attempts == 3)
                    {
                        throw;
                    }
                    Utils.ExplicitWait(WEB_DRIVER_SLEEP_MILLISECONDS);
                }
            }
        }

        public static IWebElement WaitForAndFindElement(this IWebDriver driver, By by)
        {
            int attempts = 0;
            IWebElement element = null;
            while (attempts < RETRY_ATTEMPTS)
            {
                try
                {
                    WebDriverWait wait = new(driver, TimeSpan.FromSeconds(WEB_DRIVER_TIMEOUT_SECONDS));
                    WaitForReadyState(wait);
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));

                    element = driver.FindElement(by);

                    if (element != null)
                    {
                        return element;
                    }
                    else
                    {
                        Utils.ExplicitWait(WEB_DRIVER_SLEEP_MILLISECONDS);
                        attempts++;
                    }
                }
                catch
                {
                    attempts++;
                    if (attempts == 3)
                    {
                        throw;
                    }
                    Utils.ExplicitWait(WEB_DRIVER_SLEEP_MILLISECONDS);
                }
            }

            return null;
        }

        public static void WaitForAndClickElement(this IWebElement webElement)
        {
            int attempts = 0;
            while (attempts < 3)
            {
                try
                {
                    WebDriverWait wait = new(DriverProvider.WebDriver, TimeSpan.FromSeconds(WEB_DRIVER_TIMEOUT_SECONDS));
                    WaitForReadyState(wait);
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));

                    if (webElement.Enabled)
                    {
                        webElement.Click();
                        break;
                    }
                    else
                    {
                        Utils.ExplicitWait(WEB_DRIVER_SLEEP_MILLISECONDS);
                        attempts++;
                    }

                }
                catch
                {
                    attempts++;
                    if (attempts == 3)
                    {
                        throw;
                    }
                    Utils.ExplicitWait(WEB_DRIVER_SLEEP_MILLISECONDS);
                }
            }
        }

        public static void WaitForTextToBePresentInElement(this IWebElement webElement, string text)
        {
            int attempts = 0;
            while (attempts < 3)
            {
                try
                {
                    WebDriverWait wait = new(DriverProvider.WebDriver, TimeSpan.FromSeconds(WEB_DRIVER_TIMEOUT_SECONDS));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(webElement, text));
                    break;
                }
                catch (Exception)
                {
                    attempts++;
                    if (attempts == 3) throw;
                    Utils.ExplicitWait(WEB_DRIVER_SLEEP_MILLISECONDS);
                }
            }
        }

        private static void WaitForReadyState(WebDriverWait wait)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverProvider.WebDriver;
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
            wait.Until(wd => js.ExecuteScript("return window.jQuery != undefined && jQuery.active === 0"));
        }
    }
}
