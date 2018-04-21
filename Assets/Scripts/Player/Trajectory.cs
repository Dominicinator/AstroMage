using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LineRenderer))]
public class Trajectory : MonoBehaviour
{
    private LineRenderer line;
    public float acceleration;
    private Vector2 startPos;
    public Vector2 StartPos
    {
        get
        {
            return startPos / World.scale;
        }
        set
        {
            startPos = value * World.scale;
        }
    }
    private Vector2 endPos;
    public Vector2 EndPos
    {
        get
        {
            return endPos / World.scale;
        }
        set
        {
            endPos = value * World.scale;
        }
    }
    public float FlightTime
    {
        get
        {
            return 2 * Mathf.Sqrt(Vector2.Distance(startPos, endPos)/acceleration);
        }
    }
    public float FlightDeltaV
    {
        get
        {
            return 2 * Mathf.Sqrt(Vector2.Distance(startPos, endPos) * acceleration);
        }
    }
    public Vector2 xt(float time)
    {
        //Integrating constant acc twice gives position, (at^2)/2
        float posMag = acceleration * Mathf.Pow(time, 2) / 2;
        Vector2 posDir = (endPos - startPos) / (endPos - startPos).magnitude;
        return posMag * posDir/World.scale;
    }

	// Use this for initialization
	void Start () {
        line = gameObject.GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
	}
    public void updateLine()
    {
        line.SetPosition(0, startPos/World.scale);
        line.SetPosition(1, endPos/World.scale);
    }
}
