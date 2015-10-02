using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}
    void Start()
    { 
     if(autoLoadNextLevelAfter !=0)
     Invoke ("LoadNextLevel" , autoLoadNextLevelAfter);
    }
	public void QuitRequest(){
		Application.Quit ();
	}
	public void LoadNextLevel()
	{
	 Application.LoadLevel(Application.loadedLevel + 1);
	}
	
}
