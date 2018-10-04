using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(-Player.GetComponent<Rigidbody2D>().velocity.x * Time.deltaTime / speed, 0.0f, 0.0f));
	}
}
