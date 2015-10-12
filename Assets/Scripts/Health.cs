using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public float healthVal=100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void DamageDealt(float damage)
	{
	 healthVal -= damage;
	 Debug.Log (healthVal);
	 if(healthVal<0)
	 {
	  Debug.Log("Destroy this object");
	  Destroy(gameObject);
	 }
	}
}
