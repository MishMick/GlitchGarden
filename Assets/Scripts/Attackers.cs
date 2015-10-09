using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {
    [Range (-1f,1.5f)]
    public float currentspeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  transform.Translate(Time.deltaTime*currentspeed*Vector3.left);
	}
	public void SetSpeed(float speed)
	{
	 currentspeed = speed;
	}
}
