using HallReservation.Automation.POM;
using HallReservation.Automation.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HallReservation.Automation
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
        public void LandOnSalaPageThroughButoon()
        {
            _homePage.GoToSaliPageThroughButton();
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