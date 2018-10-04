using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {
    public ParticleSystem SnowFall;
    private ArrayList collided;
    public LayerMask layerMask;
    public GameObject Water;
    // Use this for initialization

    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

  
	}
    private void OnJointBreak2D(Joint2D joint)
    {
        
        //Instantiate(Explosion,(joint.transform.position), Quaternion.identity);

        Debug.Log("nice");

    }
    private void OnParticleCollision(GameObject other)
    {
        //ParticleSystem ps = GetComponent<ParticleSystem>();
        //ps.
        Debug.Log("kill");
        Destroy(other);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
    }



}
