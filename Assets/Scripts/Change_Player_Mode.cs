using UnityEngine;
using UnityEngine.EventSystems;

public class Change_Player_Mode : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public ParticleSystem Ping;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("ChangePlayerMode"))
        {
            player.GetComponent<PlayerControl>().changeMode();
            Instantiate(Ping,player.transform.localPosition,Quaternion.identity);
        }
        Debug.Log("aa");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("ChangePlayerMode"))
        {
        }
    }
}
