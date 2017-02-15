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
    public class BilTests
    {
        [TestMethod()]
        public void bilpris_er_80500_i_2015()
        {
            //arange
            BenzinBil BenzinBil = new BenzinBil(80500, 2014, "BMW", "bc68371", 17, 30000);

            //act
            int afgift = BenzinBil.Registreringsafgift();

            //assert
            Assert.AreEqual(84525, afgift);
        }

        [TestMethod()]
        public void bilpris_er_80700_i_2015()
        {
            //arange
            BenzinBil BenzinBil = new BenzinBil(80500, 2014, "BMW", "bc68371", 17, 30000);

            //act
            int afgift = BenzinBil.Registreringsafgift();

            //assert
            Assert.AreEqual(84525, afgift);
        }



        [TestMethod()]
        public void bilpris_er_81000_i_2014()
        {
            //arrange
            BenzinBil BenzinBil = new BenzinBil(81000, 2014, "AUDI", "BC8321", 18, 60);

            //act
            int afgift = BenzinBil.Registreringsafgift();

            //assert
            Assert.AreEqual(85425, afgift);
        }
        //85425
        //

        [TestMethod()]
        public void Halvårlig_afgift_for_18kml()
        {
            //arrange
            BenzinBil BenzinBil = new BenzinBil(81000, 2014, "AUDI", "BC8321", 18, 60);

            //act
            int afgift = BenzinBil.HalvÅrligEjerAfgift();

            //assert
            Assert.AreEqual(1200, afgift);
        }

        [TestMethod()]
        public void Halvårlig_afgift_for_29kml_benzilbil()
        {
            //arrange
            BenzinBil BenzinBil = new BenzinBil(81000, 2014, "AUDI", "BC8321", 29, 60);

            //act
            int afgift = BenzinBil.HalvÅrligEjerAfgift();

            //assert
            Assert.AreEqual(320, afgift);
        }

        [TestMethod()]
        public void Halvårlig_afgift_for_25kml_benzilbil()
        {
            //arrange
            BenzinBil BenzinBil = new BenzinBil(81000, 2014, "AUDI", "BC8321", 25, 60);

            //act
            int afgift = BenzinBil.HalvÅrligEjerAfgift();

            //assert
            Assert.AreEqual(600, afgift);
            //
        }

    }
}