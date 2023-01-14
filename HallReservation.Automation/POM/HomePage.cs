using HallReservation.Automation.Commons;
using OpenQA.Selenium;

namespace HallReservation.Automation.POM
{
    public class HomePage : BasePage
    {
        private const string CREATE_REZERVARE_PAGE_REDIRECT_ID_SELECTOR = "Rezervare";
        private const string REZERVARE_PAGE_REDIRECT_BUTTON_ID_SELECTOR = "RezervareButton";
        private const string TRUPE_PAGE_REDIRECT_BUTTON_ID_SELECTOR = "TrupeButton";
        private const string SALI_PAGE_REDIRECT_BUTTON_ID_SELECTOR = "SaliButton";
        private const string ECHIPAMENTE_PAGE_REDIRECT_BUTTON_ID_SELECTOR = "EchipamenteButton";

        protected IWebElement createRezervarePageByLink => _driver.WaitForAndFindElement(By.Id(CREATE_REZERVARE_PAGE_REDIRECT_ID_SELECTOR));
        protected IWebElement rezervarePageByButton => _driver.WaitForAndFindElement(By.Id(REZERVARE_PAGE_REDIRECT_BUTTON_ID_SELECTOR));
        protected IWebElement trupePageByButton => _driver.WaitForAndFindElement(By.Id(TRUPE_PAGE_REDIRECT_BUTTON_ID_SELECTOR));
        protected IWebElement saliPageByButton => _driver.WaitForAndFindElement(By.Id(SALI_PAGE_REDIRECT_BUTTON_ID_SELECTOR));
        protected IWebElement echipamentePageByButton => _driver.WaitForAndFindElement(By.Id(ECHIPAMENTE_PAGE_REDIRECT_BUTTON_ID_SELECTOR));



        public HomePage(IWebDriver drive) : base(drive) { }

        public void GoToCreateRezervarePageThroughLink()
        {
            createRezervarePageByLink.WaitForAndClickElement();
        }
        public void GoToRezervarePageThroughButton()
        {
            rezervarePageByButton.WaitForAndClickElement();
        }
        public void GoToTrupePageThroughButton()
        {
            trupePageByButton.WaitForAndClickElement();
        }
        public void GoToSaliPageThroughButton()
        {
            saliPageByButton.WaitForAndClickElement();
        }
        public void GoToEchipamentePageThroughButton()
        {
            echipamentePageByButton.WaitForAndClickElement();
        }
    }
}
