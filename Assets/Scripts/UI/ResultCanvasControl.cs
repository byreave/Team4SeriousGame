using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultCanvasControl : MonoBehaviour {

    private GameObject gm;

    private void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GameController");
    }

    public void OnRestartClick()
    {
        gm.GetComponent<GameManager>().StageManager(false);
    }
    public void OnNextClick()
    {
        gm.GetComponent<GameManager>().StageManager(true);
    }
}
