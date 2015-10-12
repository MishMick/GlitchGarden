using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
    public static GameObject selectedDefender;
    public GameObject defenderPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
	 print (name+" pressed");
	 selectedDefender = defenderPrefab;
	}
}
