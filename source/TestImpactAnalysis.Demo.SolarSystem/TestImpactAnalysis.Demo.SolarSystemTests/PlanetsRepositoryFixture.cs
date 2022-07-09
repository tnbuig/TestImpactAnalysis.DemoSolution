using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestImpactAnalysis.Demo.SolarSystem;

namespace TestImpactAnalysis.Demo.SolarSystemTests
{
    [TestClass]
    public class PlanetsRepositoryFixture
    {
        [TestMethod]
        public void PlanetsRepositoryTests()
        {
            var planetsRepository = new PlanetsRepository();

            Assert.IsNotNull(planetsRepository);
        }
    }
}
