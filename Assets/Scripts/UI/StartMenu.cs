using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartMenu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //game manager
    private GameObject gm;
    private AudioSource clicksound;

    public AudioClip ClickSoundforStartMenu;

    private void Awake()
    {
        //gm = GameObject.Find("__app");
        gm = GameObject.FindGameObjectWithTag("GameController");
        clicksound = GetComponent<AudioSource>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        clicksound.PlayOneShot(ClickSoundforStartMenu,1);
        if (gm != null)
        {
            gm.GetComponent<GameManager>().StageManager(false);

        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
