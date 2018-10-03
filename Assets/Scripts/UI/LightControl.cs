using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {

    // Use this for initialization
    public GameObject LightMaskFront;
    public GameObject LightMaskBack;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
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
