using UnityEngine;
using System.Collections;

public class Lizard : MonoBehaviour {
     private Attackers atkObj;
     private Animator anim;
	// Use this for initialization
	void Start () {
	  atkObj = GetComponent<Attackers>();
	  anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Collider triggered this event in Lizard");
		GameObject obj = collider.gameObject;
		if(obj.GetComponent<Stone>())
		{
		 anim.SetBool("isAttacking",true);
		 atkObj.Attack(obj);	
		}
		if(!obj.GetComponent<Defenders>())
		{
		 return;
		}
		else
		{
		 anim.SetBool("isAttacking",true);
		 atkObj.Attack(obj);
		}
	}
}
