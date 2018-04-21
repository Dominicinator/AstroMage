using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {
    public float a;
    public float mu;
    public Vector2 ev;
    public float e;
    public float p;
    public float w;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Generate(float aMin, float aMax, float eMin, float eMax, float muIn)
    {
        a = Random.Range(aMin, aMax);
        e = Random.Range(eMin, eMax);
        w = Random.Range(0, 360);
        ev = new Vector2(e * Mathf.Cos(w), e * Mathf.Sin(w));
        w = Mathf.Atan2(ev.x, ev.y);
        mu = muIn;
        p = 2 * Mathf.PI * (Mathf.Pow(a, 3)/mu);
    }
    public Vector2 r(float time)
    {
        float M = 2 * Mathf.PI * p;
        float E = M;
        float En = 0;
        int l = 0;
        while (l++ < 500)
        {
            En = E + (M - (E - e * Mathf.Sin(E))) / (1 - e * Mathf.Cos(E));
            E = En;
            if (Mathf.Abs(En - E) < 1e-6) break;
        }
        float cosTA = (Mathf.Cos(E) - e) / (1 - e * Mathf.Cos(E));
        float sinTA = Mathf.Sqrt(1 - e * e) * Mathf.Sin(E) / (1 - e * Mathf.Cos(E));
        float r_ = a * (1 - e * e) / (1 + e * cosTA);
        Vector2 rr = new Vector2(r_ * cosTA, r_ * sinTA);
        return new Vector2(rr.x*Mathf.Cos(w) - rr.y*Mathf.Sin(w), rr.x * Mathf.Sin(w) + rr.y * Mathf.Cos(w));
        /*let tanx =
          -a * Mathf.Sin(E) * Mathf.Cos(w) -
          b * Mathf.Cos(E) * Mathf.Sin(w);
        let tany =
          b * Mathf.Cos(E) * Mathf.Cos(w) -
          a * Mathf.Sin(E) * Mathf.Sin(w);
        let tangent = new Vector2(tanx, tany).heading();
        v_ = sqrt(mu * (2 / r_ - 1 / a));
        v = new Vector2(
          v_ * Mathf.Cos(tangent - PI / 2),
          v_ * Mathf.Sin(tangent - PI / 2)
        ).rotate(ev.heading() * 2); //totally confused about the 2 scalar on the angle, just eyeballed it and it works perfectly... huh...*/
    }
    public void Show()
    {
        transform.gameObject.AddComponent<LineRenderer>();
        OrbitRenderer o = transform.gameObject.AddComponent<OrbitRenderer>();
        GameObject or = o.transform.gameObject;
        o.xradius = 2;
        o.yradius = 2;
    }
}
