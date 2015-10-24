using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject[] attackerPrefabArray;
	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update () 
	{
	 foreach(GameObject thisAttacker in attackerPrefabArray)
	 {
	  if(isTimeToSpawn(thisAttacker))
	  {
	    SpawnThisAttacker(thisAttacker);
	  }
	 }
	}
	void SpawnThisAttacker(GameObject thisAttacker)
	{
	 GameObject newAttacker = Instantiate(thisAttacker) as GameObject;
	 newAttacker.transform.parent = transform;
	 newAttacker.transform.position = transform.position;
	}
	bool isTimeToSpawn(GameObject attackerGameObject)
	{
		float meanSpawnDelay = 5f;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		
		if (Time.deltaTime > meanSpawnDelay) {
			Debug.LogWarning ("Spwan rate capped by frame rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime /5;
	 return (Random.value<threshold);
	}
}
