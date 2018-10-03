using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public void OnPointerDown(PointerEventData eventData)
    {
        if(this.gameObject.name.Equals("ButtonLeft"))
        {
            player.GetComponent<PlayerControl>().toLeft = true;
            Debug.Log("hello");

        }
        if (this.gameObject.name.Equals("ButtonRight"))
            player.GetComponent<PlayerControl>().toRight = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("ButtonLeft"))
            player.GetComponent<PlayerControl>().toLeft = false;
        if (this.gameObject.name.Equals("ButtonRight"))
            player.GetComponent<PlayerControl>().toRight = false;
    }
}
