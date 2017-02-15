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
    public class ElBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest()
        {
            //Arrange

            ElBil Eb = new ElBil("BMW i3", 304.900, 2014, "AB12345", 30, 166);

            //Act

            Assert.Fail(0,);
        }
    }
}