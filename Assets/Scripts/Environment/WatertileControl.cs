using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatertileControl : MonoBehaviour {

    public float density = 0.01f;

    [SerializeField]
    private Vector2 gravity;
	// Use this for initialization
	void Start () {
        gravity = Physics2D.gravity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Vector2 getCurrentFlotation(Vector3 playerPos, float radius)
    { 
        Vector2 force;
        float h = playerPos.y - this.gameObject.transform.position.y  - this.gameObject.GetComponent<BoxCollider2D>().size.y / 2;

        if(h >= radius)
        {
            Debug.Log("not yet touched water");
            return Vector2.zero;
        }
        else if(h <= - radius)
        {
            Debug.Log("Underwater");
            force = -density * radius * radius * Mathf.PI * gravity;
            return force;
        }
        float area = Mathf.Acos(h / radius) * radius * radius - Mathf.Sqrt((radius * radius - h * h)) * h;
        force = - density * area * gravity; //nagative because anti-gravity direction
        Debug.Log(force);
        return force;
    }
    public void onSliderChange(float value)
    {
        this.density = value;
    }
}
