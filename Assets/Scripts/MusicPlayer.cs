using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour 
{
	public AudioClip[] myAudioArray;
	private AudioSource audioSource;
	void Awake()
	{
	 DontDestroyOnLoad(gameObject);
	}
	void Start()
	{
	 audioSource = GetComponent<AudioSource>();
	}
	void OnLevelWasLoaded(int level)
	{
	 AudioClip thisLevelMusic = myAudioArray[level];
	 if(thisLevelMusic)
	 {
	  audioSource.clip = thisLevelMusic;
	  audioSource.Play();
	  audioSource.loop = true;
	 }
	}	
}
