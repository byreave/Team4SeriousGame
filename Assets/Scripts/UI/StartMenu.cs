using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartMenu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //game manager
    GameObject gm;

    private void Awake()
    {
        gm = Object.FindObjectOfType<GameObject>();
        Debug.Log(gm + " : " );
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //gm.GetComponent<GameManager>().StageManager();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
