using System.Collections.Generic;
using TestImpactAnalysis.Demo.PlanetEarth;

namespace TestImpactAnalysis.Demo.SolarSystem
{
    public class PlanetEarth : IPlanet 
    {
        public IEnumerable<Continent> Continents { get; set; }
    }
}
