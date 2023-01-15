using HallReservation.Automation.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallReservation.Automation.Tests
{
    public class EditSalaPageShould : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            _homePage.GoToHomePage();
            _homePage.GoToSaliPageThroughButton();
            _salaPage.GoToEditSalaPage("Testt");
        }

        [Test]
        public void DisplayErrorOnNegativeSuprafataValue()
        {
            _editSalaPage.EditSuprafataSala("-1");
            _editSalaPage.DisplaySuprafataSalaInputError();
        }

        [Test]
        public void DisplayAllErrorsWhenInputIsMissingAndSaveButtonIsClicked()
        {
            _editSalaPage.EditNumeSala("");
            _editSalaPage.EditLocatieSala("");
            _editSalaPage.EditSuprafataSala("");
            _editSalaPage.EditPretSala("");
            _editSalaPage.SaveEditedSala();
            _editSalaPage.DisplayNumeSalaInputError();
            _editSalaPage.DisplayLocatieSalaInputError();
            _editSalaPage.DisplaySuprafataSalaInputError();
            _editSalaPage.DisplayPretSalaInputError();
        }

        [Test]
        public void SaveEditedSalaAndReturnUserToSalaListOnValidInput()
        {
            _editSalaPage.EditNumeSala("TestModified");
            _editSalaPage.EditLocatieSala("LocatieModified");
            _editSalaPage.EditSuprafataSala("30");
            _editSalaPage.EditPretSala("40");
            _editSalaPage.SaveEditedSala();
            _salaPage.LandOnSalaListPage();
        }

    }
}
