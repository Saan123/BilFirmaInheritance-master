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
    public class DieselbilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest_som_kører_20kml_inklPartikelfilter()
        {
            Dieselbil DieselBil = new Dieselbil(81000, 2014, "AUDI", "BC68371", 20, 60, true);
            int afgit = DieselBil.HalvÅrligEjerAfgift();

            Assert.AreEqual(1000, afgit);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest_som_kører_14kml_inklPartikelfilter()
        {
            Dieselbil DieselBil = new Dieselbil(81000, 2014, "AUDI", "BC68371", 14, 60, true);
            int afgit = DieselBil.HalvÅrligEjerAfgift();


            Assert.AreEqual(2000, afgit);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest_som_kører_29kml_inklPartikelfilter()
        {
            Dieselbil DieselBil = new Dieselbil(81000, 2014, "AUDI", "BC68371", 29, 60, true);
            int afgit = DieselBil.HalvÅrligEjerAfgift();


            Assert.AreEqual(350, afgit);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest_som_kører_29kml_eksklPartikelfilter()
        {
            Dieselbil DieselBil = new Dieselbil(81000, 2014, "AUDI", "BC68371", 29, 60, false);
            int afgit = DieselBil.HalvÅrligEjerAfgift();


            Assert.AreEqual(850, afgit);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest_som_kører_20kml_ekslPartikelfilter()
        {
            Dieselbil DieselBil = new Dieselbil(81000, 2014, "AUDI", "BC68371", 20, 60, false);
            int afgit = DieselBil.HalvÅrligEjerAfgift();

            Assert.AreEqual(1500, afgit);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftTest_som_kører_14kml_ekslPartikelfilter()
        {
            Dieselbil DieselBil = new Dieselbil(81000, 2014, "AUDI", "BC68371", 14, 60, false);
            int afgit = DieselBil.HalvÅrligEjerAfgift();

            Assert.AreEqual(2500, afgit);
        }

    }
}