using System;
using System.Collections.Generic;

namespace TestImpactAnalysis.Demo.SolarSystem
{
    public class PlanetsRepository
    {
        public IEnumerable<IPlanet> Planets { get; set; }

        public PlanetsRepository()
        {
            Planets = new List<IPlanet>()
            {
                new PlanetEarth(),
                new PlanetMars()
            };
        }
    }
}
