using HallReservation.Automation.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallReservation.Automation.Tests
{
    internal class SalaPageShould
    {
        [SetUp]
        public new void SetUp()
        {
            _homePage.GoToHomePage();
        }
    }
}
