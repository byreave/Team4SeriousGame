using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultCanvasControl : MonoBehaviour {

    private static int i_suffix = 1;
    private static string suffix;
    private static string prefix = "Lvl_";
    private static string stageName;

    public void OnRestartClick()
    {
        //SceneManager.LoadScene("SampleScene");
        playGame();
        SceneManager.LoadScene(stageName);
    }
    public void OnNextClick()
    {
        //SceneManager.LoadScene("SampleScene");
        i_suffix++;
        playGame();
        SceneManager.LoadScene(stageName);
    }

    private void playGame()
    {
        suffix = i_suffix.ToString();
        stageName = prefix + suffix;
        Debug.Log(stageName);
    }
}
