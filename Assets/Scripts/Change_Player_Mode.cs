using UnityEngine;
using UnityEngine.EventSystems;

public class Change_Player_Mode : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("ChangePlayerMode"))
        {
            player.GetComponent<PlayerControl>().changeMode();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("ChangePlayerMode"))
        {
        }
    }
}
