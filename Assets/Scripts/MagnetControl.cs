using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetControl : MonoBehaviour {

    // Use this for initialization
    private Vector3 force;
    [SerializeField]
    private GameObject Player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (Player.GetComponent<PlayerControl>().isMagnetic)
            {
                Rigidbody2D playerRig = Player.GetComponent<Rigidbody2D>();
                //force = 2.0f * Physics.gravity * playerRig.mass * playerRig.gravityScale * Vector2.Distance(Player.transform.position, this.GetComponentInParent<Transform>().position);
                force = 2.0f * Physics.gravity * playerRig.mass * playerRig.gravityScale * this.GetComponent<BoxCollider2D>().size.y;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (Player.GetComponent<PlayerControl>().isMagnetic)
            {
                Rigidbody2D playerRig = Player.GetComponent<Rigidbody2D>();
                
                Player.GetComponent<Rigidbody2D>().AddForce(-2.0f * Physics.gravity * playerRig.mass * playerRig.gravityScale * this.GetComponent<BoxCollider2D>().size.y / Vector2.Distance(Player.transform.position, this.GetComponentInParent<Transform>().position));
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (Player.GetComponent<PlayerControl>().isMagnetic)
            {
                Rigidbody2D playerRig = Player.GetComponent<Rigidbody2D>();

                Player.GetComponent<Rigidbody2D>().AddForce(2.0f * Physics.gravity * playerRig.mass * playerRig.gravityScale * this.GetComponent<BoxCollider2D>().size.y / Vector2.Distance(Player.transform.position, this.GetComponentInParent<Transform>().position));
            }
        }
    }
}
