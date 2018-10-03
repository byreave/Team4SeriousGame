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

        SceneManager.LoadScene(prefix + "6");

        //concatenateStageName();
        //SceneManager.LoadScene(stageName);
    }
    public void OnNextClick()
    {
        SceneManager.LoadScene(prefix+"6");
        //i_suffix++;
        //concatenateStageName();
        //SceneManager.LoadScene(stageName);
    }

    private void concatenateStageName()
    {
        suffix = i_suffix.ToString();
        stageName = prefix + suffix;
    }
}
