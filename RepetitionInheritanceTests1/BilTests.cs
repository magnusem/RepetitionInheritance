using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepetitionInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void RegistreringsAfgiftTestBilpris80500_2015()
        {
            //Arrange
            BenzinBil BBil = new BenzinBil("Audi", 80500, 2015,20,"AB12345",40);
            Assert.AreEqual(84525, BBil.RegistreringsAfgift());
        }
    }
}