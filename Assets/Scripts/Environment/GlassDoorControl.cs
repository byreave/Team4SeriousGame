using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorControl : MonoBehaviour {

    // Use this for initialization
    public Sprite HitOnce;
    public Sprite HitTwice;

    public float glassDoorFadeTime = 2.0f;

    private int lives = 2;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lives == 0)
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            Color c = this.GetComponent<SpriteRenderer>().color;
            this.GetComponent<SpriteRenderer>().color = new Color(c.r, c.g, c.b, this.GetComponent<SpriteRenderer>().color.a - Time.deltaTime / glassDoorFadeTime );
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.GetComponent<PlayerControl>().currentMat.name == "Iron")
            {
                if(lives == 2)
                {
                    lives--;
                    this.GetComponent<SpriteRenderer>().sprite = HitOnce;
                }
                else if(lives == 1)
                {
                    lives--;
                    this.GetComponent<SpriteRenderer>().sprite = HitTwice;
                }
                
            }
        }
    }
}
