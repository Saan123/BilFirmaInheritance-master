using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning.Tests
{
    [TestClass()]
    public class ElBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest()
        {
            //arange
            ElBil elbil = new ElBil(12300, 2017, "BMW", "bc68371", 17, 30000);

            //act
            int afgift = elbil.HalvÅrligEjerAfgift();

            //assert
            Assert.AreEqual(0, afgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest_som_kører_20_kml()
        {
            ElBil Elbil = new ElBil(81000, 2014, "AUDI", "BC68371", 14, 60);
            int afgit = Elbil.HalvÅrligEjerAfgift();

            Assert.AreEqual(0, afgit);
        }

    }
}