using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringControl : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    public bool IsPressed;
    public float MinLengthRatio;
    [SerializeField]
    private float K = 100.0f;
    [SerializeField]
    private float TimeToRecover = 1.0f;
    

    public float StartPlayerPos;
    private float EndXPos;

    private Vector3 Scale;
	void Start () {
        Scale = this.transform.localScale;
        IsPressed = true;
        StartPlayerPos = Player.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(IsPressed)
        {
            float distance = StartPlayerPos - Player.transform.position.x;
            Transform t = this.GetComponentInParent<Transform>();
            t.localScale = new Vector3(1 - distance / this.GetComponent<SpriteRenderer>().size.x, 1, 1);
        }
        else
        {
            Vector3 newScale = new Vector3(Mathf.Lerp(this.transform.localScale.x, 1.0f, Time.deltaTime / TimeToRecover), 1.0f, 1.0f);
            this.transform.localScale = newScale;
        }
	}

    public float getBounceForce()
    {
        EndXPos = Player.transform.position.x;
        return ( EndXPos - StartPlayerPos ) * K;
    }
}
