using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {
    public static float scale = units.AU; // 1 : [scale] where [scale] is meters and 1 is one unity unit
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}
    public void Add(Transform t, Vector3 p)
    {
        t.SetParent(transform);
        t.transform.localPosition = p / scale;
    }

}
