using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {


    public GameObject ObjectToFollow;
    public float speed = 3.0f;
    //private Vector3 offset;
	// Use this for initialization
	void Start () {
        //offset = this.transform.position - ObjectToFollow.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float interpolation = speed * Time.deltaTime;
        Vector3 pos = this.transform.position;
        pos.x = Mathf.Lerp(this.transform.position.x, ObjectToFollow.transform.position.x, interpolation);
        pos.y = Mathf.Lerp(this.transform.position.y, ObjectToFollow.transform.position.y, interpolation);

        this.transform.position = pos;
        //this.transform.position = ObjectToFollow.transform.position;
    }
}
