using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

    public Camera myCamera;
    private Vector2 worldCoordinates;
    private GameObject parent;
	// Use this for initialization
	void Start () 
	{
	 parent = GameObject.Find("Defenders");
	 if(!parent)
	 {
	  parent = new GameObject("Defenders");
	 }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	Vector2 SnapToGrid(Vector2 rawPos)
	{
	 int newX = Mathf.RoundToInt(rawPos.x);
	 int newY = Mathf.RoundToInt(rawPos.y);
	 return new Vector2(newX,newY);
	}
	void OnMouseDown()
	{
	 //print (CalculateWorldCoordinate());
	 print (SnapToGrid(CalculateWorldCoordinate()));
	 Vector2 roundedPos = SnapToGrid(CalculateWorldCoordinate());
	 GameObject newDef = Instantiate(Buttons.selectedDefender,roundedPos,Quaternion.identity) as GameObject;
	 newDef.transform.parent = parent.transform;
	}
	Vector2 CalculateWorldCoordinate()
	{
	 float mouseX = Input.mousePosition.x;
	 float mouseY = Input.mousePosition.y;
	 float distanceFromCamera = 10f;
	 Vector3 triplet  = new Vector3(mouseX,mouseY,distanceFromCamera);
	 worldCoordinates = myCamera.ScreenToWorldPoint(triplet);
	 return  worldCoordinates;
	}
}
