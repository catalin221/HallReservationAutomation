using HallReservation.Automation.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HallReservation.Automation.POM
{
    public class CreateSalaPage : BasePage
    {
        private const string SALA_NUME_INPUT_BY_ID_ = "Nume.Sala";
        private const string SALA_LOCATIE_INPUT_BY_ID = "Locatie.Sala";
        private const string SALA_SUPRAFATA_INPUT_BY_ID = "Suprafata.Sala";
        private const string SALA_PRET_INPUT_BY_ID = "Pret.Sala";
        private const string NUME_SALA_INPUT_ERROR_BY_ID = "Nume.Sala-error";
        private const string LOCATIE_SALA_INPUT_ERROR_BY_ID = "Locatie.Sala-error";
        private const string SUPRAFATA_SALA_INPUT_ERROR_BY_ID = "Suprafata.Sala-error";
        private const string PRET_SALA_INPUT_ERROR_BY_ID = "Pret.Sala-error";
        private const string CREATE_SALA_BTN_BY_ID = "Salveaza.Sala.Btn";

        public CreateSalaPage(IWebDriver driver) : base(driver) { }

        private IWebElement inputNumeSala => _driver.WaitForAndFindElement(By.Id(SALA_NUME_INPUT_BY_ID_));
        private IWebElement inputLocatieSala => _driver.WaitForAndFindElement(By.Id(SALA_LOCATIE_INPUT_BY_ID));
        private IWebElement inputSuprafataSala => _driver.WaitForAndFindElement(By.Id(SALA_SUPRAFATA_INPUT_BY_ID));
        private IWebElement inputPretSala => _driver.WaitForAndFindElement(By.Id(SALA_PRET_INPUT_BY_ID));
        private IWebElement createSalaBtn => _driver.WaitForAndFindElement(By.Id(CREATE_SALA_BTN_BY_ID));

        public void CreateSala()
        {
            createSalaBtn.WaitForAndClickElement();
        }

        public void DisplayNumeSalaInputError()
        {
            _driver.WaitForAndFindElement(By.Id(NUME_SALA_INPUT_ERROR_BY_ID));
        }

        public void DisplayLocatieSalaInputError()
        {
            _driver.WaitForAndFindElement(By.Id(LOCATIE_SALA_INPUT_ERROR_BY_ID));
        }

        public void DisplaySuprafataSalaInputError()
        {
            _driver.WaitForAndFindElement(By.Id(SUPRAFATA_SALA_INPUT_ERROR_BY_ID));
        }

        public void DisplayPretSalaInputError()
        {
            _driver.WaitForAndFindElement(By.Id(PRET_SALA_INPUT_ERROR_BY_ID));
        }

        public void InputNumeSala(string numeSala)
        {
            inputNumeSala.WaitForElementAndSendKeys(numeSala);
            ClickAway();
        }

        public void InputLocatieSala(string locatieSala)
        {
            inputLocatieSala.WaitForElementAndSendKeys(locatieSala);
            ClickAway();
        }

        public void InputSuprafataSala(string suprafata)
        {
            inputSuprafataSala.WaitForElementAndSendKeys(suprafata);
            ClickAway();
        }

        public void InputPretSala(string pret)
        {
            inputPretSala.WaitForElementAndSendKeys(pret);
            ClickAway();
        }

        private void ClickAway()
        {
            Actions actions = new Actions(_driver);
            actions.MoveByOffset(150, 0).Click().Build().Perform();
        }
    }
}
