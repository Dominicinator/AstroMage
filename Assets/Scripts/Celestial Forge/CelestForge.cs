using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestForge : MonoBehaviour {
    public void GenerateStarSystem(int planetNum, string orbital_configuration, string stellar_configuration)
    {
        Body mainStarb;
        StarSystem starSystemS;
        GameObject starSystem = new GameObject("StarSystem");
        GameObject mainStar = new GameObject("MainStar");
        //Configuring starSystem
        starSystem.AddComponent<StarSystem>();
        starSystemS = starSystem.GetComponent<StarSystem>();
        starSystemS.orbitalConfiguration = orbital_configuration;
        starSystemS.stellarConfiguration = stellar_configuration;
        //Configuring mainStar
        mainStar.transform.parent = starSystem.transform;
        mainStar.AddComponent<Body>();
        mainStarb = mainStar.GetComponent<Body>();
        mainStarb.generateStar(0f, 0f, 0f);
        //Generating planets
        starSystemS.planets = new GameObject[planetNum];
        for (int i = 0; i < planetNum; i++)
        {
            GameObject planet = starSystemS.planets[i];
            planet.AddComponent<Body>();
            planet.name = "Planet " + (i+1);
            planet.transform.parent = mainStar.transform;
            Body planetB = planet.GetComponent<Body>();
            planetB.generatePlanet();
        }


    }
}
//Orbital configurations:
/*Planetary systems can be categorized according to their orbital dynamics as 
 * resonant, (integer ratios of orbital period)
 * non-resonant-interacting, (random)
 * hierarchical, (one or more bodies could be considered as one object [eg close in gas-giant with lots of terrestrial planets farther away])
 * or some combination of these.
 * In resonant systems the orbital periods of the planets are in integer ratios. The Kepler-223 system contains four planets in an 8:6:4:3 orbital resonance.[51] Giant planets are found in mean-motion resonances more often than smaller planets.[52] In interacting systems the planets orbits are close enough together that they perturb the orbital parameters. The Solar System could be described as weakly interacting. In strongly interacting systems Kepler's laws do not hold.[53] In hierarchical systems the planets are arranged so that the system can be gravitationally considered as a nested system of two-bodies, e.g. in a star with a close-in hot jupiter with another gas giant much further out, the star and hot jupiter form a pair that appears as a single object to another planet that is far enough out. */
