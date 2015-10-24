using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    public float speed,damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 transform.Translate(Vector3.right*speed*Time.deltaTime);
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
	 GameObject enemy = collider.gameObject;
	 if(enemy.GetComponent<Attackers>())
	 {
	  Health healthObj = enemy.GetComponent<Health>();
	  healthObj.DamageDealt(damage);
	  Destroy(gameObject);
	 }
	 
	}
	void CauseDamage()
	{
	 
	}
}
