using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultCanvasControl : MonoBehaviour {

    public void OnRestartClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnNextClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
