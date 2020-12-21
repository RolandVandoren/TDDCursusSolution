using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling.Veiling veiling;

        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling.Veiling();
        }

        [TestMethod]
        public void ZonderBodIsHetHoogsteBodNul()
        {            
            Assert.AreEqual(0m, veiling.HoogsteBod);
        }
        [TestMethod]
        public void HetEersteBodIsGelijkAanHetHoogsteBod()
        {
            //var veiling = new Veiling.Veiling();
            veiling.DoeBod(1000m);
            Assert.AreEqual(1000m, veiling.HoogsteBod);
        }
        [TestMethod]
        public void BijMeedereBodenIsHetHoogsteBodGelijkAanHetHoogsteBod()
        {
            //var veiling = new Veiling.Veiling();
            veiling.DoeBod(1000m);
            veiling.DoeBod(500m);
            Assert.AreEqual(1000m, veiling.HoogsteBod);
        }
    }
}
