using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {
    public ParticleSystem Explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnJointBreak2D(Joint2D joint)
    {
        
        Instantiate(Explosion,(joint.transform.position), Quaternion.identity);

        Debug.Log("nice");
    }
}
