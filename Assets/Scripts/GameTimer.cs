using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour 
{
    private LevelManager levelManager;
    private Slider slider;
    public int levelSeconds=100;
    public int secondLeft;
    private bool isEndOfLevel = false;
    private AudioSource audioSource;
	// Use this for initialization
	void Start () 
	{
		slider = GetComponent<Slider>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	 slider.value = Time.timeSinceLevelLoad / levelSeconds;
	 bool TimeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);
	 if(TimeIsUp && !isEndOfLevel)
	 {
	  audioSource.Play();
	  print ("Level over");
	  Invoke ("LoadNextLevel",audioSource.clip.length);
	  isEndOfLevel = true;
	 }
	}
	void LoadNextLevel()
	{
	 levelManager.LoadLevel("Level_2");
	}
}
