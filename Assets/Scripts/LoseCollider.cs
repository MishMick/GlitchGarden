using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
    private LevelManager levelObj;
	// Use this for initialization
	void Start () 
	{
	levelObj = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
	 levelObj.LoadLevel("LoseScene");
	}
}
