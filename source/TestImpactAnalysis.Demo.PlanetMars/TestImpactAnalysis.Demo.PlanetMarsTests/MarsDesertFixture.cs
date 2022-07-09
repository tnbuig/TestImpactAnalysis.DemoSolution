using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestImpactAnalysis.Demo.PlanetMars;

namespace TestImpactAnalysis.Demo.PlanetMarsTests
{
    [TestClass]
    public class MarsDesertFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
            var marsDesert = new MarsDesert();
            Assert.IsNotNull(marsDesert);
        }
    }
}
