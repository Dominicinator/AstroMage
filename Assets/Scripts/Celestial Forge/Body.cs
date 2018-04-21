using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour {
    public Orbit orbit;
    public Player player;
    public float mass;
    public float radius;
	
	void Start () {
        player = GameObject.Find("Player").GetComponent<Player>();
	}
	
	
	void FixedUpdate()
    {
		
	}
    public void generatePlanet()
    {
        Body parent = transform.parent.GetComponent<Body>();
        GameObject Oorbit = new GameObject("Orbit");
        Oorbit.transform.parent = transform;
        orbit = Oorbit.AddComponent<Orbit>();
        orbit.Generate(0.1f, 20f, 0f, 0.001f,(parent.mass+mass)*units.G);

    }
    public void generateStar(float metallicity, float massLow, float massHigh)
    {

    }
}
