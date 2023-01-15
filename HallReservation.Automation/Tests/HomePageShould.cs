using HallReservation.Automation.POM;
using HallReservation.Automation.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HallReservation.Automation.Tests
{
    public class HomePageShould : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            _homePage.GoToHomePage();
        }

        [Test]
        public void LandOnCreateRezervarePageThroughLink() 
        {
            _homePage.GoToCreateRezervarePageThroughLink();
        }

        [Test]
        public void LandOnRezervarePageThroughButton()
        {
            _homePage.GoToRezervarePageThroughButton();
        }

        [Test]
        public void LandOnSalaPageThroughButton()
        {
            _homePage.GoToSaliPageThroughButton();
            _salaPage.LandOnSalaListPage();
        }

        [Test]
        public void LandOnTrupaPageThroughButton()
        {
            _homePage.GoToTrupePageThroughButton();
        }

        [Test]
        public void LandOnEchipamentePageThroughButton()
        {
            _homePage.GoToEchipamentePageThroughButton();
        }
    }
}