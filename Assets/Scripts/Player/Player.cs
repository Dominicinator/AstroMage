using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject trajectoryObject;
    [HideInInspector]
    public Trajectory trajectory;
	void Start () {
        trajectory = trajectoryObject.GetComponent<Trajectory>();
	}
	
	
	void FixedUpdate () {
        Controls();
	}
    public void Controls()
    {
        if(Input.GetMouseButtonDown(0))
        {

        }
        if(Input.GetMouseButtonDown(1))
        {
            trajectory.StartPos = transform.position;
            trajectory.EndPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            trajectory.updateLine();
        }
        
    }
}
