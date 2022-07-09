using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestImpactAnalysis.Demo.PlanetEarth;

namespace TestImpactAnalysis.Demo.PlanetEarthTests
{
    [TestClass]
    public class ContinentFixture
    {
        [TestMethod]
        public void ContinentTest()
        {
            var continent = new Continent();
            Assert.IsNotNull(continent);
        }
    }
}
