using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager soundManager;
	
	void Awake()												//Singleton Awake() method
	{
		if(soundManager == null)
		{
			DontDestroyOnLoad(gameObject);
			soundManager = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}




	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
