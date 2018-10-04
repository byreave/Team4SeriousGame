using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //stagemanager
    public int sm ;

    private static int i_suffix = 6;
    private static string suffix;
    private static string prefix = "Lvl_";
    private static string stageName;


    // Use this for initialization
    void Awake () {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("StartMenu");
        suffix = "6";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StageManager(bool passed)
    {
        if (passed)
        {
            i_suffix++;
        }
        concatenateStageName();
        SceneManager.LoadScene(stageName);
    }

    private void concatenateStageName()
    {
        suffix = i_suffix.ToString();
        stageName = prefix + suffix;
    }
}
