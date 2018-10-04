using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {

    // Use this for initialization
    public GameObject LightMaskFront;
    public GameObject LightMaskBack;
    public GameObject TriggerObject;

    private bool startFade;
    private float fadeTime = 2.0f;
	void Start () {
        startFade = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(LightMaskFront.activeSelf == false && LightMaskBack.activeSelf == false)
        {
            TriggerObject.GetComponent<BoxCollider2D>().enabled = false;
            startFade = true;
        }

        if(startFade)
        {
            Color c = TriggerObject.GetComponent<SpriteRenderer>().color;
            TriggerObject.GetComponent<SpriteRenderer>().color = new Color(c.r, c.b, c.g, TriggerObject.GetComponent<SpriteRenderer>().color.a - 1.0f / (fadeTime * 60));
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            LightMaskFront.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(collision.GetComponentInParent<PlayerControl>().currentMat.name == "Glass")
                LightMaskBack.SetActive(false);
            else
                LightMaskBack.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LightMaskFront.SetActive(true);
            LightMaskBack.SetActive(true);
        }
    }
}
