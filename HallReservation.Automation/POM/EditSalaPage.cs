using HallReservation.Automation.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallReservation.Automation.POM
{
    public class EditSalaPage : BasePage
    {
        private const string NUME_SALA_BY_ID = "Sala.Nume";
        private const string LOCATIE_SALA_BY_ID = "Sala.Locatie";
        private const string SUPRAFATA_SALA_BY_ID = "Sala.Suprafata";
        private const string SALA_PRET_BY_ID = "Sala.Pret";
        private const string NUME_SALA_INPUT_ERROR_BY_ID = "Sala.Nume-error";
        private const string LOCATIE_SALA_INPUT_ERROR_BY_ID = "Sala.Locatie-error";
        private const string SUPRAFATA_SALA_INPUT_ERROR_BY_ID = "Sala.Suprafata-error";
        private const string PRET_SALA_INPUT_ERROR_BY_ID = "Sala.Pret-error";
        private const string SAVE_SALA_BY_ID = "Edit.Sala.Btn";

        public EditSalaPage(IWebDriver webDriver) : base(webDriver) { }

        protected IWebElement numeSala => _driver.WaitForAndFindElement(By.Id(NUME_SALA_BY_ID));
        protected IWebElement locatieSala => _driver.WaitForAndFindElement(By.Id(LOCATIE_SALA_BY_ID));
        protected IWebElement suprafataSala => _driver.WaitForAndFindElement(By.Id(SUPRAFATA_SALA_BY_ID));
        protected IWebElement pretSala => _driver.WaitForAndFindElement(By.Id(SALA_PRET_BY_ID));
        protected IWebElement saveSalaBtn => _driver.WaitForAndFindElement(By.Id(SAVE_SALA_BY_ID));

        public void SaveEditedSala()
        {
            saveSalaBtn.WaitForAndClickElement();
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

        public void EditNumeSala(string value)
        {
            numeSala.Clear();
            numeSala.WaitForElementAndSendKeys(value);
            ClickAway();
        }

        public void EditSuprafataSala(string value)
        {
            suprafataSala.Clear();
            suprafataSala.WaitForElementAndSendKeys(value);
            ClickAway();
        }

        public void EditLocatieSala(string value)
        {   
            locatieSala.Clear();
            locatieSala.WaitForElementAndSendKeys(value);
            ClickAway();
        }

        public void EditPretSala(string value)
        {   
            pretSala.Clear();
            pretSala.WaitForElementAndSendKeys(value);
            ClickAway();
        }

        private void ClickAway()
        {
            Actions actions = new Actions(_driver);
            actions.MoveByOffset(150, 0).Click().Build().Perform();
        }
    }
}
