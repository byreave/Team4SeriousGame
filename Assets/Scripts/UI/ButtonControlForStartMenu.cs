using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonControlForStartMenu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public void OnPointerDown(PointerEventData eventData)
    {
        if(this.gameObject.name.Equals("ButtonLeft"))
        {
            player.GetComponent<PlayerControlForStartMenu>().toLeft = true;
        }
        if (this.gameObject.name.Equals("ButtonRight"))
            player.GetComponent<PlayerControlForStartMenu>().toRight = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("ButtonLeft"))
            player.GetComponent<PlayerControlForStartMenu>().toLeft = false;
        if (this.gameObject.name.Equals("ButtonRight"))
            player.GetComponent<PlayerControlForStartMenu>().toRight = false;
    }
}
