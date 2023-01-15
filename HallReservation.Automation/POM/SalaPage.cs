using HallReservation.Automation.Commons;
using OpenQA.Selenium;

namespace HallReservation.Automation.POM
{
    public class SalaPage : BasePage
    {
        private const string SALA_PAGE_LANDING_ID_SELECTOR = "Sali.List.Page";
        private const string CREATE_SALA_PAGE_LINK_BY_ID = "Create.Sala.Page";
        private const string NUME_SALA_BY_ID = "Sala.Nume";
        private const string LOCATIE_SALA_BY_ID = "Sala.Locatie";
        private const string SUPRAFATA_SALA_BY_ID = "Sala.Suprafata";
        private const string SALA_PRET_BY_ID = "Sala.Pret";
        private const string EDIT_SALA_LNK_BY_ID = "Edit.Sala.Page.Lnk";
        private const string DELETE_SALA_LNK_BY_ID = "Details.Sala.Page.Lnk";
        private const string NUME_SALA_VALUE_BY_ID = "Sala.Nume.Value";
        private const string LOCATIE_SALA_VALUE_BY_ID = "Sala.Locatie.Value";
        private const string SUPRAFATA_SALA_VALUE_BY_ID = "Sala.Suprafata.Value";
        private const string PRET_SALA_VALUE_BY_ID = "Sala.Pret.Value";
        private const string SALA_LIST_BY_CLASS_NAME = "table";
        private const string SALA_NUME_VALUE_BY_XPATH = "//*[@id=\"Sala.Nume.Value\"]";
        private const string SALA_EDIT_LINK_BY_XPATH = "//*[@id=\"Edit.Sala.Page.Lnk\"]";
        private const string SALA_DETAILS_LINK_BY_XPATH = "//*[@id=\"Details.Sala.Page.Lnk\"]";
        private const string SALA_DELETE_LINK_BY_XPATH = "//*[@id=\"Delete.Sala.Page.Lnk\"]";

        public SalaPage(IWebDriver driver) : base(driver) { }

        protected IWebElement salaPageLanding => _driver.WaitForAndFindElement(By.Id(SALA_PAGE_LANDING_ID_SELECTOR));
        protected IWebElement createSalaPageLnk => _driver.WaitForAndFindElement(By.Id(CREATE_SALA_PAGE_LINK_BY_ID));
        protected IWebElement numeSala => _driver.WaitForAndFindElement(By.Id(NUME_SALA_BY_ID));
        protected IWebElement locatieSala => _driver.WaitForAndFindElement(By.Id(LOCATIE_SALA_BY_ID));
        protected IWebElement suprafataSala => _driver.WaitForAndFindElement(By.Id(SUPRAFATA_SALA_BY_ID));
        protected IWebElement pretSala => _driver.WaitForAndFindElement(By.Id(SALA_PRET_BY_ID));
        protected IWebElement numeSalaValue => _driver.WaitForAndFindElement(By.Id(NUME_SALA_VALUE_BY_ID));
        protected IWebElement locatieSalaValue => _driver.WaitForAndFindElement(By.Id(LOCATIE_SALA_VALUE_BY_ID));
        protected IWebElement suprafataSalaValue  => _driver.WaitForAndFindElement(By.Id(SUPRAFATA_SALA_VALUE_BY_ID));
        protected IWebElement pretSalaValue => _driver.WaitForAndFindElement(By.Id(PRET_SALA_VALUE_BY_ID));
        protected IWebElement editSalaPage => _driver.WaitForAndFindElement(By.Id(EDIT_SALA_LNK_BY_ID));
        protected IWebElement deleteSalaPage => _driver.WaitForAndFindElement(By.Id(DELETE_SALA_LNK_BY_ID));
        protected IWebElement salaList => _driver.WaitForAndFindElement(By.ClassName(SALA_LIST_BY_CLASS_NAME));


        public void LandOnSalaListPage()
        {
            _driver.WaitForAndFindElement(By.Id(SALA_PAGE_LANDING_ID_SELECTOR));
        }

        public void GoToCreateSalaPage()
        {
            createSalaPageLnk.WaitForAndClickElement();
            _driver.WaitForAndFindElement(By.Id(CREATE_SALA_PAGE_LINK_BY_ID));
        }

        public void GoToEditSalaPage(string forRoom)
        {
            salaList.FindLinkForSelection(forRoom, /*SALA_NUME_VALUE_BY_XPATH,*/ SALA_EDIT_LINK_BY_XPATH).WaitForAndClickElement();
        }

        public void GoToDetailsSalaPage(string forRoom)
        {
            salaList.FindLinkForSelection(forRoom, /*SALA_NUME_VALUE_BY_XPATH,*/ SALA_DETAILS_LINK_BY_XPATH).WaitForAndClickElement();
        }

        public void GoToDeleteSalaPage(string forRoom)
        {
            salaList.FindLinkForSelection(forRoom, /*SALA_NUME_VALUE_BY_XPATH,*/ SALA_DELETE_LINK_BY_XPATH).WaitForAndClickElement();
        }

    }
}
