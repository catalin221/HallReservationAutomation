using HallReservation.Automation.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallReservation.Automation.Tests
{
    internal class SalaPageShould : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            _homePage.GoToHomePage();
            _homePage.GoToSaliPageThroughButton();
        }

        [Test]
        public void LandOnSalaListPage()
        {
            _salaPage.LandOnSalaListPage();
        }

        [Test]
        public void GoToCreateSalaPage()
        {
            _salaPage.GoToCreateSalaPage();
        }

        [Test]
        public void GoToEditSalaForSala()
        {
            _salaPage.GoToEditSalaPage("Gama");
        }
    }
}
