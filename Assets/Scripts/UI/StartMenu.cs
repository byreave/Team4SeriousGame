using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartMenu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //game manager
    private GameObject gm;

    private void Awake()
    {
        //gm = GameObject.Find("__app");
        gm = GameObject.FindGameObjectWithTag("GameController");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (gm != null)
        {
            gm.GetComponent<GameManager>().StageManager();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
