using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestImpactAnalysis.Demo.PlanetEarth;

namespace TestImpactAnalysis.Demo.PlanetEarthTests
{
    [TestClass]
    public class CountryFixture
    {
        [TestMethod]
        public void CountrytTest()
        {
            var country = new Country();
            Assert.IsNotNull(country);
        }
    }
}
