using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Trajectory trajectory;
	
	void Start () {
		
	}
	
	
	void Update () {
        trajectory.startPos = transform.position;
        Vector3 temp_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        temp_pos.z = 0f;
        trajectory.endPos = temp_pos;
        transform.position = trajectory.endPos;
	}
}
