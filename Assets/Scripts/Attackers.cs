using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {
    [Range (-1f,1.5f)]
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  transform.Translate(Time.deltaTime*speed*Vector3.left);
	}
	public float GetSpeed()
	{
	 return speed;
	}
}
