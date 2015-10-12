using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {
    [Range (-1f,1.5f)]
    public float currentspeed;
    private GameObject currentTarget;
    private Animator anim;
	// Use this for initialization
	void Start () {
	anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!currentTarget)
		{
			anim.SetBool("isAttacking",false);
		}
	  transform.Translate(Time.deltaTime*currentspeed*Vector3.left);
	}
	public void SetSpeed(float speed)
	{
	 currentspeed = speed;
	}
	public void StrikeCurrentTarget(float damage)
	{
	if(currentTarget)
	{
	Health health = currentTarget.GetComponent<Health>();
	if(health)
	{
	 health.DamageDealt(damage);
	}
	}
	}
	public void Attack(GameObject Target)
	{
	 currentTarget =  Target;
	}
}
