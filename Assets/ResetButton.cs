using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.transform.parent.GetChild(0).GetComponent<FadeScript>().fout = true;
        this.transform.parent.GetChild(0).GetComponent<FadeScript>().fin = false;
        this.transform.parent.GetChild(0).GetComponent<FadeScript>().alfa = 0;
        Invoke("StartOver", 3.0f);
    }

    private void StartOver()
    {
        SceneManager.LoadScene("Lvl_6");
    }
}
