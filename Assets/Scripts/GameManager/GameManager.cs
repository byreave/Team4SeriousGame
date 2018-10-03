using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //stagemanager
    public int sm ;

    
	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("StartMenu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StageManager()
    {
        SceneManager.LoadScene("Lvl_6");
    } 
}
