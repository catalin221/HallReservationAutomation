namespace HallReservation.Automation.Tests
{
    public class CreateSalaPageShould : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            _homePage.GoToHomePage();
            _homePage.GoToSaliPageThroughButton();
            _salaPage.GoToCreateSalaPage();
        }

        [Test]
        public void DisplayErrorOnNegativeSuprafataValue()
        {
            _createSalaPage.InputSuprafataSala("-1");
            _createSalaPage.DisplaySuprafataSalaInputError();
        }

        [Test]
        public void DisplayAllErrorsWhenInputIsMissingAndCreateButtonIsClicked()
        {
            _createSalaPage.InputNumeSala("");
            _createSalaPage.InputLocatieSala("");
            _createSalaPage.InputSuprafataSala("");
            _createSalaPage.InputPretSala("");
            _createSalaPage.CreateSala();
            _createSalaPage.DisplayNumeSalaInputError();
            _createSalaPage.DisplayLocatieSalaInputError();
            _createSalaPage.DisplaySuprafataSalaInputError();
            _createSalaPage.DisplayPretSalaInputError();
        }

        [Test]
        public void CreateSalaAndReturnUserToSalaListOnValidInput()
        {
            _createSalaPage.InputNumeSala("Testt");
            _createSalaPage.InputLocatieSala("21 Dec 1918");
            _createSalaPage.InputSuprafataSala("25");
            _createSalaPage.InputPretSala("30");
            _createSalaPage.CreateSala();
            _salaPage.LandOnSalaListPage();
        }

    }
}
